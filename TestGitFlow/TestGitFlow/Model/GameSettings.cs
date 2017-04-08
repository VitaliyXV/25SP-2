using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitFlow.Model
{
    class GameSettings:IItemSettings
    {

        public string Name { get; set; }
        public float Price { get; set; }
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public GamesGenre Genre { get; set; }
        public SupportedPlatforms Platform { get; set; }
        public LicenseType License { get; set; }
        public DistributeType Distribution { get; set; }
        public float Size { get; set; }
        

    }
}
