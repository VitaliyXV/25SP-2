using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.AlexNews
{
    public class Comment
    {
        private string _commentText;
        private string _author;
        private DateTime _date;

        public Comment()
        {
            _commentText = "Default";
        }

        public void SetComments(string comment)
        {
            _commentText = comment;
        }

        public string GetCommentText()
        {
            return _commentText;
        }

        public void SetAuthor(string author)
        {
            _author = author;
        }


        public string GetAuthor()
        {
            return _author;
        }


        public void SetData()
        {
            _date = DateTime.Today;
        }

        public DateTime GetCommentDate()
        {
            return _date;
        }
    }
}
