using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WordFilterService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string WordFilter(string str)
        {
            List<string> stop_word = new List<string>()
            {
                    "the",
                    "of",
                    "and",
                    "a",
                    "to",
                    "in",
                    "is",
                    "you",
                    "that",
                    "it",
                    "he",
                    "was",
                    "for",
                    "on",
                    "are",
                    "as",
                    "with",
                    "his",
                    "they",
                    "I",
                    "at",
                    "be",
                    "this",
                    "have",
                    "from",
                    "or",
                    "one",
                    "had",
                    "by",
                    "word",
                    "but",
                    "not",
                    "what",
                    "all",
                    "where",
                    "we",
                    "when",
                    "your",
                    "can",
                    "said",
                    "there",
                    "use",
                    "an",
                    "each",
                    "which",
                    "she",
                    "do",
                    "how",
                    "their",
                    "if",
                    "will",
                    "up",
                    "other",
                    "about",
                    "out",
                    "many",
                    "then",
                    "them",
                    "these",
                    "so",
                    "some",
                    "her",
                    "would",
                    "make",
                    "like",
                    "him",
                    "into",
                    "time",
                    "has",
                    "look",
                    "two",
                    "more",
                    "write",
                    "go",
                    "see",
                    "number",
                    "no",
                    "way",
                    "could",
                    "people",
                    "my",
                    "than",
                    "first",
                    "water",
                    "been",
                    "call",
                    "who",
                    "oil",
                    "its",
                    "now",
                    "find",
                    "long",
                    "down",
                    "day",
                    "did",
                    "get",
                    "come",
                    "made",
                    "may",
                    "part"

            };
            String lower_case = str.ToLower();
            var newString = string.Join(" ", lower_case.Split(' ').Except(stop_word));
            return newString.ToString();

        }
    }
}
