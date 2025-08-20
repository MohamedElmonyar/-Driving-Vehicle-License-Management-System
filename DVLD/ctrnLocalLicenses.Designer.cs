namespace DVLD
{
    partial class ctrnLocalLicenses
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrnLocalLicenses));
            this.Tcparent = new System.Windows.Forms.TabControl();
            this.tpLocallicense = new System.Windows.Forms.TabPage();
            this.dgvLocalLicenseApp = new System.Windows.Forms.DataGridView();
            this.tpInternationallicense = new System.Windows.Forms.TabPage();
            this.dgvInternational = new System.Windows.Forms.DataGridView();
            this.cmsdgvDrivers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Tcparent.SuspendLayout();
            this.tpLocallicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenseApp)).BeginInit();
            this.tpInternationallicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternational)).BeginInit();
            this.cmsdgvDrivers.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tcparent
            // 
            this.Tcparent.Controls.Add(this.tpLocallicense);
            this.Tcparent.Controls.Add(this.tpInternationallicense);
            this.Tcparent.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.Tcparent.Location = new System.Drawing.Point(3, 3);
            this.Tcparent.Name = "Tcparent";
            this.Tcparent.SelectedIndex = 0;
            this.Tcparent.Size = new System.Drawing.Size(1125, 400);
            this.Tcparent.TabIndex = 43;
            // 
            // tpLocallicense
            // 
            this.tpLocallicense.Controls.Add(this.dgvLocalLicenseApp);
            this.tpLocallicense.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold);
            this.tpLocallicense.Location = new System.Drawing.Point(4, 35);
            this.tpLocallicense.Name = "tpLocallicense";
            this.tpLocallicense.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocallicense.Size = new System.Drawing.Size(1117, 361);
            this.tpLocallicense.TabIndex = 0;
            this.tpLocallicense.Text = "Local Licenses History";
            this.tpLocallicense.UseVisualStyleBackColor = true;
            // 
            // dgvLocalLicenseApp
            // 
            this.dgvLocalLicenseApp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLocalLicenseApp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLocalLicenseApp.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalLicenseApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicenseApp.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLocalLicenseApp.Location = new System.Drawing.Point(6, 6);
            this.dgvLocalLicenseApp.Name = "dgvLocalLicenseApp";
            this.dgvLocalLicenseApp.ReadOnly = true;
            this.dgvLocalLicenseApp.RowHeadersWidth = 68;
            this.dgvLocalLicenseApp.RowTemplate.Height = 28;
            this.dgvLocalLicenseApp.Size = new System.Drawing.Size(1105, 335);
            this.dgvLocalLicenseApp.TabIndex = 57;
            this.dgvLocalLicenseApp.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLocalLicenseApp_CellMouseDown);
            // 
            // tpInternationallicense
            // 
            this.tpInternationallicense.Controls.Add(this.dgvInternational);
            this.tpInternationallicense.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold);
            this.tpInternationallicense.Location = new System.Drawing.Point(4, 35);
            this.tpInternationallicense.Name = "tpInternationallicense";
            this.tpInternationallicense.Padding = new System.Windows.Forms.Padding(3);
            this.tpInternationallicense.Size = new System.Drawing.Size(1117, 361);
            this.tpInternationallicense.TabIndex = 1;
            this.tpInternationallicense.Text = "International Licenses History";
            this.tpInternationallicense.UseVisualStyleBackColor = true;
            // 
            // dgvInternational
            // 
            this.dgvInternational.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInternational.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInternational.BackgroundColor = System.Drawing.Color.White;
            this.dgvInternational.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternational.ContextMenuStrip = this.cmsdgvDrivers;
            this.dgvInternational.Location = new System.Drawing.Point(6, 6);
            this.dgvInternational.Name = "dgvInternational";
            this.dgvInternational.ReadOnly = true;
            this.dgvInternational.RowHeadersWidth = 68;
            this.dgvInternational.RowTemplate.Height = 28;
            this.dgvInternational.Size = new System.Drawing.Size(1105, 337);
            this.dgvInternational.TabIndex = 58;
            this.dgvInternational.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInternational_CellMouseDown);
            // 
            // cmsdgvDrivers
            // 
            this.cmsdgvDrivers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmsdgvDrivers.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsdgvDrivers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cmsdgvDrivers.Name = "contextMenuStrip1";
            this.cmsdgvDrivers.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmsdgvDrivers.ShowCheckMargin = true;
            this.cmsdgvDrivers.Size = new System.Drawing.Size(230, 38);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonLicenseHistoryToolStripMenuItem.Image")));
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show License";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.Size = new System.Drawing.Size(230, 38);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(229, 34);
            this.toolStripMenuItem1.Text = "Show License";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ctrnLocalLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tcparent);
            this.Name = "ctrnLocalLicenses";
            this.Size = new System.Drawing.Size(1132, 408);
            this.Load += new System.EventHandler(this.ctrnLocalLicenses_Load);
            this.Tcparent.ResumeLayout(false);
            this.tpLocallicense.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenseApp)).EndInit();
            this.tpInternationallicense.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternational)).EndInit();
            this.cmsdgvDrivers.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tcparent;
        private System.Windows.Forms.TabPage tpLocallicense;
        private System.Windows.Forms.DataGridView dgvLocalLicenseApp;
        private System.Windows.Forms.TabPage tpInternationallicense;
        private System.Windows.Forms.DataGridView dgvInternational;
        private System.Windows.Forms.ContextMenuStrip cmsdgvDrivers;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}
