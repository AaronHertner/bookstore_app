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
    public partial class CartBook : UserControl
    {
        //fields
        public int userID;

        public CartBook()
        {
            InitializeComponent();
        }
        public CartBook(int id) 
        {
            InitializeComponent();
            this.userID = id;
        }

        //properties
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
        public string BookPrice
        {
            get { return Price.Text; }
            set { Price.Text = value; }
        }
        public string BookID 
        {
            get { return ID.Text; }
            set { ID.Text = value; }
        }

        /*
         *@brief this function will remove the selected item from the users cart
         */
        public void removeItem(object sender, EventArgs e) 
        {
            string query = String.Format(@"select remove_from_cart({0}, '{1}')", userID, BookID);
            SQL.add_to_db(query);
            this.Hide();
        }
    }
}
