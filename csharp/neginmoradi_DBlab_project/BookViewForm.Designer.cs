namespace neginmoradi_DBlab_project
{
    partial class BookViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookViewForm));
            this.btnHome = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.imgBookCover = new System.Windows.Forms.PictureBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblSampleBookName = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblSampleISBN = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblSampleGenre = new System.Windows.Forms.Label();
            this.lblPublicationDate = new System.Windows.Forms.Label();
            this.lblSamplePublicationDate = new System.Windows.Forms.Label();
            this.lblSampleAuthorName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(702, 18);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 37);
            this.btnHome.TabIndex = 19;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(12, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(164, 49);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 18;
            this.imgLogo.TabStop = false;
            // 
            // imgBookCover
            // 
            this.imgBookCover.Location = new System.Drawing.Point(324, 34);
            this.imgBookCover.Name = "imgBookCover";
            this.imgBookCover.Size = new System.Drawing.Size(149, 202);
            this.imgBookCover.TabIndex = 20;
            this.imgBookCover.TabStop = false;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(209, 248);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(112, 21);
            this.lblBookName.TabIndex = 21;
            this.lblBookName.Text = "Book Name:";
            // 
            // lblSampleBookName
            // 
            this.lblSampleBookName.AutoSize = true;
            this.lblSampleBookName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSampleBookName.Location = new System.Drawing.Point(338, 248);
            this.lblSampleBookName.Name = "lblSampleBookName";
            this.lblSampleBookName.Size = new System.Drawing.Size(162, 21);
            this.lblSampleBookName.TabIndex = 22;
            this.lblSampleBookName.Text = "sample book name";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(260, 287);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(61, 21);
            this.lblISBN.TabIndex = 23;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblSampleISBN
            // 
            this.lblSampleISBN.AutoSize = true;
            this.lblSampleISBN.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSampleISBN.Location = new System.Drawing.Point(338, 287);
            this.lblSampleISBN.Name = "lblSampleISBN";
            this.lblSampleISBN.Size = new System.Drawing.Size(163, 21);
            this.lblSampleISBN.TabIndex = 24;
            this.lblSampleISBN.Text = "sample book ISBN";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(256, 364);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(65, 21);
            this.lblGenre.TabIndex = 25;
            this.lblGenre.Text = "Genre:";
            // 
            // lblSampleGenre
            // 
            this.lblSampleGenre.AutoSize = true;
            this.lblSampleGenre.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSampleGenre.Location = new System.Drawing.Point(338, 364);
            this.lblSampleGenre.Name = "lblSampleGenre";
            this.lblSampleGenre.Size = new System.Drawing.Size(163, 21);
            this.lblSampleGenre.TabIndex = 26;
            this.lblSampleGenre.Text = "sample book genre";
            // 
            // lblPublicationDate
            // 
            this.lblPublicationDate.AutoSize = true;
            this.lblPublicationDate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublicationDate.Location = new System.Drawing.Point(169, 402);
            this.lblPublicationDate.Name = "lblPublicationDate";
            this.lblPublicationDate.Size = new System.Drawing.Size(152, 21);
            this.lblPublicationDate.TabIndex = 27;
            this.lblPublicationDate.Text = "Publication Date:";
            // 
            // lblSamplePublicationDate
            // 
            this.lblSamplePublicationDate.AutoSize = true;
            this.lblSamplePublicationDate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSamplePublicationDate.Location = new System.Drawing.Point(338, 402);
            this.lblSamplePublicationDate.Name = "lblSamplePublicationDate";
            this.lblSamplePublicationDate.Size = new System.Drawing.Size(204, 21);
            this.lblSamplePublicationDate.TabIndex = 28;
            this.lblSamplePublicationDate.Text = "sample publication date";
            // 
            // lblSampleAuthorName
            // 
            this.lblSampleAuthorName.AutoSize = true;
            this.lblSampleAuthorName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSampleAuthorName.Location = new System.Drawing.Point(338, 324);
            this.lblSampleAuthorName.Name = "lblSampleAuthorName";
            this.lblSampleAuthorName.Size = new System.Drawing.Size(174, 21);
            this.lblSampleAuthorName.TabIndex = 30;
            this.lblSampleAuthorName.Text = "sample author name";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(247, 324);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(73, 21);
            this.lblAuthor.TabIndex = 29;
            this.lblAuthor.Text = "Author:";
            // 
            // BookViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSampleAuthorName);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblSamplePublicationDate);
            this.Controls.Add(this.lblPublicationDate);
            this.Controls.Add(this.lblSampleGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblSampleISBN);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblSampleBookName);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.imgBookCover);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.imgLogo);
            this.Name = "BookViewForm";
            this.Text = "Book View Form";
            this.Load += new System.EventHandler(this.BookViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBookCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.PictureBox imgBookCover;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblSampleBookName;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblSampleISBN;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblSampleGenre;
        private System.Windows.Forms.Label lblPublicationDate;
        private System.Windows.Forms.Label lblSamplePublicationDate;
        private System.Windows.Forms.Label lblSampleAuthorName;
        private System.Windows.Forms.Label lblAuthor;
    }
}