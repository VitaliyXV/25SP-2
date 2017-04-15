using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns
{
    public class CNNNews
    {
        //public int id { get; set; }
        public DateTime Date { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }

        public List<string> Comments;


        //public CNNNews(string header, string body)
        //{            
        //    Header = header;
        //    Body = body;
        //}
        
        public void AddComment(string newone)
        {
            Comments.Add(newone);
        }
        //getcomments
        public List<string> GetAllComments()
        {
            return Comments;
        }

        public override string ToString()
        {
            string stemp=string.Format("Title: {0};\nText: {1}\n", Header, Body);
            foreach(string comm in Comments)
            {
                stemp += comm + "\n";
            }
            return stemp;
        }
    }
}
