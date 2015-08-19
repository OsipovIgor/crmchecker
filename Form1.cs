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
    public partial class Form1 : Form
    {
        const int WM_NCHITTEST = 0x84;
        const int HTCAPTION = 2;
        const int HTCLIENT = 1;
        public Form1()
        {
            InitializeComponent();
            
        }

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
            var res = Get1CTime();
            labelWait1C.Text = res[3];
            labelWait1C.ForeColor = !res[3].Contains("WAIT 0") ? Color.Red : Color.Black;
            labelLost1C.Text = res[6];
            int lastIndex = res[2].LastIndexOf('>');

            labelFree1C.Text = string.Format("FREE: {0}",res[2].Substring(lastIndex+1)); 
        }

        public static List<string> Get1CTime()
        {
            string request = Download("http://panel.support.voip.astralnalog.ru/table?queue=Q1co-crm");
            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(request);
            IEnumerable<IEnumerable<HtmlNode>> innerText = document.GetElementbyId("header").Descendants("tr").Select(x => x.Elements("td"));
            List<string> result = (from t in innerText from htmlNode in t select htmlNode.InnerHtml).ToList();

            return result;
        }

        public static string Download(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uri);
            request.Method = "GET";
            String test = String.Empty;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                test = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
            }
            return test;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
