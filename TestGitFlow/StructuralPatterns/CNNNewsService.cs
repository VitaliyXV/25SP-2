using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns
{
    class CNNNewsService
    {
        List<CNNNews> allnews;

        public List<CNNNews> GetNews()
        {
            return allnews;
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
