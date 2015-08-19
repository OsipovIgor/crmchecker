using System.Collections.Generic;
using CrmParser.Parsers;

namespace CrmParser.Data
{
    public class HeaderInfo
    {
        private HtmlParser _parser;
        private List<string> _headerData; 

        public HeaderInfo()
        {
            _parser = new HtmlParser();
            _headerData = _parser.GetHeaderData();
        }

        /// <summary>
        /// Свободных операторов на линии
        /// </summary>
        public string FreeAbonents
        {
            get
            {
                int lastIndex = _headerData[2].LastIndexOf('>');
                return string.Format("FREE: {0}", _headerData[2].Substring(lastIndex + 1)); 
            }
        }

        /// <summary>
        /// Клиенты в очереди
        /// </summary>
        public string WaitClients
        {
            get
            {
                return _headerData[3];
            }
        }

        /// <summary>
        /// Потери
        /// </summary>
        public string LostClients
        {
            get
            {
                return _headerData[6];
            }
        }
    }
}
