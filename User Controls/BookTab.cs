using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3005
{
    public partial class BookTab : UserControl
    {

        //public fields
        public int userID;

        public BookTab()
        {
            InitializeComponent();
        }
        public BookTab(int id) 
        {
            InitializeComponent();
            userID = id;
        }

        /*
         * @brief removeOrder() will remove the specified book from
         *        the user's orders.
         */
        public void removeOrder(object sender, EventArgs e) 
        {
            this.Hide();
            string query = String.Format(@"delete from orders where user_id = {0} and order_num = {1}", 
                userID, OrderNumber.Text);
            SQL.add_to_db(query);
            MessageBox.Show("Order cancelled");
        }

        public void trackOrder(object sender, EventArgs e) 
        {
            //get data
            DataTable dt = SQL.SQLcommand(string.Format(
                @"select * from shipping where user_id = {0} and order_num = {1}",
                userID, OrderNumber.Text));

            MessageBox.Show(string.Format("Your order of '{0}', order number = {1}, was ordered on {2} - and arrives {3}",
                Title.Text, OrderNumber.Text, OrderDate.Text, dt.Rows[0][3].ToString()));
        }

        //Properties
        public Image BookImage 
        {
            get { return Picture.Image; }
            set { Picture.Image = value; }
        }
        public string BookTitle 
        {
            get { return Title.Text; }
            set { Title.Text = value; }
        }
        public string BookAuthor
        {
            get { return Author.Text; }
            set { Author.Text = value; }
        }
        public string BookPages
        {
            get { return Pages.Text; }
            set { Pages.Text = value; }
        }
        public string BookGenre
        {
            get { return Genre.Text; }
            set { Genre.Text = value; }
        }
        public string BookOrderNumber 
        {
            get { return OrderNumber.Text; }
            set { OrderNumber.Text = value; }
        }
        public string BookOrderDate 
        {
            get { return OrderDate.Text; }
            set { OrderDate.Text = value; }
        }
    }
}
