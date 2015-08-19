using System;
using System.Collections.Generic;
using System.Linq;
using CrmParser.Data;
using HtmlAgilityPack;

namespace CrmParser.Parsers
{
    public class OperatorInfoParser
    {
        public OperatorInfo GetInfo(string phoneNumber)
        {
            HtmlParser parser = new HtmlParser();
            IEnumerable<IEnumerable<HtmlNode>> allOperators =  parser.GetOperatorsData();
            allOperators = allOperators.Skip(1);
            foreach (var oper in allOperators)
            {
                var o = oper.ToList();
                if (o.Count != 0 && o[0].InnerHtml == phoneNumber)
                {
                    OperatorInfo operatorInfo = new OperatorInfo();
                    operatorInfo.PhoneNumber = o[0].InnerHtml;
                    operatorInfo.CountAnswered = o[7].InnerHtml;
                    operatorInfo.PauseStatus = o[11].InnerText;
                    int index = o[10].InnerText.IndexOf("\t", StringComparison.Ordinal);

                    operatorInfo.PauseTime = o[10].InnerText.Substring(index+1);
                    operatorInfo.WorkTime = o[9].InnerHtml;
                    return operatorInfo;
                }
            }
            return null;
        }
    }
}
