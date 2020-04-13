namespace COMP3005
{
    partial class BookTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookTab));
            this.bTitle = new System.Windows.Forms.Label();
            this.bAuthor = new System.Windows.Forms.Label();
            this.bPages = new System.Windows.Forms.Label();
            this.bGenre = new System.Windows.Forms.Label();
            this.orderNum = new System.Windows.Forms.Label();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.Pages = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.Label();
            this.OrderNumber = new System.Windows.Forms.Label();
            this.trackOrderBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.OrderDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // bTitle
            // 
            resources.ApplyResources(this.bTitle, "bTitle");
            this.bTitle.Name = "bTitle";
            // 
            // bAuthor
            // 
            resources.ApplyResources(this.bAuthor, "bAuthor");
            this.bAuthor.Name = "bAuthor";
            // 
            // bPages
            // 
            resources.ApplyResources(this.bPages, "bPages");
            this.bPages.Name = "bPages";
            // 
            // bGenre
            // 
            resources.ApplyResources(this.bGenre, "bGenre");
            this.bGenre.Name = "bGenre";
            // 
            // orderNum
            // 
            resources.ApplyResources(this.orderNum, "orderNum");
            this.orderNum.Name = "orderNum";
            // 
            // Picture
            // 
            resources.ApplyResources(this.Picture, "Picture");
            this.Picture.Name = "Picture";
            this.Picture.TabStop = false;
            // 
            // Title
            // 
            resources.ApplyResources(this.Title, "Title");
            this.Title.Name = "Title";
            // 
            // Author
            // 
            resources.ApplyResources(this.Author, "Author");
            this.Author.Name = "Author";
            // 
            // Pages
            // 
            resources.ApplyResources(this.Pages, "Pages");
            this.Pages.Name = "Pages";
            // 
            // Genre
            // 
            resources.ApplyResources(this.Genre, "Genre");
            this.Genre.Name = "Genre";
            // 
            // OrderNumber
            // 
            resources.ApplyResources(this.OrderNumber, "OrderNumber");
            this.OrderNumber.Name = "OrderNumber";
            // 
            // trackOrderBtn
            // 
            resources.ApplyResources(this.trackOrderBtn, "trackOrderBtn");
            this.trackOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.trackOrderBtn.FlatAppearance.BorderSize = 0;
            this.trackOrderBtn.Name = "trackOrderBtn";
            this.trackOrderBtn.UseVisualStyleBackColor = false;
            this.trackOrderBtn.Click += new System.EventHandler(this.trackOrder);
            // 
            // cancelBtn
            // 
            resources.ApplyResources(this.cancelBtn, "cancelBtn");
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.removeOrder);
            // 
            // OrderDate
            // 
            resources.ApplyResources(this.OrderDate, "OrderDate");
            this.OrderDate.Name = "OrderDate";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // BookTab
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(79)))));
            this.Controls.Add(this.OrderDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.trackOrderBtn);
            this.Controls.Add(this.OrderNumber);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Pages);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.orderNum);
            this.Controls.Add(this.bGenre);
            this.Controls.Add(this.bPages);
            this.Controls.Add(this.bAuthor);
            this.Controls.Add(this.bTitle);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "BookTab";
            resources.ApplyResources(this, "$this");
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bTitle;
        private System.Windows.Forms.Label bAuthor;
        private System.Windows.Forms.Label bPages;
        private System.Windows.Forms.Label bGenre;
        private System.Windows.Forms.Label orderNum;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label Pages;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.Label OrderNumber;
        private System.Windows.Forms.Button trackOrderBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label OrderDate;
        private System.Windows.Forms.Label label2;
    }
}
