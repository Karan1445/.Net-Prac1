using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical1
{
    internal class CalculateArea
    {
        double length;
        double widhth;

        public CalculateArea(double length, double widhth) { 
            this.length = length;
            this.widhth = widhth;
            Console.WriteLine("Area Of Rectangele is: "+(length*widhth));
        }
    }
}
