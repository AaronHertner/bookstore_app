namespace COMP3005
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.confirmSignUp = new System.Windows.Forms.Button();
            this.cancelSignUp = new System.Windows.Forms.Button();
            this.storeOwner = new System.Windows.Forms.CheckBox();
            this.termsAndConds = new System.Windows.Forms.CheckBox();
            this.signupWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.passwordLabel.Location = new System.Drawing.Point(114, 78);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(108, 23);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password:";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.emailLabel.Location = new System.Drawing.Point(144, 37);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(67, 23);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email:";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.password.Location = new System.Drawing.Point(217, 78);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(464, 25);
            this.password.TabIndex = 5;
            this.password.UseSystemPasswordChar = true;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.email.Location = new System.Drawing.Point(217, 35);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(464, 25);
            this.email.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(50, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Confirm Password:";
            // 
            // confirmPassword
            // 
            this.confirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.confirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.confirmPassword.Location = new System.Drawing.Point(217, 120);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(464, 25);
            this.confirmPassword.TabIndex = 8;
            this.confirmPassword.UseSystemPasswordChar = true;
            // 
            // confirmSignUp
            // 
            this.confirmSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(224)))));
            this.confirmSignUp.FlatAppearance.BorderSize = 0;
            this.confirmSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmSignUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.confirmSignUp.Location = new System.Drawing.Point(264, 254);
            this.confirmSignUp.Name = "confirmSignUp";
            this.confirmSignUp.Size = new System.Drawing.Size(134, 52);
            this.confirmSignUp.TabIndex = 10;
            this.confirmSignUp.Text = "Confirm";
            this.confirmSignUp.UseVisualStyleBackColor = false;
            this.confirmSignUp.Click += new System.EventHandler(this.confirmBtn);
            // 
            // cancelSignUp
            // 
            this.cancelSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(86)))), ((int)(((byte)(99)))));
            this.cancelSignUp.FlatAppearance.BorderSize = 0;
            this.cancelSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelSignUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelSignUp.Location = new System.Drawing.Point(404, 254);
            this.cancelSignUp.Name = "cancelSignUp";
            this.cancelSignUp.Size = new System.Drawing.Size(134, 52);
            this.cancelSignUp.TabIndex = 11;
            this.cancelSignUp.Text = "Cancel";
            this.cancelSignUp.UseVisualStyleBackColor = false;
            this.cancelSignUp.Click += new System.EventHandler(this.cancelBtn);
            // 
            // storeOwner
            // 
            this.storeOwner.AutoSize = true;
            this.storeOwner.FlatAppearance.BorderSize = 0;
            this.storeOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storeOwner.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeOwner.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.storeOwner.Location = new System.Drawing.Point(217, 171);
            this.storeOwner.Name = "storeOwner";
            this.storeOwner.Size = new System.Drawing.Size(220, 25);
            this.storeOwner.TabIndex = 12;
            this.storeOwner.Text = "Are you a store owner?";
            this.storeOwner.UseVisualStyleBackColor = true;
            // 
            // termsAndConds
            // 
            this.termsAndConds.AutoSize = true;
            this.termsAndConds.FlatAppearance.BorderSize = 0;
            this.termsAndConds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.termsAndConds.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termsAndConds.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.termsAndConds.Location = new System.Drawing.Point(217, 202);
            this.termsAndConds.Name = "termsAndConds";
            this.termsAndConds.Size = new System.Drawing.Size(323, 25);
            this.termsAndConds.TabIndex = 13;
            this.termsAndConds.Text = "I agree to the terms and conditions";
            this.termsAndConds.UseVisualStyleBackColor = true;
            // 
            // signupWarning
            // 
            this.signupWarning.AutoSize = true;
            this.signupWarning.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupWarning.ForeColor = System.Drawing.Color.Tomato;
            this.signupWarning.Location = new System.Drawing.Point(271, 319);
            this.signupWarning.Name = "signupWarning";
            this.signupWarning.Size = new System.Drawing.Size(224, 23);
            this.signupWarning.TabIndex = 14;
            this.signupWarning.Text = "Missing or invalid fields";
            this.signupWarning.Visible = false;
            // 
            // SignUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(86)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(808, 364);
            this.Controls.Add(this.signupWarning);
            this.Controls.Add(this.termsAndConds);
            this.Controls.Add(this.storeOwner);
            this.Controls.Add(this.cancelSignUp);
            this.Controls.Add(this.confirmSignUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.Button confirmSignUp;
        private System.Windows.Forms.Button cancelSignUp;
        private System.Windows.Forms.CheckBox storeOwner;
        private System.Windows.Forms.CheckBox termsAndConds;
        private System.Windows.Forms.Label signupWarning;
    }
}