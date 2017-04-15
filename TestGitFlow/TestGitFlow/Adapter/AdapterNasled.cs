using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitFlow.Adapter
{
    class AdapterNasled : NewsService
    {
        public override News AddComment(News news, string comment)
        {
            return base.AddComment(news, comment);
        }
    }
}
