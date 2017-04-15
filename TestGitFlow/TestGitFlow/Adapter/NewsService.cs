using System;
using System.Collections.Generic;
using System.Linq;

namespace TestGitFlow.Adapter
{
    public class NewsService
    {
        private List<News> _news = new List<News>();

        public NewsService()
        {
            _news = new List<News>
            {
                new News {Date = new DateTime(2017, 4, 14), Theme = "Вышел тизер-трейлер 8 эпизода «Звездных войн»",
                    Text = "Появилось первое официальное видео к фильме «Звездные войны: Последние джедаи», 8 эпизоду легендарной киносаги."},
                new News{Date = new DateTime(2017, 4, 13), Theme = "Дольф Лундгрен в «Аквамене», Джош Бролин в «Дэдпуле 2»",
                    Text = "Новости из мира супергероев. Двухметровый швед Дольф Лундгрен получил роль в экранизации комикса «Аквамен»."}
            };
        }

        public List<News> GetNews()
        {
            return _news;
        }

        public List<News> AddNews(DateTime date, string theme, string text)
        {
            _news.Add(new News { Date = date, Theme = theme, Text = text });
            return _news;
        }

        public News AddComment(News news, string comment)
        {
            news.Comments.Add(comment);
            return news;
        }
    }
}
