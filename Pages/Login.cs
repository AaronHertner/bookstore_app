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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Icon = new Icon("icons/iconmain.ico");
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

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

        private void makeMovable(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void changeColor(object sender, EventArgs e) 
        {
            if (exitButton.BackColor == Color.FromArgb(77, 86, 99)) {
                exitButton.BackColor = Color.Tomato;
                return;
            }
            exitButton.BackColor = Color.FromArgb(77, 86, 99);
        }

        public void exit(object sender, EventArgs e)  { Application.Exit(); }
        
        public void login(object sender, EventArgs e) 
        {
            //clear bad login warning
            loginWarning.Visible = false;

            //get data
            DataTable dt = SQL.SQLcommand(@"Select * from logins");

            //check if there is data
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (email.Text == row[0].ToString() && password.Text == row[1].ToString()) //good login
                    {
                        if (!(bool)row[2]) //user page
                        {
                            UserPage up = new UserPage();
                            up.UserEmail = email.Text;
                            up.Location = this.Location;
                            up.StartPosition = FormStartPosition.CenterScreen;
                            this.Hide();
                            up.Show();
                        }
                        else //owner page 
                        {
                            //show owner page
                            OwnerPage op = new OwnerPage(email.Text);
                            op.Location = this.Location;
                            op.StartPosition = FormStartPosition.CenterScreen;
                            this.Hide();
                            op.Show();

                        }
                        return;
                    }
                }
                loginWarning.Visible = true;
                return;
            }
        }

        public void userSignUp(object sender, EventArgs e) 
        {
            SignUp su = new SignUp();
            su.Location = this.Location;
            su.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            su.Show();
        }
    }
}
