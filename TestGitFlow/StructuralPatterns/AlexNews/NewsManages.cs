using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.AlexNews
{
    public class NewsManager
    {
        private List<AlexNews> _news;

        public NewsManager()
        {
         _news = new List<AlexNews>();
        }

        public List<AlexNews> GetAlexNews()
        {
            return _news;
        }


        public void AddNews(AlexNews news)
        {
            _news.Add(news);
        }
    }
}
