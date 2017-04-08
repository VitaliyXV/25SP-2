using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitFlow.Model
{
    public class ToySettings:IItemSettings
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public CategoryType Category { get; set; }
        public int MinAge { get; set; }
        public string Description { get; set; }
        public DateTime ProduceDate { get; set; }
        public Manufacturer ManufacturerData { get; set; }
    }
}
