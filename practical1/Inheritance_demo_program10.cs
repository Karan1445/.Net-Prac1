using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical1
{
    interface Gross
    {
        public void Gross_sal();
    }
    internal class Employee(string name,double ta,double da,double hra,double bs) : Salary(ta,da,hra,bs),Gross
    {
        string Name = name;
        

        public void Gross_sal() {
            Console.WriteLine("HEllo,{1} ..Your Gross Salary is :{0}/$",(ta+da+hra+bs),name);
        }

        public void basic_sal()
        {
            Console.WriteLine("Hello,{1}..Your Basic Salary is:{0}/$",bs,name);
        }
    
    }
}
