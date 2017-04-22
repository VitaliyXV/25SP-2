using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitFlow.Adapter
{
    class AdapterNasled : NewsService
    {
        //создаем свой адаптер
        MyServyseOfNews _news = new MyServyseOfNews();

        public override News AddComment(News news, string comment)
        {
            return base.AddComment(news, comment);
        }

        public override List<News> AddNews(DateTime date, string theme, string text)
        {
            return base.AddNews(date, theme, text);
        }

        public override List<News> GetNews()
        {
            return base.GetNews();
        }
    }
}
