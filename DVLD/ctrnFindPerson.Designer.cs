namespace DVLD
{
    partial class ctrnFindPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrnFindPerson));
            this.btnAddnew = new System.Windows.Forms.Button();
            this.btnSearchPerson = new System.Windows.Forms.Button();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrnPI = new DVLD.ctrnPersonDetails();
            this.SuspendLayout();
            // 
            // btnAddnew
            // 
            this.btnAddnew.BackColor = System.Drawing.Color.Transparent;
            this.btnAddnew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddnew.BackgroundImage")));
            this.btnAddnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddnew.Location = new System.Drawing.Point(549, 8);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(43, 43);
            this.btnAddnew.TabIndex = 48;
            this.btnAddnew.Text = " ";
            this.btnAddnew.UseVisualStyleBackColor = false;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click_1);
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.BackColor = System.Drawing.Color.White;
            this.btnSearchPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchPerson.BackgroundImage")));
            this.btnSearchPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchPerson.FlatAppearance.BorderSize = 0;
            this.btnSearchPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchPerson.Location = new System.Drawing.Point(497, 8);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.Size = new System.Drawing.Size(43, 43);
            this.btnSearchPerson.TabIndex = 47;
            this.btnSearchPerson.UseVisualStyleBackColor = false;
            this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click_1);
            // 
            // tbFilter
            // 
            this.tbFilter.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.tbFilter.Location = new System.Drawing.Point(311, 15);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(169, 30);
            this.tbFilter.TabIndex = 46;
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress_1);
            // 
            // cbFilter
            // 
            this.cbFilter.DisplayMember = "None";
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Person ID",
            "National Number"});
            this.cbFilter.Location = new System.Drawing.Point(136, 15);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(169, 31);
            this.cbFilter.TabIndex = 45;
            this.cbFilter.ValueMember = "None";
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 31);
            this.label2.TabIndex = 44;
            this.label2.Text = "Filter By:";
            // 
            // ctrnPI
            // 
            this.ctrnPI.AutoSize = true;
            this.ctrnPI.BackColor = System.Drawing.Color.Transparent;
            this.ctrnPI.Enabled = false;
            this.ctrnPI.Location = new System.Drawing.Point(12, 54);
            this.ctrnPI.Name = "ctrnPI";
            this.ctrnPI.Person_ID = 0;
            this.ctrnPI.Size = new System.Drawing.Size(1128, 355);
            this.ctrnPI.TabIndex = 49;
            // 
            // ctrnFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.btnSearchPerson);
            this.Controls.Add(this.btnAddnew);
            this.Controls.Add(this.ctrnPI);
            this.Name = "ctrnFindPerson";
            this.Size = new System.Drawing.Size(1145, 422);
            this.Load += new System.EventHandler(this.ctrnFindPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.Button btnSearchPerson;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label2;
        public ctrnPersonDetails ctrnPI;
    }
}
