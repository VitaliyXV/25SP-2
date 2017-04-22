using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitFlow.Adapter
{
    class MyServyseOfNews
    {
        List<MyNewsClass> lists;

        public MyServyseOfNews()
        {
            lists = new List<MyNewsClass>();
            MyNewsClass news1 = new MyNewsClass(1,"First News","This is first news of England bridges","20:01:2017");
            MyNewsClass news2 = new MyNewsClass(2, "Second News", "This is second news of British exit","23:02:2017");
            lists.Add(news1);
            lists.Add(news2);            
        }
        public List<MyNewsClass> GetNewses()
        {
            return lists;
        }
        public int addNews(string name,string text,string date)
        {            
            lists.Add(new MyNewsClass(lists.Count, name, text, date="uncnow"));
            return 0;
        }
        public MyNewsClass AddComment(MyNewsClass news1, string coments)
        {
            news1.comments.Add(coments);
            return news1;
        }
    }
}
