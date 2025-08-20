using DVLD_Businees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmEditTests : Form
    {
        int Test_ID;
        public bool Saved { set; get; }

        clsTestsTypes_DB _oTest = new clsTestsTypes_DB();
        public frmEditTests(int ID)
        {
            InitializeComponent();
            Test_ID = ID;
        }
        private void _FillDataInControl(clsTestsTypes_DB oTest)
        {
            if (_oTest != null)
            {
                laID.Text = oTest.Test_ID.ToString();
                tbTitle.Text = oTest.Title;
                tbDescription.Text = oTest.Description;    
                tbFees.Text = oTest.Fees.ToString();
            }
        }
        private void _FillDataIn_oTests()
        {
            _oTest.Test_ID = Convert.ToInt16(laID.Text);
            _oTest.Description = tbDescription.Text;
            _oTest.Title = tbTitle.Text;
            _oTest.Fees = Convert.ToDecimal(tbFees.Text);
        }
        private void _LoadData()
        {
            _oTest = clsTestsTypes_DB.FindTest(Test_ID);
            _FillDataInControl(_oTest);
        }
        private bool _IsTextNotNull()
        {
            return this.Controls.OfType<TextBox>().All(tb => !string.IsNullOrWhiteSpace(tb.Text));
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_IsTextNotNull())
            {
                _FillDataIn_oTests();
                if (_oTest.Save())
                {
                    MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Saved = true;
                }
                else
                    MessageBox.Show("Saved Failed", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Enter The Data Correctly", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void frmEditTests_Load(object sender, EventArgs e)
        {
            _LoadData();
        }


    }
}
