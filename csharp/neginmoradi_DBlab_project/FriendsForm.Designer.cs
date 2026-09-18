namespace neginmoradi_DBlab_project
{
    partial class FriendsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FriendsForm));
            this.btnHome = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblFriends = new System.Windows.Forms.Label();
            this.dataGridViewFriends = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriends)).BeginInit();
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
            // lblFriends
            // 
            this.lblFriends.AutoSize = true;
            this.lblFriends.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriends.Location = new System.Drawing.Point(44, 132);
            this.lblFriends.Name = "lblFriends";
            this.lblFriends.Size = new System.Drawing.Size(61, 18);
            this.lblFriends.TabIndex = 21;
            this.lblFriends.Text = "Friends";
            // 
            // dataGridViewFriends
            // 
            this.dataGridViewFriends.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.dataGridViewFriends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFriends.Location = new System.Drawing.Point(47, 162);
            this.dataGridViewFriends.Name = "dataGridViewFriends";
            this.dataGridViewFriends.RowHeadersWidth = 51;
            this.dataGridViewFriends.RowTemplate.Height = 24;
            this.dataGridViewFriends.Size = new System.Drawing.Size(701, 259);
            this.dataGridViewFriends.TabIndex = 20;
            // 
            // FriendsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFriends);
            this.Controls.Add(this.dataGridViewFriends);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.imgLogo);
            this.Name = "FriendsForm";
            this.Text = "User Friends Form";
            this.Load += new System.EventHandler(this.FriendsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriends)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblFriends;
        private System.Windows.Forms.DataGridView dataGridViewFriends;
    }
}