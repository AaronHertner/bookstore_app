using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3005
{
    public partial class OwnerPage : Form
    {
        public string email;

        public OwnerPage(string email)
        {
            InitializeComponent();
            this.email = email;

            reportsPanel.Visible = false;
            newBookPanel.Visible = false;
        }

        /*
         * The following blocks of code
         * provide the user with a way of moving the form
         * around in the window
         */
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

        /*
         * adds a box shadow to the window
         */
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        /*
         * this function should be set as both the MouseEnter
         * and MouseLeave trigger so the exit button changes color
         */
        public void changeColor(object sender, EventArgs e)
        {
            if (exitButton.BackColor == Color.FromArgb(57, 66, 79))
            {
                exitButton.BackColor = Color.Tomato;
                return;
            }
            exitButton.BackColor = Color.FromArgb(57, 66, 79);
        }

        /*
         * exit application
         */
        public void exit(object sender, EventArgs e) { Application.Exit(); }

        /*
         * @brief: this function will toggle the form to add a new book
         */
        public void addBookPanel(object sender, EventArgs e)
        {
            newBookPanel.Visible = true;
            reportsPanel.Visible = false;

            //get list of known authors
            DataTable authors = SQL.SQLcommand(@"select * from authors");
            foreach (DataRow row in authors.Rows) 
            {
                authorList.Items.Add(row[0].ToString());
            }
        }

        public void togglePanel(object sender, EventArgs e) { newBookPanel.Visible = false; }

        public void clearNewBookFields() 
        {
            //Book Info
            Title.Clear();
            Author.Clear();
            Pages.Clear();
            Genre.Clear();
            Publisher.Clear();
            Price.Clear();

            //author info
            AuthorName.Clear();
            AuthorEmail.Clear();
            AuthorAddress.Clear();
            AuthorPNum.Clear();
            AuthorAccNum.Clear();
            AuthorCut.Clear();

            authorList.Items.Clear();
        }

        public void logout(object sender, EventArgs e) 
        {
            this.Hide();

            Login tmp = new Login();
            tmp.Location = this.Location;
            tmp.StartPosition = FormStartPosition.CenterScreen;
            tmp.Show();
        }
    
        public void addBook(object sender, EventArgs e) 
        {
            //insert book data into db
            string query = string.Format(@"insert into books values ('{0}', '{1}', {2}, '{3}', '{4}', {5}, random_string(4), '{6}');",
                Title.Text, Author.Text, Pages.Text, Genre.Text, Publisher.Text, Price.Text, email);
            SQL.add_to_db(query);

            //update author information in db
            if (authorList.SelectedIndex < 0) //did not select author from dropdown
            {
                string authorQ = string.Format(@"insert into authors values ('{0}', '{1}', '{2}', {3}, {4});", 
                    AuthorName.Text, AuthorEmail.Text, AuthorAddress.Text, AuthorAccNum.Text, AuthorCut.Text);
                string phoneQ = string.Format(@"insert into phone_number values ('{0}', {1}, '{2}')",
                    AuthorEmail.Text, AuthorAccNum.Text, AuthorPNum.Text);

                //add info to db
                SQL.add_to_db(authorQ);
                SQL.add_to_db(phoneQ);

                //clear fields
                clearNewBookFields();
            }

            MessageBox.Show("Book successfully added");
            clearNewBookFields();
        }

        /*
         * this function will make the reports page visisble
         * and also load the results from a db query
         * based on the current logged in user
         */
        public void loadReports(object sender, EventArgs e) 
        {
            reportsPanel.Visible = true;
            newBookPanel.Visible = false;

            //get report information
            DataTable topRev = SQL.SQLcommand(string.Format(
                @"Select max(money_made) from owner_book_reports where owner = '{0}'", email));
            DataTable topSeller = SQL.SQLcommand(string.Format(
                @"Select max(copies_sold) from owner_book_reports where owner = '{0}'", email));
            DataTable totalSales = SQL.SQLcommand(string.Format(
                @"Select sum(money_made) from owner_book_reports where owner = '{0}'", email));

            string topRevDollar = topRev.Rows[0].Field<double>(0).ToString();
            string topSellerCount = topSeller.Rows[0].Field<Int32>(0).ToString();

            //extra information
            DataTable bookInfo = SQL.SQLcommand(string.Format(
                @"Select title from owner_book_reports where money_made = {0}", topRevDollar));
            DataTable bookInfo2 = SQL.SQLcommand(string.Format(
                @"Select title from owner_book_reports where copies_sold = {0}", topSellerCount));

            string topRevTitle = bookInfo.Rows[0].Field<string>(0);
            string topSellerTitle = bookInfo2.Rows[0].Field<string>(0);

            DataTable topGenre = SQL.SQLcommand(string.Format(
                @"Select genre from books where title = '{0}'", topSellerTitle));

            TopGenre.Text = topGenre.Rows[0].Field<string>(0);
            TopSeller.Text = string.Format("{0} - '{1}'", topSellerCount, topSellerTitle);
            TopRevenue.Text = string.Format("${0} - '{1}'", topRevDollar, topRevTitle);
            TotalRevenue.Text = "$" + totalSales.Rows[0].Field<double>(0).ToString();

            DataTable dt = SQL.SQLcommand(string.Format(
                @"Select title, book_id, copies_sold, money_made from owner_book_reports where owner = '{0}'", email));
            dgvBooks.DataSource = dt;
        }
    }
}
