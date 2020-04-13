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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        public bool credsCheck() 
        {
            bool credsGood = false;

            //password check
            if (password.Text == confirmPassword.Text) { credsGood = true; }
            else { credsGood = false; }

            //check valid email
            if (email.Text.Contains("@")) { credsGood = true; }
            else { credsGood = false; }

            //check terms and conditions
            if (termsAndConds.Checked) { credsGood = true; }
            else { credsGood = false; }

            return credsGood;
        }

        public void confirmBtn(object sender, EventArgs e) 
        {
            signupWarning.Visible = false;
            if (credsCheck())
            {
                //check for email in use
                DataTable DT_EMAILCHECK = SQL.SQLcommand(@"Select * from users");
                foreach (DataRow row in DT_EMAILCHECK.Rows)
                {
                    if (email.Text == row[1].ToString()) //already used email
                    {
                        signupWarning.Visible = true;
                        return;
                    }
                }

                //add user
                SQL.add_to_db(@"Select add_user('" + email.Text + "'," + "'" + password.Text + "'," +
                        storeOwner.Checked + ");");

                if (!storeOwner.Checked) //load user page
                {
                    UserPage up = new UserPage();
                    up.UserEmail = email.Text;
                    up.Location = this.Location;
                    up.StartPosition = FormStartPosition.CenterScreen;
                    this.Hide();
                    up.Show();
                    return;
                }
                else {
                    SQL.add_to_db(string.Format(@"insert into owner values (0.00,'{0}')", email.Text));
                    OwnerPage op = new OwnerPage(email.Text);
                    op.Location = this.Location;
                    op.StartPosition = FormStartPosition.CenterScreen;
                    this.Hide();
                    op.Show();
                }
            }
            else 
            {
                signupWarning.Visible = true;
                return;
            }
        }

        public void cancelBtn(object sender, EventArgs e) 
        {
            Login log = new Login();
            log.Location = this.Location;
            log.Show();
            this.Hide();
        }
    }
}
