using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical1
{
    class Furniture
    {
       public string material;
       public double price;
       

        public void get_DataMembers(string material, double price)
        {
            this.material = material;
            this.price = price;
        }
        

    }

    class Tables : Furniture
    {
        double height;
        double surface_area;

        public Tables(double height,double surface_area,string material, double price)
        {
           this.height = height;
            this.surface_area = surface_area;
            get_DataMembers(material, price);
        }

        public void Calculate_price()
        {
            Console.WriteLine("--FInal-Price--");

            Console.WriteLine("Total price is:{0}/$ with material:{1}", (surface_area * height * price),material);
        }

    }
}
