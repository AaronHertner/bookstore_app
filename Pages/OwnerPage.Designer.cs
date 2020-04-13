namespace COMP3005
{
    partial class OwnerPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.loadReportsBtn = new System.Windows.Forms.Button();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.newBookPanel = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.AuthorCut = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Publisher = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AuthorName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.authorList = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AuthorAccNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AuthorPNum = new System.Windows.Forms.TextBox();
            this.cancelSignUp = new System.Windows.Forms.Button();
            this.confirmSignUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AuthorAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AuthorEmail = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pages = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.reportsPanel = new System.Windows.Forms.Panel();
            this.TotalRevenue = new System.Windows.Forms.Label();
            this.TopRevenue = new System.Windows.Forms.Label();
            this.TopSeller = new System.Windows.Forms.Label();
            this.TopGenre = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.newBookPanel.SuspendLayout();
            this.reportsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.loadReportsBtn);
            this.panel1.Controls.Add(this.addBookBtn);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 51);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.makeMovable);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(790, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.logout);
            // 
            // loadReportsBtn
            // 
            this.loadReportsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.loadReportsBtn.FlatAppearance.BorderSize = 0;
            this.loadReportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadReportsBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadReportsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loadReportsBtn.Location = new System.Drawing.Point(55, 0);
            this.loadReportsBtn.Name = "loadReportsBtn";
            this.loadReportsBtn.Size = new System.Drawing.Size(132, 51);
            this.loadReportsBtn.TabIndex = 9;
            this.loadReportsBtn.Text = "Reports";
            this.loadReportsBtn.UseVisualStyleBackColor = false;
            this.loadReportsBtn.Click += new System.EventHandler(this.loadReports);
            // 
            // addBookBtn
            // 
            this.addBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.addBookBtn.FlatAppearance.BorderSize = 0;
            this.addBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addBookBtn.Location = new System.Drawing.Point(0, 0);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(53, 51);
            this.addBookBtn.TabIndex = 8;
            this.addBookBtn.Text = "+";
            this.addBookBtn.UseVisualStyleBackColor = false;
            this.addBookBtn.Click += new System.EventHandler(this.addBookPanel);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitButton.Location = new System.Drawing.Point(924, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(53, 51);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exit);
            this.exitButton.MouseEnter += new System.EventHandler(this.changeColor);
            this.exitButton.MouseLeave += new System.EventHandler(this.changeColor);
            // 
            // newBookPanel
            // 
            this.newBookPanel.Controls.Add(this.label14);
            this.newBookPanel.Controls.Add(this.AuthorCut);
            this.newBookPanel.Controls.Add(this.label12);
            this.newBookPanel.Controls.Add(this.Price);
            this.newBookPanel.Controls.Add(this.label13);
            this.newBookPanel.Controls.Add(this.Publisher);
            this.newBookPanel.Controls.Add(this.label11);
            this.newBookPanel.Controls.Add(this.AuthorName);
            this.newBookPanel.Controls.Add(this.label10);
            this.newBookPanel.Controls.Add(this.authorList);
            this.newBookPanel.Controls.Add(this.label9);
            this.newBookPanel.Controls.Add(this.label8);
            this.newBookPanel.Controls.Add(this.label7);
            this.newBookPanel.Controls.Add(this.label6);
            this.newBookPanel.Controls.Add(this.AuthorAccNum);
            this.newBookPanel.Controls.Add(this.label5);
            this.newBookPanel.Controls.Add(this.AuthorPNum);
            this.newBookPanel.Controls.Add(this.cancelSignUp);
            this.newBookPanel.Controls.Add(this.confirmSignUp);
            this.newBookPanel.Controls.Add(this.label2);
            this.newBookPanel.Controls.Add(this.AuthorAddress);
            this.newBookPanel.Controls.Add(this.label3);
            this.newBookPanel.Controls.Add(this.label4);
            this.newBookPanel.Controls.Add(this.AuthorEmail);
            this.newBookPanel.Controls.Add(this.Genre);
            this.newBookPanel.Controls.Add(this.label1);
            this.newBookPanel.Controls.Add(this.Pages);
            this.newBookPanel.Controls.Add(this.passwordLabel);
            this.newBookPanel.Controls.Add(this.emailLabel);
            this.newBookPanel.Controls.Add(this.Author);
            this.newBookPanel.Controls.Add(this.Title);
            this.newBookPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newBookPanel.Location = new System.Drawing.Point(0, 51);
            this.newBookPanel.Name = "newBookPanel";
            this.newBookPanel.Size = new System.Drawing.Size(977, 947);
            this.newBookPanel.TabIndex = 1;
            this.newBookPanel.Visible = false;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(142, 635);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 23);
            this.label14.TabIndex = 40;
            this.label14.Text = "Royalty (%):";
            // 
            // AuthorCut
            // 
            this.AuthorCut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.AuthorCut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuthorCut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorCut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AuthorCut.Location = new System.Drawing.Point(288, 635);
            this.AuthorCut.Name = "AuthorCut";
            this.AuthorCut.Size = new System.Drawing.Size(464, 25);
            this.AuthorCut.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(211, 308);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 23);
            this.label12.TabIndex = 38;
            this.label12.Text = "Price:";
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Price.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Price.Location = new System.Drawing.Point(288, 308);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(464, 25);
            this.Price.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(172, 265);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 36;
            this.label13.Text = "Publisher:";
            // 
            // Publisher
            // 
            this.Publisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.Publisher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Publisher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publisher.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Publisher.Location = new System.Drawing.Point(288, 263);
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(464, 25);
            this.Publisher.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(197, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 23);
            this.label11.TabIndex = 34;
            this.label11.Text = "Name:";
            // 
            // AuthorName
            // 
            this.AuthorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.AuthorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuthorName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AuthorName.Location = new System.Drawing.Point(288, 431);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(464, 25);
            this.AuthorName.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(146, 762);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 23);
            this.label10.TabIndex = 32;
            this.label10.Text = "Select an Author:";
            // 
            // authorList
            // 
            this.authorList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorList.FormattingEnabled = true;
            this.authorList.Location = new System.Drawing.Point(344, 759);
            this.authorList.Name = "authorList";
            this.authorList.Size = new System.Drawing.Size(340, 31);
            this.authorList.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(495, 691);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 23);
            this.label9.TabIndex = 30;
            this.label9.Text = "OR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(284, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 23);
            this.label8.TabIndex = 29;
            this.label8.Text = "Book Information:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(284, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Author Information:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(75, 592);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Account  Number:";
            // 
            // AuthorAccNum
            // 
            this.AuthorAccNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.AuthorAccNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuthorAccNum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorAccNum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AuthorAccNum.Location = new System.Drawing.Point(288, 595);
            this.AuthorAccNum.Name = "AuthorAccNum";
            this.AuthorAccNum.Size = new System.Drawing.Size(464, 25);
            this.AuthorAccNum.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(110, 552);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Phone Number:";
            // 
            // AuthorPNum
            // 
            this.AuthorPNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.AuthorPNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuthorPNum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorPNum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AuthorPNum.Location = new System.Drawing.Point(288, 555);
            this.AuthorPNum.Name = "AuthorPNum";
            this.AuthorPNum.Size = new System.Drawing.Size(464, 25);
            this.AuthorPNum.TabIndex = 24;
            // 
            // cancelSignUp
            // 
            this.cancelSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(86)))), ((int)(((byte)(99)))));
            this.cancelSignUp.FlatAppearance.BorderSize = 0;
            this.cancelSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelSignUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelSignUp.Location = new System.Drawing.Point(517, 868);
            this.cancelSignUp.Name = "cancelSignUp";
            this.cancelSignUp.Size = new System.Drawing.Size(134, 52);
            this.cancelSignUp.TabIndex = 23;
            this.cancelSignUp.Text = "Cancel";
            this.cancelSignUp.UseVisualStyleBackColor = false;
            this.cancelSignUp.Click += new System.EventHandler(this.togglePanel);
            // 
            // confirmSignUp
            // 
            this.confirmSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(224)))));
            this.confirmSignUp.FlatAppearance.BorderSize = 0;
            this.confirmSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmSignUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.confirmSignUp.Location = new System.Drawing.Point(377, 868);
            this.confirmSignUp.Name = "confirmSignUp";
            this.confirmSignUp.Size = new System.Drawing.Size(134, 52);
            this.confirmSignUp.TabIndex = 22;
            this.confirmSignUp.Text = "Confirm";
            this.confirmSignUp.UseVisualStyleBackColor = false;
            this.confirmSignUp.Click += new System.EventHandler(this.addBook);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(179, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Address:";
            // 
            // AuthorAddress
            // 
            this.AuthorAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.AuthorAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuthorAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorAddress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AuthorAddress.Location = new System.Drawing.Point(288, 514);
            this.AuthorAddress.Name = "AuthorAddress";
            this.AuthorAddress.Size = new System.Drawing.Size(464, 25);
            this.AuthorAddress.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(205, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(196, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Genre:";
            // 
            // AuthorEmail
            // 
            this.AuthorEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.AuthorEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuthorEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AuthorEmail.Location = new System.Drawing.Point(288, 472);
            this.AuthorEmail.Name = "AuthorEmail";
            this.AuthorEmail.Size = new System.Drawing.Size(464, 25);
            this.AuthorEmail.TabIndex = 17;
            // 
            // Genre
            // 
            this.Genre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.Genre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Genre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Genre.Location = new System.Drawing.Point(288, 218);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(464, 25);
            this.Genre.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(197, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pages:";
            // 
            // Pages
            // 
            this.Pages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.Pages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pages.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pages.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Pages.Location = new System.Drawing.Point(288, 173);
            this.Pages.Name = "Pages";
            this.Pages.Size = new System.Drawing.Size(464, 25);
            this.Pages.TabIndex = 14;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.passwordLabel.Location = new System.Drawing.Point(190, 128);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(80, 23);
            this.passwordLabel.TabIndex = 13;
            this.passwordLabel.Text = "Author:";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.emailLabel.Location = new System.Drawing.Point(221, 85);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(51, 23);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Title:";
            // 
            // Author
            // 
            this.Author.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.Author.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Author.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Author.Location = new System.Drawing.Point(288, 131);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(464, 25);
            this.Author.TabIndex = 11;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(288, 88);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(464, 25);
            this.Title.TabIndex = 10;
            // 
            // reportsPanel
            // 
            this.reportsPanel.Controls.Add(this.dgvBooks);
            this.reportsPanel.Controls.Add(this.TotalRevenue);
            this.reportsPanel.Controls.Add(this.TopRevenue);
            this.reportsPanel.Controls.Add(this.TopSeller);
            this.reportsPanel.Controls.Add(this.TopGenre);
            this.reportsPanel.Controls.Add(this.label18);
            this.reportsPanel.Controls.Add(this.label17);
            this.reportsPanel.Controls.Add(this.label16);
            this.reportsPanel.Controls.Add(this.label15);
            this.reportsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportsPanel.Location = new System.Drawing.Point(0, 51);
            this.reportsPanel.Name = "reportsPanel";
            this.reportsPanel.Size = new System.Drawing.Size(977, 947);
            this.reportsPanel.TabIndex = 2;
            // 
            // TotalRevenue
            // 
            this.TotalRevenue.AutoSize = true;
            this.TotalRevenue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRevenue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TotalRevenue.Location = new System.Drawing.Point(257, 285);
            this.TotalRevenue.Name = "TotalRevenue";
            this.TotalRevenue.Size = new System.Drawing.Size(156, 23);
            this.TotalRevenue.TabIndex = 7;
            this.TotalRevenue.Text = "Total Revenue:";
            // 
            // TopRevenue
            // 
            this.TopRevenue.AutoSize = true;
            this.TopRevenue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopRevenue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TopRevenue.Location = new System.Drawing.Point(257, 221);
            this.TopRevenue.Name = "TopRevenue";
            this.TopRevenue.Size = new System.Drawing.Size(144, 23);
            this.TopRevenue.TabIndex = 6;
            this.TopRevenue.Text = "Top Revenue:";
            // 
            // TopSeller
            // 
            this.TopSeller.AutoSize = true;
            this.TopSeller.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopSeller.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TopSeller.Location = new System.Drawing.Point(257, 151);
            this.TopSeller.Name = "TopSeller";
            this.TopSeller.Size = new System.Drawing.Size(108, 23);
            this.TopSeller.TabIndex = 5;
            this.TopSeller.Text = "Top Seller:";
            // 
            // TopGenre
            // 
            this.TopGenre.AutoSize = true;
            this.TopGenre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopGenre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TopGenre.Location = new System.Drawing.Point(257, 85);
            this.TopGenre.Name = "TopGenre";
            this.TopGenre.Size = new System.Drawing.Size(117, 23);
            this.TopGenre.TabIndex = 4;
            this.TopGenre.Text = "Top Genre:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label18.Location = new System.Drawing.Point(76, 285);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(156, 23);
            this.label18.TabIndex = 3;
            this.label18.Text = "Total Revenue:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label17.Location = new System.Drawing.Point(75, 221);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(144, 23);
            this.label17.TabIndex = 2;
            this.label17.Text = "Top Revenue:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label16.Location = new System.Drawing.Point(75, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 23);
            this.label16.TabIndex = 1;
            this.label16.Text = "Top Seller:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label15.Location = new System.Drawing.Point(76, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 23);
            this.label15.TabIndex = 0;
            this.label15.Text = "Top Genre:";
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AllowUserToOrderColumns = true;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(79, 373);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(816, 326);
            this.dgvBooks.TabIndex = 8;
            // 
            // OwnerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(86)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(977, 998);
            this.Controls.Add(this.reportsPanel);
            this.Controls.Add(this.newBookPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OwnerPage";
            this.Text = "OwnerPage";
            this.panel1.ResumeLayout(false);
            this.newBookPanel.ResumeLayout(false);
            this.newBookPanel.PerformLayout();
            this.reportsPanel.ResumeLayout(false);
            this.reportsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Panel newBookPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AuthorAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AuthorEmail;
        private System.Windows.Forms.TextBox Genre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pages;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Button cancelSignUp;
        private System.Windows.Forms.Button confirmSignUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AuthorPNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AuthorAccNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox authorList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox AuthorName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Publisher;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox AuthorCut;
        private System.Windows.Forms.Button loadReportsBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel reportsPanel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label TotalRevenue;
        private System.Windows.Forms.Label TopRevenue;
        private System.Windows.Forms.Label TopSeller;
        private System.Windows.Forms.Label TopGenre;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvBooks;
    }
}