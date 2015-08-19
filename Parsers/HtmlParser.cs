using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            IEnumerable<HtmlNode> innerText = document.GetElementbyId("header").Descendants("tr").Select(x => x.Elements("td")).FirstOrDefault();
            List<string> result = (from t in innerText select t.InnerHtml).ToList();

            return result;
        }

        public IEnumerable<IEnumerable<HtmlNode>> GetOperatorsData()
        {
            string request = Download("http://panel.support.voip.astralnalog.ru/table?queue=Q1co-crm");
            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(request);
            var innerText = document.GetElementbyId("data").Descendants("tr").Select(x => x.Elements("td"));
            return innerText;
        }

        /// <summary>
        /// Метод возвращает страницу в виде HTML
        /// </summary>
        /// <param name="uri">URL страницы</param>
        /// <returns></returns>
        private string Download(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uri);
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
