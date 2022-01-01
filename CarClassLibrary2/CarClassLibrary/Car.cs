using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public string Color { get; set; }
        public int Year { get; set; }

       

        public Car ()
        {
            Make = "nothing";
            Model= "nothing";
            Price = 0.00M;
            Color = "nothing";
            Year = 0000;
            
        }
        public Car(string a, string b, decimal c,string d,int e)
        {
            Make = a;
            Model = b;
            Price = c;
            Color = d;
            Year = e;
            
        }
       override public string ToString()
        {
            return  Make + " " + Model + " " + Price + "$ " + Color + " " + Year;
        }

    }
}
