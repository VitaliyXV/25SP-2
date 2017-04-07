using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitFlow.Model
{
    class Game: Item
    {
        public int Id { get; set; }        
        public string CompanyName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public GamesGenre Genre { get; set; }
        public SupportedPlatforms Platform { get; set; }
        public LicenseType License { get; set; }
        public DistributeType Distribution { get; set; }
        public float Size { get; set; }
        
        public Game( string name,
                     int id,
                     string companyName,
                     DateTime release,
                     GamesGenre genre,
                     SupportedPlatforms platform,
                     LicenseType license,
                     DistributeType distibution,
                     float price,
                     float size)
        {
            Category = CategoryType.GAMES;
            Name = name;
            Id = id;
            CompanyName = companyName;
            ReleaseDate = release;
            Genre = genre;
            Platform = platform;
            License = license;
            Distribution = distibution;
            Price = price;
            Size = size;
        }
        

        public override Item Clone()
        {
            return new Game(Name, Id, CompanyName, ReleaseDate, Genre, Platform, License, Distribution, Price, Size);
        }


        public void setName(string name)
        {
            Name = name;
        }

        public void setId(int id)
        {
            Id = id;
        }

        public void setRelease(DateTime release)
        {
            ReleaseDate = release;
        }

        public void setLicense(LicenseType lic)
        {
            License = lic;
        }

        public void setDistribution(DistributeType distr)
        {
            Distribution = distr;
        }

        public void setPrice(float price)
        {
            Price = price;
        }

        public override string ToString()
        {
            return string.Format(
                "Game Title: {0};\nGenre: {1};\nPrice: {2}USD;\nRelease Date: {3};\nCompany: {4};\nPlatform: {5};\nDistribution: {6};\nLicence: {7};\nSize: {8}Gb",
                Name, Genre, Price, ReleaseDate.ToShortDateString(), CompanyName, Platform, Distribution, License, Size);
        }

    }
}
