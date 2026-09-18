namespace neginmoradi_DBlab_project
{
    partial class UserMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMainForm));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSampleUserName = new System.Windows.Forms.Label();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.lblListOfBooks = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFriends = new System.Windows.Forms.Button();
            this.imgUserProfile = new System.Windows.Forms.PictureBox();
            this.lblFriends = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUserProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(215, 17);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(327, 39);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Search books";
            // 
            // lblSampleUserName
            // 
            this.lblSampleUserName.AutoSize = true;
            this.lblSampleUserName.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSampleUserName.Location = new System.Drawing.Point(656, 74);
            this.lblSampleUserName.Name = "lblSampleUserName";
            this.lblSampleUserName.Size = new System.Drawing.Size(119, 16);
            this.lblSampleUserName.TabIndex = 5;
            this.lblSampleUserName.Text = "sample user name";
            this.lblSampleUserName.Click += new System.EventHandler(this.label1_Click);
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
            this.dataGridViewBooks.TabIndex = 8;
            // 
            // lblListOfBooks
            // 
            this.lblListOfBooks.AutoSize = true;
            this.lblListOfBooks.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfBooks.Location = new System.Drawing.Point(44, 132);
            this.lblListOfBooks.Name = "lblListOfBooks";
            this.lblListOfBooks.Size = new System.Drawing.Size(101, 18);
            this.lblListOfBooks.TabIndex = 9;
            this.lblListOfBooks.Text = "List of books";
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(12, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(164, 49);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 4;
            this.imgLogo.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(501, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(41, 39);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFriends
            // 
            this.btnFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFriends.Image = ((System.Drawing.Image)(resources.GetObject("btnFriends.Image")));
            this.btnFriends.Location = new System.Drawing.Point(573, 9);
            this.btnFriends.Name = "btnFriends";
            this.btnFriends.Size = new System.Drawing.Size(54, 54);
            this.btnFriends.TabIndex = 1;
            this.btnFriends.UseVisualStyleBackColor = true;
            this.btnFriends.Click += new System.EventHandler(this.btnFriends_Click);
            // 
            // imgUserProfile
            // 
            this.imgUserProfile.Location = new System.Drawing.Point(694, 9);
            this.imgUserProfile.Name = "imgUserProfile";
            this.imgUserProfile.Size = new System.Drawing.Size(54, 54);
            this.imgUserProfile.TabIndex = 0;
            this.imgUserProfile.TabStop = false;
            this.imgUserProfile.Click += new System.EventHandler(this.imgUserProfile_Click);
            // 
            // lblFriends
            // 
            this.lblFriends.AutoSize = true;
            this.lblFriends.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriends.Location = new System.Drawing.Point(573, 74);
            this.lblFriends.Name = "lblFriends";
            this.lblFriends.Size = new System.Drawing.Size(53, 16);
            this.lblFriends.TabIndex = 10;
            this.lblFriends.Text = "Friends";
            // 
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFriends);
            this.Controls.Add(this.lblListOfBooks);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.lblSampleUserName);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnFriends);
            this.Controls.Add(this.imgUserProfile);
            this.Name = "UserMainForm";
            this.Text = "User Main Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUserProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgUserProfile;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblSampleUserName;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Label lblListOfBooks;
        private System.Windows.Forms.Button btnFriends;
        private System.Windows.Forms.Label lblFriends;
    }
}