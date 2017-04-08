using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitFlow.Model
{
    class Document : Item
    {
        public String Author { get; set; }
        public int Pages { get; set; }
        public String Summary { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastEditDate { get; set; }
        public String Text { get; set; }

        public void setName(string name)
        {
            Name = name;
        }
        public void setPrice(float price)
        {
            Price = price;
        }

        public Document()
        {
            Category = CategoryType.DOCUMENT;
        }

        public Document(float price, string name, string author, string summary, int page=0, DateTime? create=null, DateTime? edit=null, string text = ""  )
        {
            Category = CategoryType.DOCUMENT;
            Price = price;
            Name = name;
            Author = author;
            Summary = summary;
            Pages = page;
            CreationDate = create;
            LastEditDate = edit;
            Text = text;
        }


        public override Item Clone()
        {
            return new Document(Price, Name, Author, Summary, Pages, CreationDate, LastEditDate, Text);
        }
        public override string ToString()
        {
            //// c# old ver.
            // return String.Format("Name: {0} Author: {1} Price: {2}$\nPages: {3}p. Create: {4} Summary: {5}", Name, Author, Price, Pages, CreationDate?.ToShortDateString(), Summary);
           
            // c# ver 6 
            return "Name: {Name} Author: {Author} Price: {Price}$\nPages: {Pages}p. Create: {CreationDate?.ToShortDateString()} Summary: {Summary}";
        }
    }
}
