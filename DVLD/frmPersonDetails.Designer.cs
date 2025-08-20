namespace DVLD
{
    partial class frmPersonDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonDetails));
            this.laStauts = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctrnPersonDetails1 = new DVLD.ctrnPersonDetails();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // laStauts
            // 
            this.laStauts.AutoSize = true;
            this.laStauts.BackColor = System.Drawing.Color.Transparent;
            this.laStauts.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laStauts.ForeColor = System.Drawing.Color.Black;
            this.laStauts.Location = new System.Drawing.Point(431, 53);
            this.laStauts.Name = "laStauts";
            this.laStauts.Size = new System.Drawing.Size(274, 48);
            this.laStauts.TabIndex = 32;
            this.laStauts.Text = "Person Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(280, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // ctrnPersonDetails1
            // 
            this.ctrnPersonDetails1.BackColor = System.Drawing.Color.Transparent;
            this.ctrnPersonDetails1.Location = new System.Drawing.Point(4, 150);
            this.ctrnPersonDetails1.Name = "ctrnPersonDetails1";
            this.ctrnPersonDetails1.NationalNumber = null;
            this.ctrnPersonDetails1.Person_ID = 0;
            this.ctrnPersonDetails1.Size = new System.Drawing.Size(1116, 376);
            this.ctrnPersonDetails1.TabIndex = 33;
            // 
            // frmPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1124, 538);
            this.Controls.Add(this.laStauts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctrnPersonDetails1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersonDetails";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Person Details";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label laStauts;
        private ctrnPersonDetails ctrnPersonDetails1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}