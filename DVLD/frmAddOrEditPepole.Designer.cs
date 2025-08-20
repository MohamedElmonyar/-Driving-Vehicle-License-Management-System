namespace DVLD
{
    partial class frmAddOrEditPepole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOrEditPepole));
            this.ctrnAddOrEditPerson1 = new DVLD.ctrnAddOrEditPerson();
            this.SuspendLayout();
            // 
            // ctrnAddOrEditPerson1
            // 
            this.ctrnAddOrEditPerson1._Person_ID = 0;
            this.ctrnAddOrEditPerson1.AutoSize = true;
            this.ctrnAddOrEditPerson1.BackColor = System.Drawing.Color.White;
            this.ctrnAddOrEditPerson1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctrnAddOrEditPerson1.BackgroundImage")));
            this.ctrnAddOrEditPerson1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrnAddOrEditPerson1.Location = new System.Drawing.Point(2, 0);
            this.ctrnAddOrEditPerson1.Name = "ctrnAddOrEditPerson1";
            this.ctrnAddOrEditPerson1.Size = new System.Drawing.Size(1065, 552);
            this.ctrnAddOrEditPerson1.TabIndex = 4;
            // 
            // frmAddOrEditPepole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 522);
            this.Controls.Add(this.ctrnAddOrEditPerson1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddOrEditPepole";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Pepole Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddOrEditPepole_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ctrnAddOrEditPerson ctrnAddOrEditPerson1;
    }
}