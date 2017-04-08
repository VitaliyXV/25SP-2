using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitFlow.Model
{
    class Cars : Item 
    {        
        string Type { get; set; }
        Motors Motor { get; set; }
        string Color { get; set; }

        public Cars() : base()
        {
            Name = "none";
            Type = "not type";
            Motor = new Motors();
            Color = "Black";
        }
        public Cars(string name, float price, CategoryType category, string type, string color, string typeM,int massa, int power, int speed ): base(name, price, category)
        {            
            Name = name;
            Type = type;
            Motor = new Motors(typeM,massa,power,speed);
            Color = color;
            
            
        }
        public override Item Clone()
        {
            return new Cars(Name, Price, Category, Type, Color, Motor.TypeM, Motor.Massa, Motor.Power, Motor.Speed);
        }
    }
    public class Motors
    {
        public string TypeM { get; set; }
        public int Massa { get; set; }
        public int Power { get; set; }
        public int Speed { get; set; }

        public Motors() 
        {
            TypeM = "not set";
            Massa = 0;
            Power = 0;
            Speed = 0; 
        }
        public Motors(string typeM, int massa, int power, int speed)
        {
            TypeM = typeM;
            Massa = massa;
            Power = power;
            Speed = speed;
        }
    }
}
