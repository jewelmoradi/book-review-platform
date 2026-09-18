namespace neginmoradi_DBlab_project
{
    partial class AuthorMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorMainForm));
            this.lblSampleUserName = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.imgAuthorProfile = new System.Windows.Forms.PictureBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lblListOfBooks = new System.Windows.Forms.Label();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAuthorProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSampleUserName
            // 
            this.lblSampleUserName.AutoSize = true;
            this.lblSampleUserName.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSampleUserName.Location = new System.Drawing.Point(669, 85);
            this.lblSampleUserName.Name = "lblSampleUserName";
            this.lblSampleUserName.Size = new System.Drawing.Size(133, 16);
            this.lblSampleUserName.TabIndex = 10;
            this.lblSampleUserName.Text = "sample author name";
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(12, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(164, 49);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 9;
            this.imgLogo.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(644, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(41, 39);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(358, 17);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(327, 39);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.Text = "Search books";
            // 
            // imgAuthorProfile
            // 
            this.imgAuthorProfile.Location = new System.Drawing.Point(720, 19);
            this.imgAuthorProfile.Name = "imgAuthorProfile";
            this.imgAuthorProfile.Size = new System.Drawing.Size(54, 54);
            this.imgAuthorProfile.TabIndex = 6;
            this.imgAuthorProfile.TabStop = false;
            this.imgAuthorProfile.Click += new System.EventHandler(this.imgAuthorProfile_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Location = new System.Drawing.Point(219, 19);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(101, 37);
            this.btnAddBook.TabIndex = 18;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // lblListOfBooks
            // 
            this.lblListOfBooks.AutoSize = true;
            this.lblListOfBooks.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfBooks.Location = new System.Drawing.Point(44, 132);
            this.lblListOfBooks.Name = "lblListOfBooks";
            this.lblListOfBooks.Size = new System.Drawing.Size(101, 18);
            this.lblListOfBooks.TabIndex = 20;
            this.lblListOfBooks.Text = "List of books";
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(47, 162);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowHeadersWidth = 51;
            this.dataGridViewBooks.RowTemplate.Height = 24;
            this.dataGridViewBooks.Size = new System.Drawing.Size(701, 259);
            this.dataGridViewBooks.TabIndex = 19;
            // 
            // AuthorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblListOfBooks);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.lblSampleUserName);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.imgAuthorProfile);
            this.Name = "AuthorMainForm";
            this.Text = "Author Main Form";
            this.Load += new System.EventHandler(this.AuthorMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAuthorProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSampleUserName;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox imgAuthorProfile;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label lblListOfBooks;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
    }
}