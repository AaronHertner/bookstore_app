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
    public partial class SearchBookItem : UserControl
    {
        //public fields
        public int userID = -1;
        public int panelWidth = 1111;
        public int waitCount = 0;

        public SearchBookItem()
        {
            InitializeComponent();
        }
        public SearchBookItem(int id)
        {
            InitializeComponent();
            userID = id;
            addedPanel.Visible = false;
            addedPanel.Width = this.Width;
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
        public string BookPublisher
        {
            get { return Publisher.Text; }
            set { Publisher.Text = value; }
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
         * @brief addToCart() will add the desired item to the users cart
         * @param 'sender' is the object which raised the event
         * @param 'e' properties related to object raising the event
         * 
         * Adds the desired item to the cart
         */
        public void addToCart(object sender, EventArgs e) 
        {

            addedPanel.Visible = true;
            string query = String.Format(@"insert into books_in_cart values ({0}, '{1}', {2})", userID, ID.Text, 1);
            SQL.add_to_db(query);

            //start timer
            addedTextTimer.Start();
        }

        /*
         * @brief textTimer() will remove the 'Added' message after 1 second
         */
        public void textTimer(object sender, EventArgs e) 
        {   if(waitCount < 1000) 
            {
                waitCount += 50;
                return;
            }
            if (addedPanel.Width > 0) { addedPanel.Width -= 110; }
            else 
            {
                addedTextTimer.Stop();
                addedPanel.Visible = false;
                addedPanel.Width = panelWidth;
            }
        }
    }
}
