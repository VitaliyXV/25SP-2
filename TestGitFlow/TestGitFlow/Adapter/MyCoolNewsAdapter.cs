using StructuralPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitFlow.Adapter
{
    class MyCoolNewsAdapter:NewsService
    {
        private MyCoolNews mynews = new MyCoolNews();
        public override News AddComment(News news, string comment)
        {
            var n = mynews.getNews(news.Theme, news.Date);
            mynews.addCommentbyNews(n.Id, comment, DateTime.Now);
            News _news = new News();
            _news.Date = n.Date;
            _news.Text = n.Text;
            _news.Theme = n.Title;
            foreach (var item in n.ListComment)
            {
                _news.Comments.Add(item.comment);
            }
            return _news;

        }
        public override List<News> AddNews(DateTime date, string theme, string text)
        {
            mynews.addNews(date, theme, text);
            return GetNews();
        }
        public override List<News> GetNews()
        {
            List<News> listNews = new List<News>();
            News news;
            
            var mcn = mynews.getListNews();
            foreach (var item in mcn)
            {
                news = new News();
                news.Date = item.Date;
                news.Text = item.Text;
                news.Theme = item.Title;
                
                foreach (var c in item.ListComment)
                {
                    news.Comments.Add(c.comment);
                }
                listNews.Add(news);
            }
            return listNews;
        }
    }
}
