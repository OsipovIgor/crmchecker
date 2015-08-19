using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

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
            HtmlParser htmlParser = new HtmlParser();
            var res = htmlParser.GetHeaderData();
            labelWait1C.Text = res[3];
            labelWait1C.ForeColor = !res[3].Contains("WAIT 0") ? Color.Red : Color.Black;
            labelLost1C.Text = res[6];
            int lastIndex = res[2].LastIndexOf('>');

            labelFree1C.Text = string.Format("FREE: {0}",res[2].Substring(lastIndex+1)); 
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
