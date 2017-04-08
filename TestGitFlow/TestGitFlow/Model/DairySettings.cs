using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitFlow.Model
{
    class DairySettings : IItemSettings
    {
        #region VARIABLES
        public string Name { get; set; }
        public float Price { get; set; }
        public CategoryType Category { get; set; }
        public Manufacturer manufacturer;
        public DateTime dateOfMade;
        public DateTime endOfTerm;
        #endregion
    }
}
