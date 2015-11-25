using System;
using System.Windows.Forms;
using CrmParser.Data;
using CrmParser.Parsers;

namespace CrmParser
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        public OperatorInfo GetInfo()
        {
            MainForm form = Owner as MainForm;
            OperatorInfoParser parser = new OperatorInfoParser();
            if (tbPhone.Text != string.Empty)
                form.OperatorPhone = tbPhone.Text;
            string phone = tbPhone.Text == string.Empty ? form.OperatorPhone : tbPhone.Text;
            
            var operData = parser.GetInfo(phone);
            return operData;
        } 

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            MainForm form = Owner as MainForm;
            if (form != null)
            {
                form.labelFree1C.Visible = chbxFree.Checked;
                form.labelLost1C.Visible = chbxLost.Checked;
                form.labelWait1C.Visible = chbxWait.Checked;
                
                form.OperatorInfo = GetInfo();
                
            }
            
            Close();
        }
    }
}
