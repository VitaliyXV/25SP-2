using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.AlexNews
{
    public class AlexNews
    {
        #region
        private string _newsTitle;
        private string _newsText;
        private DateTime _dateOfNews;
        private List<Comment> _comments;
        private string _author;
        #endregion

        public AlexNews()
        {
            _newsTitle = "Default";
            _newsText = "Default text";
            _comments = new List<Comment>();
            _dateOfNews = DateTime.Today;
            _author = "Uknown";
        }


        private void AddComments(Comment comment)
        {
            _comments.Add(comment);
        }

        public List<Comment> GetCommenst()
        {
            return _comments;
        }

        public void SetTextNews(string newsText)
        {
            _newsText = newsText;
        }

        public string GetTextNews()
        {
            return _newsText;
        }

        public void SetDataNews()
        {
            _dateOfNews = DateTime.Today;
        }

        public DateTime GetDataNews()
        {
            return _dateOfNews;
        }

        public void SetAuthor(string author)
        {
            _author = author;
        }

        public string GetAuthor()
        {
            return _author;
        }

    }
}
