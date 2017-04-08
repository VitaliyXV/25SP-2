using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGitFlow.Model;

namespace TestGitFlow.Factory
{
    public class DocumentCreator :IItemCreator
    {
        private Document defaultDoc;
        public DocumentCreator()
        {
            defaultDoc = new Document();
        }
        public Item CreateItem()
        {
            return defaultDoc.Clone();
        }
    }
}
