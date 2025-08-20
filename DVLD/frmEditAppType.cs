using DVLD_Businees;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmEditAppType : Form
    {
        int ApplicationType_ID;
        public bool Saved { set; get; } 
        clsApplicationsTypes_DB _oAppType = new clsApplicationsTypes_DB();
        public frmEditAppType(int ID)
        {
            InitializeComponent();
            ApplicationType_ID = ID;    
        }
        private void _FillDataInControl(clsApplicationsTypes_DB oAppType) 
        {
            if (oAppType != null)
            {
                laID.Text = oAppType.App_ID.ToString();
                tbTitle.Text = oAppType.Title;
                tbFees.Text = oAppType.Fees.ToString();
            }
        }
        private void _FillDataIn_oAppType()
        {
            _oAppType.App_ID = Convert.ToInt16(laID.Text);
            _oAppType.Title = tbTitle.Text;
            _oAppType.Fees = Convert.ToDecimal(tbFees.Text);
        }
        private void _LoadData() 
        {
            _oAppType = clsApplicationsTypes_DB.FindAppLication(ApplicationType_ID);
            _FillDataInControl(_oAppType);            
        }
        private bool _IsTextNotNull()
        {
            return this.Controls.OfType<TextBox>().All(tb => !string.IsNullOrWhiteSpace(tb.Text));
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_IsTextNotNull()) 
            {
                _FillDataIn_oAppType();
                if (_oAppType.Save())
                {
                    MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Saved = true;
                }
                else
                    MessageBox.Show("Saved Failed", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Enter the Data Correctly", "Save failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void frmEditAppType_Load(object sender, EventArgs e)
        {
            _LoadData();
        }


    }
}
