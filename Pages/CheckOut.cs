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
    public partial class CheckOut : Form
    {
        private float totalValue;
        public int userID;
        UserPage userpage;

        public CheckOut()
        {
            InitializeComponent();
        }
        public CheckOut(float f, int id, UserPage up) 
        {
            InitializeComponent();
            totalValue = f;
            userID = id;
            userpage = up;
        }

        public void moveToOrders(object sender, EventArgs e) 
        {
            //get books in cart
            string query = String.Format(@"select * from books_in_cart where user_id = {0}", userID);
            DataTable inCart = SQL.SQLcommand(query);

            //lookup book details
            foreach (DataRow row in inCart.Rows) 
            {
                string query2 = String.Format(@"select * from books where book_id = '{0}'", row[1].ToString());
                DataTable booksToOrder = SQL.SQLcommand(query2);

                foreach (DataRow book in booksToOrder.Rows) 
                {
                    //add book data to 'My Orders'
                    string tmp = string.Format(@"insert into orders values (default, {0}, '{1}', '{2}', {3}, '{4}', current_date)",
                        userID, book[0].ToString(), book[1].ToString(), book[2].ToString(), book[3].ToString());
                    SQL.add_to_db(tmp);

                    //update author and owner pay
                    SQL.add_to_db(string.Format(@"Select split_pay('{0}')", book[0].ToString()));
                    SQL.add_to_db(string.Format(@"select update_reports('{0}')",
                        book[0].ToString()));

                    //remove books from cart
                    string tmp2 = string.Format(@"delete from books_in_cart where user_id = {0}", userID);
                    SQL.add_to_db(tmp2);
                }
            }

            MessageBox.Show("Order Completed.");
            this.Hide();
            userpage.getCart(null, null);
        } 

        /*
         * Adds a box shadow to the window
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

        public void onload(object sender, EventArgs e) { total.Text += totalValue; }
        public void cancelBtn(object sender, EventArgs e) { this.Hide(); }

        //button highlight toggles
        public void toggleVisa(object sender, EventArgs e) 
        {
            visa.BackColor = Color.FromArgb(9, 132, 224);
            amex.BackColor = Color.FromArgb(77, 86, 99);
            mastercard.BackColor = Color.FromArgb(77, 86, 99);
            bitcoin.BackColor = Color.FromArgb(77, 86, 99);
        }
        public void toggleAmex(object sender, EventArgs e)
        {
            visa.BackColor = Color.FromArgb(77, 86, 99);
            amex.BackColor = Color.FromArgb(9, 132, 224);
            mastercard.BackColor = Color.FromArgb(77, 86, 99);
            bitcoin.BackColor = Color.FromArgb(77, 86, 99);
        }
        public void toggleMC(object sender, EventArgs e)
        {
            visa.BackColor = Color.FromArgb(77, 86, 99);
            amex.BackColor = Color.FromArgb(77, 86, 99);
            mastercard.BackColor = Color.FromArgb(9, 132, 224);
            bitcoin.BackColor = Color.FromArgb(77, 86, 99);
        }
        public void toggleBC(object sender, EventArgs e)
        {
            visa.BackColor = Color.FromArgb(77, 86, 99);
            amex.BackColor = Color.FromArgb(77, 86, 99);
            mastercard.BackColor = Color.FromArgb(77, 86, 99);
            bitcoin.BackColor = Color.FromArgb(9, 132, 224);
        }
    }
}
