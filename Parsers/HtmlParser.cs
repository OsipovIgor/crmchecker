using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using HtmlAgilityPack;

namespace CrmParser.Parsers
{
    /// <summary>
    /// Класс для парсинга сайта
    /// </summary>
    public class HtmlParser
    {
        /// <summary>
        /// Метод возвращает список значений (кол-во звонков, пропущеных и т.д.)
        /// </summary>
        /// <returns></returns>
        public List<string> GetHeaderData()
        {
            string request = Download("http://panel.support.voip.astralnalog.ru/table?queue=Q1co-crm");
            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(request);
            HtmlNodeCollection headerNodes = document.DocumentNode.SelectNodes(".//*[@id='header']/table/tr/td");

            List<string> result = new List<string>();

            foreach (HtmlNode headerNode in headerNodes)
            {
                result.Add(headerNode.InnerHtml);
            }

            

            return result;
        }

        public IEnumerable<List<HtmlNode>> GetOperatorsData()
        {
            string request = Download("http://panel.support.voip.astralnalog.ru/table?queue=Q1co-crm");
            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(request);
            HtmlNodeCollection nodes = document.DocumentNode.SelectNodes(".//*[@id='data']/table/tr");
            List<List<HtmlNode>> list  = new List<List<HtmlNode>>();
            foreach (HtmlNode node in nodes)
            {
                var tds = node.SelectNodes("td");
                if(tds == null)
                    continue;
                List<HtmlNode> htmlNodes = new List<HtmlNode>();
                foreach (var td in tds)
                {
                    htmlNodes.Add(td);
                }
                list.Add(htmlNodes);
            }



            return list;
        }

        /// <summary>
        /// Метод возвращает страницу в виде HTML
        /// </summary>
        /// <param name="uri">URL страницы</param>
        /// <returns></returns>
        private string Download(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "GET";
            string result;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                result = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
            }
            return result;
        }
    }
}
