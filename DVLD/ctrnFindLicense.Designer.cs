namespace DVLD
{
    partial class ctrnFindLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrnFindLicense));
            this.label4 = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.btnSearchPerson = new System.Windows.Forms.Button();
            this.ctrnLicenseInfo1 = new DVLD.ctrnLicenseInfo();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(2, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 31);
            this.label4.TabIndex = 137;
            this.label4.Text = "License ID :";
            // 
            // tbFilter
            // 
            this.tbFilter.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.tbFilter.Location = new System.Drawing.Point(147, 11);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(260, 33);
            this.tbFilter.TabIndex = 138;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.BackColor = System.Drawing.Color.White;
            this.btnSearchPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchPerson.BackgroundImage")));
            this.btnSearchPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchPerson.FlatAppearance.BorderSize = 0;
            this.btnSearchPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchPerson.Location = new System.Drawing.Point(413, 4);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.Size = new System.Drawing.Size(62, 46);
            this.btnSearchPerson.TabIndex = 139;
            this.btnSearchPerson.UseVisualStyleBackColor = false;
            this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click);
            // 
            // ctrnLicenseInfo1
            // 
            this.ctrnLicenseInfo1.BackColor = System.Drawing.Color.White;
            this.ctrnLicenseInfo1.License_ID = -1;
            this.ctrnLicenseInfo1.LocalLicenseApp_ID = -1;
            this.ctrnLicenseInfo1.Location = new System.Drawing.Point(4, 53);
            this.ctrnLicenseInfo1.Name = "ctrnLicenseInfo1";
            this.ctrnLicenseInfo1.Size = new System.Drawing.Size(1210, 411);
            this.ctrnLicenseInfo1.TabIndex = 136;
            // 
            // ctrnFindLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.btnSearchPerson);
            this.Controls.Add(this.ctrnLicenseInfo1);
            this.Name = "ctrnFindLicense";
            this.Size = new System.Drawing.Size(1221, 471);
            this.Load += new System.EventHandler(this.ctrnFindLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Button btnSearchPerson;
        private ctrnLicenseInfo ctrnLicenseInfo1;
    }
}
