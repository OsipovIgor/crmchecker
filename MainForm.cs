using System;
using System.Drawing;
using System.Windows.Forms;
using CrmParser.Data;
using CrmParser.Parsers;

namespace CrmParser
{
    public partial class MainForm : Form
    {
        const int WM_NCHITTEST = 0x84;
        const int HTCAPTION = 2;
        const int HTCLIENT = 1;
        public MainForm()
        {
            InitializeComponent();
            
        }

        readonly SettingsForm _form = new SettingsForm();
        public OperatorInfo OperatorInfo;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)
                m.Result = (IntPtr)HTCAPTION;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TopMost = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Enabled = true;

        }

        void timer1_Tick(object sender, EventArgs e)
        {
            HeaderInfo headerInfo = new HeaderInfo();
            labelWait1C.Text = headerInfo.WaitClients;
            labelWait1C.ForeColor = !headerInfo.WaitClients.Contains("WAIT 0") ? Color.Red : Color.Black;
            labelLost1C.Text = headerInfo.LostClients;

            labelFree1C.Text = headerInfo.FreeAbonents;

            if (OperatorInfo != null)
            {
                lblCountAnswered.Text = OperatorInfo.CountAnswered;
                lblPauseStatus.Text = OperatorInfo.PauseStatus;
                lblPauseTime.Text = OperatorInfo.PauseTime;
                lblPhoneNumber.Text = OperatorInfo.PhoneNumber;
                lblWorkTime.Text = OperatorInfo.WorkTime;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            int width = Size.Width;
            const int BTN_SIZE = 20;
            btnClose.Location = new Point(width - BTN_SIZE * 2, 0);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            _form.Owner = this;
            _form.ShowDialog(this);
        }

    }
}
