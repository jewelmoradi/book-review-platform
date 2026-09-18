namespace neginmoradi_DBlab_project
{
    partial class StartingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingForm));
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblIntroduction = new System.Windows.Forms.Label();
            this.imjLogo = new System.Windows.Forms.PictureBox();
            this.imgBooks = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imjLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(327, 162);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(123, 29);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "Sign up with email";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FloralWhite;
            this.btnSignIn.ForeColor = System.Drawing.Color.Black;
            this.btnSignIn.Location = new System.Drawing.Point(294, 197);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(190, 24);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "Already a member? Sign in";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lblIntroduction
            // 
            this.lblIntroduction.AutoSize = true;
            this.lblIntroduction.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntroduction.Location = new System.Drawing.Point(251, 90);
            this.lblIntroduction.Name = "lblIntroduction";
            this.lblIntroduction.Size = new System.Drawing.Size(290, 24);
            this.lblIntroduction.TabIndex = 7;
            this.lblIntroduction.Text = "Meet your next favorite book.";
            // 
            // imjLogo
            // 
            this.imjLogo.Image = ((System.Drawing.Image)(resources.GetObject("imjLogo.Image")));
            this.imjLogo.Location = new System.Drawing.Point(310, 32);
            this.imjLogo.Name = "imjLogo";
            this.imjLogo.Size = new System.Drawing.Size(164, 49);
            this.imjLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imjLogo.TabIndex = 1;
            this.imjLogo.TabStop = false;
            // 
            // imgBooks
            // 
            this.imgBooks.Image = ((System.Drawing.Image)(resources.GetObject("imgBooks.Image")));
            this.imgBooks.Location = new System.Drawing.Point(0, 294);
            this.imgBooks.Name = "imgBooks";
            this.imgBooks.Size = new System.Drawing.Size(802, 216);
            this.imgBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBooks.TabIndex = 0;
            this.imgBooks.TabStop = false;
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIntroduction);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.imjLogo);
            this.Controls.Add(this.imgBooks);
            this.Name = "StartingForm";
            this.Text = "Starting Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imjLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBooks;
        private System.Windows.Forms.PictureBox imjLogo;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblIntroduction;
    }
}

