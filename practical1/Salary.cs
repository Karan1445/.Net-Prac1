using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical1
{
    internal class Salary
    {
        public double Travel_Allowance;
        public double Dearness_Allowance;
        public double House_Rent_Allowance;
        public double Basic_Salary;

        public Salary(double Travel_Allowance, double Dearness_Allowance, double House_Rent_Allowance, double Basic_Salary) { 
            this.Travel_Allowance=Travel_Allowance;
            this.Dearness_Allowance=Dearness_Allowance;
            this.House_Rent_Allowance=House_Rent_Allowance;
            this.Basic_Salary=Basic_Salary;
        
        }

        public void Calculate_Salary() {
            Console.WriteLine("===========Displlay-salary==============");
            double Final_Salary=Travel_Allowance+Dearness_Allowance+House_Rent_Allowance+Basic_Salary;
            Console.WriteLine("HELLO user, Your Final Salary is :$"+Final_Salary);
        }
    }
}
