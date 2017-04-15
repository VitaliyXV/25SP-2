
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructuralPatterns;

namespace TestGitFlow.Adapter
{
    class CNNNewsAdapter: NewsService
    {
        CNNNewsService newsservice=new CNNNewsService();
        public override  List<News> GetNews()
        {
            List<News> _news=new List<News>();
            foreach(CNNNews item in newsservice.GetNews())
            {
                News _n = new News();
                _n.Date = item.Date;
                _n.Theme = item.Header;
                _n.Text = item.Body;                
                //foreach (string it in item.GetAllComments())
               // {
               //     _n.Comments.Add(it);
               // }
                //_n.Comments.AddRange(item.Comments);
                _news.Add(_n);
                //_news.Add(new News { Theme = item.Header, Text = item.Body, Date = item.date });             
            }
            return _news;
        }

        public override List<News> AddNews(DateTime date, string theme, string text)
        {
            newsservice.AddNews(new CNNNews { Date = date, Header = theme , Body = text});            
            return GetNews();
        }

        public override News AddComment(News news, string comment)
        {
            CNNNews fnews= newsservice.allnews.FirstOrDefault(n => n.Header == news.Theme);
         //   fnews.Comments.Add(comment);
            News _n = new News();
            _n.Date = fnews.Date;
            _n.Theme = fnews.Header;
            _n.Text = fnews.Body;
        //   _n.Comments.AddRange(fnews.Comments);
            return _n;
        }
    }
}
