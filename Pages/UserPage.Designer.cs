namespace COMP3005
{
    partial class UserPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPage));
            this.aMyOrders = new System.Windows.Forms.Button();
            this.aLogOut = new System.Windows.Forms.Button();
            this.aSearchBar = new System.Windows.Forms.TextBox();
            this.aSearch = new System.Windows.Forms.Button();
            this.aExit = new System.Windows.Forms.Button();
            this.aMin = new System.Windows.Forms.Button();
            this.myOrdersPanel = new System.Windows.Forms.TableLayoutPanel();
            this.myCartButton = new System.Windows.Forms.Button();
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.emailLabel = new System.Windows.Forms.Label();
            this.user_email = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchCategory = new System.Windows.Forms.Button();
            this.sidePanelTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fictionSearch = new System.Windows.Forms.Button();
            this.non_fictionSearch = new System.Windows.Forms.Button();
            this.scifiSearch = new System.Windows.Forms.Button();
            this.fantasySearch = new System.Windows.Forms.Button();
            this.poetrySearch = new System.Windows.Forms.Button();
            this.classicSearch = new System.Windows.Forms.Button();
            this.categoryPanel = new System.Windows.Forms.Panel();
            this.welcomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.categoryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // aMyOrders
            // 
            this.aMyOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.aMyOrders.FlatAppearance.BorderSize = 0;
            this.aMyOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aMyOrders.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aMyOrders.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.aMyOrders.Location = new System.Drawing.Point(1233, 0);
            this.aMyOrders.Name = "aMyOrders";
            this.aMyOrders.Size = new System.Drawing.Size(110, 36);
            this.aMyOrders.TabIndex = 1;
            this.aMyOrders.Text = "My Orders";
            this.aMyOrders.UseVisualStyleBackColor = false;
            this.aMyOrders.Click += new System.EventHandler(this.getOrders);
            // 
            // aLogOut
            // 
            this.aLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.aLogOut.FlatAppearance.BorderSize = 0;
            this.aLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aLogOut.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLogOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.aLogOut.Location = new System.Drawing.Point(1339, 0);
            this.aLogOut.Name = "aLogOut";
            this.aLogOut.Size = new System.Drawing.Size(110, 36);
            this.aLogOut.TabIndex = 2;
            this.aLogOut.Text = "Log Out";
            this.aLogOut.UseVisualStyleBackColor = false;
            this.aLogOut.Click += new System.EventHandler(this.logoutButton);
            // 
            // aSearchBar
            // 
            this.aSearchBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.aSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aSearchBar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aSearchBar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.aSearchBar.Location = new System.Drawing.Point(53, 7);
            this.aSearchBar.Name = "aSearchBar";
            this.aSearchBar.Size = new System.Drawing.Size(385, 25);
            this.aSearchBar.TabIndex = 3;
            // 
            // aSearch
            // 
            this.aSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.aSearch.FlatAppearance.BorderSize = 0;
            this.aSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.aSearch.Location = new System.Drawing.Point(439, 1);
            this.aSearch.Name = "aSearch";
            this.aSearch.Size = new System.Drawing.Size(96, 36);
            this.aSearch.TabIndex = 4;
            this.aSearch.Text = "Search";
            this.aSearch.UseVisualStyleBackColor = false;
            this.aSearch.Click += new System.EventHandler(this.searchBooks);
            // 
            // aExit
            // 
            this.aExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.aExit.FlatAppearance.BorderSize = 0;
            this.aExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.aExit.Location = new System.Drawing.Point(1495, 0);
            this.aExit.Name = "aExit";
            this.aExit.Size = new System.Drawing.Size(54, 35);
            this.aExit.TabIndex = 5;
            this.aExit.Text = "X";
            this.aExit.UseVisualStyleBackColor = false;
            this.aExit.Click += new System.EventHandler(this.exit);
            this.aExit.MouseEnter += new System.EventHandler(this.changeColor);
            this.aExit.MouseLeave += new System.EventHandler(this.changeColor);
            // 
            // aMin
            // 
            this.aMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.aMin.FlatAppearance.BorderSize = 0;
            this.aMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aMin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.aMin.Location = new System.Drawing.Point(1441, -1);
            this.aMin.Name = "aMin";
            this.aMin.Size = new System.Drawing.Size(54, 35);
            this.aMin.TabIndex = 6;
            this.aMin.Text = "-";
            this.aMin.UseVisualStyleBackColor = false;
            this.aMin.Click += new System.EventHandler(this.minimize);
            // 
            // myOrdersPanel
            // 
            this.myOrdersPanel.AutoScroll = true;
            this.myOrdersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.myOrdersPanel.ColumnCount = 1;
            this.myOrdersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.92497F));
            this.myOrdersPanel.Location = new System.Drawing.Point(0, 32);
            this.myOrdersPanel.Name = "myOrdersPanel";
            this.myOrdersPanel.RowCount = 2;
            this.myOrdersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.myOrdersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.myOrdersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.myOrdersPanel.Size = new System.Drawing.Size(1549, 847);
            this.myOrdersPanel.TabIndex = 7;
            // 
            // myCartButton
            // 
            this.myCartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.myCartButton.FlatAppearance.BorderSize = 0;
            this.myCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myCartButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myCartButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.myCartButton.Image = ((System.Drawing.Image)(resources.GetObject("myCartButton.Image")));
            this.myCartButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.myCartButton.Location = new System.Drawing.Point(1164, -2);
            this.myCartButton.Name = "myCartButton";
            this.myCartButton.Size = new System.Drawing.Size(71, 37);
            this.myCartButton.TabIndex = 8;
            this.myCartButton.UseVisualStyleBackColor = false;
            this.myCartButton.Click += new System.EventHandler(this.getCart);
            // 
            // welcomePanel
            // 
            this.welcomePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(86)))), ((int)(((byte)(99)))));
            this.welcomePanel.Controls.Add(this.emailLabel);
            this.welcomePanel.Controls.Add(this.user_email);
            this.welcomePanel.Controls.Add(this.label2);
            this.welcomePanel.Controls.Add(this.label1);
            this.welcomePanel.Location = new System.Drawing.Point(620, 319);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(498, 181);
            this.welcomePanel.TabIndex = 9;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.emailLabel.Location = new System.Drawing.Point(186, 3);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(332, 38);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Welcome";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // user_email
            // 
            this.user_email.AutoSize = true;
            this.user_email.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_email.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.user_email.Location = new System.Drawing.Point(104, 52);
            this.user_email.Name = "user_email";
            this.user_email.Size = new System.Drawing.Size(0, 52);
            this.user_email.TabIndex = 2;
            this.user_email.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(8, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "             To view your orders click \'My Orders\' \r\nTo search for new books use " +
    "the search bar above\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome,";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchPanel
            // 
            this.searchPanel.AutoScroll = true;
            this.searchPanel.ColumnCount = 1;
            this.searchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.searchPanel.Location = new System.Drawing.Point(0, 35);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.RowCount = 2;
            this.searchPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.searchPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.searchPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.searchPanel.Size = new System.Drawing.Size(1547, 844);
            this.searchPanel.TabIndex = 7;
            // 
            // searchCategory
            // 
            this.searchCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.searchCategory.FlatAppearance.BorderSize = 0;
            this.searchCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCategory.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCategory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchCategory.Image = ((System.Drawing.Image)(resources.GetObject("searchCategory.Image")));
            this.searchCategory.Location = new System.Drawing.Point(0, 1);
            this.searchCategory.Name = "searchCategory";
            this.searchCategory.Size = new System.Drawing.Size(52, 35);
            this.searchCategory.TabIndex = 11;
            this.searchCategory.UseVisualStyleBackColor = false;
            this.searchCategory.Click += new System.EventHandler(this.startTimerOnClick);
            // 
            // sidePanelTimer
            // 
            this.sidePanelTimer.Interval = 1;
            this.sidePanelTimer.Tick += new System.EventHandler(this.slidePanel);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(719, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(755, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Aaron\'s Books";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.panel1.Controls.Add(this.aExit);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.searchCategory);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.aMin);
            this.panel1.Controls.Add(this.aLogOut);
            this.panel1.Controls.Add(this.aMyOrders);
            this.panel1.Controls.Add(this.aSearch);
            this.panel1.Controls.Add(this.myCartButton);
            this.panel1.Controls.Add(this.aSearchBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1546, 35);
            this.panel1.TabIndex = 15;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.makeMovable);
            // 
            // fictionSearch
            // 
            this.fictionSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fictionSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.fictionSearch.FlatAppearance.BorderSize = 0;
            this.fictionSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fictionSearch.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fictionSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fictionSearch.Image = ((System.Drawing.Image)(resources.GetObject("fictionSearch.Image")));
            this.fictionSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fictionSearch.Location = new System.Drawing.Point(0, 3);
            this.fictionSearch.Name = "fictionSearch";
            this.fictionSearch.Size = new System.Drawing.Size(209, 34);
            this.fictionSearch.TabIndex = 0;
            this.fictionSearch.Text = "Fiction";
            this.fictionSearch.UseVisualStyleBackColor = false;
            this.fictionSearch.Click += new System.EventHandler(this.fictionBtnSearch);
            // 
            // non_fictionSearch
            // 
            this.non_fictionSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.non_fictionSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.non_fictionSearch.FlatAppearance.BorderSize = 0;
            this.non_fictionSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.non_fictionSearch.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.non_fictionSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.non_fictionSearch.Image = ((System.Drawing.Image)(resources.GetObject("non_fictionSearch.Image")));
            this.non_fictionSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.non_fictionSearch.Location = new System.Drawing.Point(0, 40);
            this.non_fictionSearch.Name = "non_fictionSearch";
            this.non_fictionSearch.Size = new System.Drawing.Size(209, 34);
            this.non_fictionSearch.TabIndex = 1;
            this.non_fictionSearch.Text = "Non-Fiction";
            this.non_fictionSearch.UseVisualStyleBackColor = false;
            this.non_fictionSearch.Click += new System.EventHandler(this.non_fictionBtnSearch);
            // 
            // scifiSearch
            // 
            this.scifiSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.scifiSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.scifiSearch.FlatAppearance.BorderSize = 0;
            this.scifiSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scifiSearch.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scifiSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.scifiSearch.Image = ((System.Drawing.Image)(resources.GetObject("scifiSearch.Image")));
            this.scifiSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scifiSearch.Location = new System.Drawing.Point(0, 80);
            this.scifiSearch.Name = "scifiSearch";
            this.scifiSearch.Size = new System.Drawing.Size(209, 34);
            this.scifiSearch.TabIndex = 2;
            this.scifiSearch.Text = "Sci Fi";
            this.scifiSearch.UseVisualStyleBackColor = false;
            this.scifiSearch.Click += new System.EventHandler(this.scifiBtnSearch);
            // 
            // fantasySearch
            // 
            this.fantasySearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fantasySearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.fantasySearch.FlatAppearance.BorderSize = 0;
            this.fantasySearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fantasySearch.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fantasySearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fantasySearch.Image = ((System.Drawing.Image)(resources.GetObject("fantasySearch.Image")));
            this.fantasySearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fantasySearch.Location = new System.Drawing.Point(0, 120);
            this.fantasySearch.Name = "fantasySearch";
            this.fantasySearch.Size = new System.Drawing.Size(209, 34);
            this.fantasySearch.TabIndex = 3;
            this.fantasySearch.Text = "Fantasy";
            this.fantasySearch.UseVisualStyleBackColor = false;
            this.fantasySearch.Click += new System.EventHandler(this.scifiBtnSearch);
            // 
            // poetrySearch
            // 
            this.poetrySearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.poetrySearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.poetrySearch.FlatAppearance.BorderSize = 0;
            this.poetrySearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.poetrySearch.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poetrySearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.poetrySearch.Image = ((System.Drawing.Image)(resources.GetObject("poetrySearch.Image")));
            this.poetrySearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.poetrySearch.Location = new System.Drawing.Point(0, 160);
            this.poetrySearch.Name = "poetrySearch";
            this.poetrySearch.Size = new System.Drawing.Size(209, 34);
            this.poetrySearch.TabIndex = 4;
            this.poetrySearch.Text = "Poetry";
            this.poetrySearch.UseVisualStyleBackColor = false;
            this.poetrySearch.Click += new System.EventHandler(this.poetryBtnSearch);
            // 
            // classicSearch
            // 
            this.classicSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.classicSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.classicSearch.FlatAppearance.BorderSize = 0;
            this.classicSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classicSearch.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classicSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.classicSearch.Image = ((System.Drawing.Image)(resources.GetObject("classicSearch.Image")));
            this.classicSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.classicSearch.Location = new System.Drawing.Point(0, 200);
            this.classicSearch.Name = "classicSearch";
            this.classicSearch.Size = new System.Drawing.Size(209, 34);
            this.classicSearch.TabIndex = 5;
            this.classicSearch.Text = "Classics";
            this.classicSearch.UseVisualStyleBackColor = false;
            this.classicSearch.Click += new System.EventHandler(this.classicBtnSearch);
            // 
            // categoryPanel
            // 
            this.categoryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.categoryPanel.Controls.Add(this.classicSearch);
            this.categoryPanel.Controls.Add(this.poetrySearch);
            this.categoryPanel.Controls.Add(this.fantasySearch);
            this.categoryPanel.Controls.Add(this.scifiSearch);
            this.categoryPanel.Controls.Add(this.non_fictionSearch);
            this.categoryPanel.Controls.Add(this.fictionSearch);
            this.categoryPanel.Location = new System.Drawing.Point(-2, 32);
            this.categoryPanel.Name = "categoryPanel";
            this.categoryPanel.Size = new System.Drawing.Size(208, 850);
            this.categoryPanel.TabIndex = 12;
            // 
            // UserPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(86)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1546, 875);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.categoryPanel);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.welcomePanel);
            this.Controls.Add(this.myOrdersPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "UserPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aaron\'s Book Store";
            this.Load += new System.EventHandler(this.userPageOnLoad);
            this.welcomePanel.ResumeLayout(false);
            this.welcomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.categoryPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button aMyOrders;
        private System.Windows.Forms.Button aLogOut;
        private System.Windows.Forms.TextBox aSearchBar;
        private System.Windows.Forms.Button aSearch;
        private System.Windows.Forms.Button aExit;
        private System.Windows.Forms.Button aMin;
        private System.Windows.Forms.TableLayoutPanel myOrdersPanel;
        private System.Windows.Forms.Button myCartButton;
        private System.Windows.Forms.Panel welcomePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel searchPanel;
        private System.Windows.Forms.Button searchCategory;
        private System.Windows.Forms.Timer sidePanelTimer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label user_email;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button fictionSearch;
        private System.Windows.Forms.Button non_fictionSearch;
        private System.Windows.Forms.Button scifiSearch;
        private System.Windows.Forms.Button fantasySearch;
        private System.Windows.Forms.Button poetrySearch;
        private System.Windows.Forms.Button classicSearch;
        private System.Windows.Forms.Panel categoryPanel;
    }
}

