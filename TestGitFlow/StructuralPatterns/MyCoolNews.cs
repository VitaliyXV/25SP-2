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
            public string Comment { get; set; }
            public DateTime Date { get; set; }
            public Comment()
            {
                Author = "";
                Comment = "";
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

        public List<News> getListNews()
        {
            return listNews;
        }

        public News getNews(int id)
        {
            return listNews.First(n => n.Id == id);
        }
        public List<Comment> getCommentbyNews(int id)
        {
            return getNews(id).ListComment;
        }
    }
}
