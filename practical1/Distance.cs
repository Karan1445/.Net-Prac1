using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical1
{
    internal class Distance
    {
        double Distance_1;
        double Distance_2;
        double Final_Distance;

        public Distance(double Distance_1,double Distance_2) {
            this.Distance_1 = Distance_1;
            this.Distance_2 = Distance_2;
        }
        public void Calculate_Distance() {
            Console.WriteLine("========Display-DISTANCE=============");
            Console.WriteLine();

           Final_Distance= Distance_1+Distance_2;
            Console.WriteLine("HEllo User, Your Final Distance is: {0}/KM",Final_Distance);

        }
    }
}
