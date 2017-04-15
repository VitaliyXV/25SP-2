using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns
{
    public class MyCoolNews
    {
        public class Comment
        {
            public string Author { get; set; }
            public string comment { get; set; }
            public DateTime Date { get; set; }
            public Comment()
            {
                Author = "";
                comment = "";
                Date = DateTime.Now;
            }

        }
        public class News
        {
            public int Id { get; set; }
            public string Title {get; set;}
            public string Text {get; set;}
            public string Author { get; set; }
            public DateTime Date { get; set; }
            public List<Comment> ListComment { get; set; }
            public News()
            {
                Id =-1;
                Title ="";
                Text  ="";
                Author = "";
                Date =DateTime.Now;
                ListComment= new List<Comment>();
            }

        }

        private List<News> listNews = new List<News>();
        public MyCoolNews()
        {
            News news1 = new News();
            news1.Id = 1;
            news1.Title = "НЛО прилетело и обубликовало эту новость";
            news1.Text = "Yjjknkljrnvs srgn ng slrgnrlgr";
            news1.Author = "НЛО";
            News news2 = new News();
            news2.Id = 2;
            news2.Title = "НЛО прилетело и обубликовало и эту новость тоже";
            news2.Text = "!!!!!Yjjknkljrnvs srgn ng slrgnrlgr";
            news2.Author = "НЛО";
            listNews.Add(news1);

            listNews.Add(news2);
        }
        public List<News> getListNews()
        {
            return listNews;
        }
        public void addNews(DateTime date, string theme, string text)
        {

            var news = new News();
            news.Id = 1;
            news.Text = text;
            news.Title = theme;
            news.Date = date;
            listNews.Add(news);

        }

        public News getNews(int id)
        {
            return listNews.First(n => n.Id == id);
        }
        public News getNews(string title, DateTime date)
        {
            return listNews.First(n => n.Date == date && n.Title==title);
        }
        public List<Comment> getCommentbyNews(int id)
        {
            return getNews(id).ListComment;
        }
        public void addCommentbyNews(int idnews,string text, DateTime date, string author = "")
        {
            Comment c = new Comment();
            c.comment = text;
            getNews(idnews).ListComment.Add(c);
        }
    }
}
