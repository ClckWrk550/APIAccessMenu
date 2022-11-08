using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace Top10WordsService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string[] Top10Words(string url)
        {
            string[] arr = new string[10];
            HtmlWeb web_obj = new HtmlWeb();
            var htmlDoc = web_obj.Load(url);
            HtmlNode n = htmlDoc.DocumentNode.SelectSingleNode("//body");
            var content = n.InnerText;
            var contentWords = Regex.Split(content, @"[\W\d]+").Where(c => !String.IsNullOrWhiteSpace(c));
            var mostFrequentlyUsed =
                 (from word in contentWords
                  group word by word into GroupWords
                  select new { Word = GroupWords.Key, Freq = GroupWords.Count() })
                .OrderByDescending(word => word.Freq).Take(10);



            int k = 0;
            foreach (var s in mostFrequentlyUsed)
            {
                String element = s.ToString();
                arr[k] = element.Split(',')[0].Replace("{ Word =", String.Empty);
                k++;
                if (k == 10)
                    break;
            }

            return arr;
        }
    }
}
