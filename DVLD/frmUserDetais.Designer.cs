namespace DVLD
{
    partial class frmUserDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserDetails));
            this.ctrnUserDetails1 = new DVLD.ctrnUserDetails();
            this.SuspendLayout();
            // 
            // ctrnUserDetails1
            // 
            this.ctrnUserDetails1.BackColor = System.Drawing.Color.White;
            this.ctrnUserDetails1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctrnUserDetails1.BackgroundImage")));
            this.ctrnUserDetails1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrnUserDetails1.Location = new System.Drawing.Point(3, -2);
            this.ctrnUserDetails1.Name = "ctrnUserDetails1";
            this.ctrnUserDetails1.Size = new System.Drawing.Size(1151, 605);
            this.ctrnUserDetails1.TabIndex = 0;
            this.ctrnUserDetails1.User_ID = 0;
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1156, 609);
            this.Controls.Add(this.ctrnUserDetails1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserDetails";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Details";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrnUserDetails ctrnUserDetails1;
    }
}