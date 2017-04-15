using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns
{
    public class CNNNewsService
    {
        public List<CNNNews> allnews=new List<CNNNews>();

        public List<CNNNews> GetNews()
        {
            return allnews;
        }

        public CNNNewsService()
        {
            allnews.Add(new CNNNews { Date = new DateTime(2017, 4, 14), Header = "Rumor: Matrix 4", Body = "Will Smith will play in new film Matrix 4" });
            allnews.Add(new CNNNews { Date = new DateTime(2017, 4, 14), Header = "Happy Easter", Body = "Happy Easter Everybody!!!"});
        }


        public void AddNews(CNNNews newone)
        {
            allnews.Add(newone);
        }

        public string GetNewsText()
        {
            string stemp = "";
            foreach(CNNNews news in allnews)
            {
                stemp += news.ToString();
            }
            return stemp;
        }

    }
}
