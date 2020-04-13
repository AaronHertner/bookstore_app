using System;
using System.Globalization;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace COMP3005
{
    public partial class UserPage : Form
    {

        //fields
        private string userEmail;       //holds on to the currently logged in email
        private int userID;             //holds on to the currently logged in id
        public int panelWidth;          //sliding panel width counter
        public bool Hidden;             //sliding panel state flag
        public float totalCartPrice = 0;//keeps track of total price of cart 
        public bool emptyCart = false;

        //properties
        public String UserEmail 
        {
            get { return userEmail; }
            set { userEmail = value; }
        }
        public int UserID 
        {
            get { return userID; }
            set { userID = value; }
        }

        /*
         * @brief constructor for UserPage
         */
        public UserPage()
        {
            InitializeComponent();

            this.Icon = new Icon("icons/iconmain.ico");

            //category search panel
            panelWidth = categoryPanel.Width;
            Hidden = true;
            categoryPanel.Width = 0;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void makeMovable(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void startTimerOnClick(object sender, EventArgs e) 
        {
            sidePanelTimer.Start();
        }

        public void slidePanel(object sender, EventArgs e) 
        {
            if (Hidden)
            {
                categoryPanel.Width += 30;
                if (categoryPanel.Width >= panelWidth)
                {
                    sidePanelTimer.Stop();
                    Hidden = false;
                    return;
                }
            }
            else 
            {
                categoryPanel.Width -= 30;
                if (categoryPanel.Width <= 0) 
                {
                    sidePanelTimer.Stop();
                    Hidden = true;
                    return;
                }
            }
        }


        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_COMPOSITED = 0x02000000;
                var cp = base.CreateParams;
                cp.ExStyle |= WS_EX_COMPOSITED;
                return cp;
            }
        }

        /*
         * @brief getCart() will find all the books in the cart 
         *        of the user who is currently logged in
         */
        public void getCart(object sender, EventArgs e) 
        {
            //reset cart price
            totalCartPrice = 0;

            //set button highlight
            myCartButton.BackColor = Color.FromArgb(0, 184, 148);
            aMyOrders.BackColor = Color.FromArgb(9, 132, 227);

            //disable other panels
            searchPanel.Visible = false;
            myOrdersPanel.Visible = true;
            welcomePanel.Visible = false;

            //clear data in panel
            myOrdersPanel.Controls.Clear();

            //add checkout options
            Button btn = new Button();
            btn.Dock = DockStyle.Top;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(0, 184, 148);
            btn.ForeColor = Color.White;
            btn.Font = new Font("Century Gothic", 12);
            btn.Name = "checkOutBtn";
            btn.Height = 50;
            btn.Click += new System.EventHandler(this.checkout);
            myOrdersPanel.Controls.Add(btn);




            //get lookup information
            DataTable cartItems = SQL.SQLcommand(@"Select * from books_in_cart where user_id = " + UserID); //get data
            DataTable bookLookup;

            foreach (DataRow row in cartItems.Rows) 
            {
                //get data for books from ids
                string query = String.Format(@"select * from books where book_id = '{0}'", row[1]);
                bookLookup = SQL.SQLcommand(query);

                //build cart object item
                CartBook cb = new CartBook(userID);
                cb.BookTitle = bookLookup.Rows[0].Field<string>(0);
                cb.BookAuthor = bookLookup.Rows[0].Field<string>(1);
                cb.BookPages = bookLookup.Rows[0].Field<int>(2).ToString();
                cb.BookGenre = bookLookup.Rows[0].Field<string>(3);
                cb.BookPrice = bookLookup.Rows[0][5].ToString();
                cb.BookID = row[1].ToString();

                totalCartPrice += Convert.ToSingle(bookLookup.Rows[0][5]);

                //format object on form
                cb.Dock = DockStyle.Top;
                myOrdersPanel.Controls.Add(cb);
            }

            //add checkout button text
            float truncated = (float)(Math.Truncate((double)totalCartPrice * 100.0) / 100.0);
            btn.Text = String.Format("Check Out (${0})", truncated);
        }

        /*
         * @brief checkout will load a checkout window for the user
         *          on confirmation it will add all books in cart
         *          to the 'My Orders' page
         */
        public void checkout(object sender, EventArgs e) 
        {
            //load checkout window
            CheckOut co = new CheckOut((float)(Math.Truncate((double)totalCartPrice * 100.0) / 100.0), userID, this);
            co.StartPosition = FormStartPosition.CenterScreen;
            co.Location = this.Location;
            co.Show();
        }

        public void notify(Boolean flag) 
        {
            emptyCart = flag;
        }

        private void changeColor(object sender, EventArgs e)
        {
            if (aExit.BackColor == Color.FromArgb(9, 132, 227))
            {
                aExit.BackColor = Color.Tomato;
                return;
            }
            aExit.BackColor = Color.FromArgb(9, 132, 227);
        }

        private void exit(object sender, EventArgs e) {Application.Exit();}
        private void minimize(object sender, EventArgs e) {WindowState = FormWindowState.Minimized;}

        public void logoutButton(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Location = this.Location;
            login.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            login.Show();
        }

        public void userPageOnLoad(object sender, EventArgs e) 
        {
            welcomePanel.Visible = true;
            myOrdersPanel.Visible = false;
            searchPanel.Visible = false;

            userID = SQL.get_userID(UserEmail);
            emailLabel.Text = UserEmail;
        }

        public void getOrders(object sender, EventArgs e) 
        {
            //set button highlight
            myCartButton.BackColor = Color.FromArgb(9, 132, 227);
            aMyOrders.BackColor = Color.FromArgb(0, 184, 148);

            myOrdersPanel.Controls.Clear(); 
            //get data
            DataTable dt = SQL.SQLcommand(@"Select * from orders where user_id = " + userID);
            
            if(dt != null) //good data
            {
                //swap panels
                welcomePanel.Visible = false;
                searchPanel.Visible = false;
                myOrdersPanel.Visible = true;

                BookTab bt; //controls we will add


                foreach (DataRow row in dt.Rows)
                {
                     bt = new BookTab(userID);
                     bt.BookTitle = row[2].ToString();
                     bt.BookAuthor = row[3].ToString();
                     bt.BookPages = row[4].ToString();
                     bt.BookGenre = row[5].ToString();
                     bt.BookOrderNumber = row[0].ToString();
                    bt.BookOrderDate = row[6].ToString();
                    bt.Dock = DockStyle.Top;

                    myOrdersPanel.Controls.Add(bt);
                }
            }
        }
        
        public void searchBooks(object sender, EventArgs e) 
        {
            myCartButton.BackColor = Color.FromArgb(9, 132, 227);
            aMyOrders.BackColor = Color.FromArgb(9, 132, 227);

            searchPanel.Controls.Clear();

            //clear other pages
            myOrdersPanel.Visible = false;
            welcomePanel.Visible = false;
            searchPanel.Visible = true;

            //get data
            DataTable dt = SQL.SQLcommand(@"Select * from books");
            if (dt != null) 
            {

                SearchBookItem sb;

                foreach (DataRow row in dt.Rows) 
                {
                    if (resultMatch(aSearchBar.Text, row))
                    {
                        sb = new SearchBookItem(UserID);
                        sb.BookTitle = row[0].ToString();
                        sb.BookAuthor = row[1].ToString();
                        sb.BookPublisher = row[4].ToString();
                        sb.BookPages = row[2].ToString();
                        sb.BookGenre = row[3].ToString();
                        sb.BookPrice = row[5].ToString();
                        sb.BookID = row[6].ToString();
                        sb.Dock = DockStyle.Top;

                        searchPanel.Controls.Add(sb);
                    }
                }
            }
        }
        
        public bool resultMatch(string key, DataRow row)
        {
            for (int i = 0; i < 6; i++)
            {
                if (key == row[i].ToString()) { return true; }
            }
            return false;
        }

        public DataTable getBooksByGenre(string genre) 
        {
            myCartButton.BackColor = Color.FromArgb(9, 132, 227);
            aMyOrders.BackColor = Color.FromArgb(9, 132, 227);

            DataTable dt = SQL.SQLcommand(@"select * from books where genre = '" + genre + "'");
            return dt;
        }

        //SEARCH BUTTONS
        public void fictionBtnSearch(object sender, EventArgs e) 
        {
            searchPanel.Controls.Clear();

            DataTable dt = getBooksByGenre("Fiction");
            if (dt != null) 
            {
                //display search page
                welcomePanel.Visible = false;
                searchPanel.Visible = true;
                myOrdersPanel.Visible = false;

                SearchBookItem sb;
                foreach (DataRow row in dt.Rows) 
                {
                    sb = new SearchBookItem(UserID);
                    sb.BookTitle = row[0].ToString();
                    sb.BookAuthor = row[1].ToString();
                    sb.BookPublisher = row[4].ToString();
                    sb.BookPages = row[2].ToString();
                    sb.BookGenre = row[3].ToString();
                    sb.BookPrice = row[5].ToString();
                    sb.BookID = row[6].ToString();
                    sb.Dock = DockStyle.Top;

                    searchPanel.Controls.Add(sb);
                }
            }
        }
        public void non_fictionBtnSearch(object sender, EventArgs e)
        {
            searchPanel.Controls.Clear();

            DataTable dt = getBooksByGenre("Non-Fiction");
            if (dt != null)
            {
                //display search page
                welcomePanel.Visible = false;
                searchPanel.Visible = true;
                myOrdersPanel.Visible = false;

                SearchBookItem sb;
                foreach (DataRow row in dt.Rows)
                {
                    sb = new SearchBookItem(UserID);
                    sb.BookTitle = row[0].ToString();
                    sb.BookAuthor = row[1].ToString();
                    sb.BookPublisher = row[4].ToString();
                    sb.BookPages = row[2].ToString();
                    sb.BookGenre = row[3].ToString();
                    sb.BookPrice = row[5].ToString();
                    sb.BookID = row[6].ToString();
                    sb.Dock = DockStyle.Top;

                    searchPanel.Controls.Add(sb);
                }
            }
        }
        public void scifiBtnSearch(object sender, EventArgs e)
        {
            searchPanel.Controls.Clear();

            DataTable dt = getBooksByGenre("Sci Fi/Fantasy");
            if (dt != null)
            {
                //display search page
                welcomePanel.Visible = false;
                searchPanel.Visible = true;
                myOrdersPanel.Visible = false;

                SearchBookItem sb;
                foreach (DataRow row in dt.Rows)
                {
                    sb = new SearchBookItem(UserID);
                    sb.BookTitle = row[0].ToString();
                    sb.BookAuthor = row[1].ToString();
                    sb.BookPublisher = row[4].ToString();
                    sb.BookPages = row[2].ToString();
                    sb.BookGenre = row[3].ToString();
                    sb.BookPrice = row[5].ToString();
                    sb.BookID = row[6].ToString();
                    sb.Dock = DockStyle.Top;

                    searchPanel.Controls.Add(sb);
                }
            }
        }
        public void poetryBtnSearch(object sender, EventArgs e)
        {
            searchPanel.Controls.Clear();

            DataTable dt = getBooksByGenre("Poetry");
            if (dt != null)
            {
                //display search page
                welcomePanel.Visible = false;
                searchPanel.Visible = true;
                myOrdersPanel.Visible = false;

                SearchBookItem sb;
                foreach (DataRow row in dt.Rows)
                {
                    sb = new SearchBookItem(UserID);
                    sb.BookTitle = row[0].ToString();
                    sb.BookAuthor = row[1].ToString();
                    sb.BookPublisher = row[4].ToString();
                    sb.BookPages = row[2].ToString();
                    sb.BookGenre = row[3].ToString();
                    sb.BookPrice = row[5].ToString();
                    sb.BookID = row[6].ToString();
                    sb.Dock = DockStyle.Top;

                    searchPanel.Controls.Add(sb);
                }
            }
        }
        public void classicBtnSearch(object sender, EventArgs e)
        {
            searchPanel.Controls.Clear();

            DataTable dt = getBooksByGenre("Fiction/Classic");
            if (dt != null)
            {
                //display search page
                welcomePanel.Visible = false;
                searchPanel.Visible = true;
                myOrdersPanel.Visible = false;

                SearchBookItem sb;
                foreach (DataRow row in dt.Rows)
                {
                    sb = new SearchBookItem(UserID);
                    sb.BookTitle = row[0].ToString();
                    sb.BookAuthor = row[1].ToString();
                    sb.BookPublisher = row[4].ToString();
                    sb.BookPages = row[2].ToString();
                    sb.BookGenre = row[3].ToString();
                    sb.BookPrice = row[5].ToString();
                    sb.BookID = row[6].ToString();
                    sb.Dock = DockStyle.Top;

                    searchPanel.Controls.Add(sb);
                }
            }
        }
    }
}