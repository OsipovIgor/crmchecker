using System;
using System.Windows.Forms;

namespace CrmParser
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            MainForm form = Owner as MainForm;
            if (form != null)
            {
                form.labelFree1C.Visible = chbxFree.Checked;
                form.labelLost1C.Visible = chbxLost.Checked;
                form.labelWait1C.Visible = chbxWait.Checked;    
            }
            
            Close();
        }
    }
}
