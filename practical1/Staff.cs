using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace practical1
{
    internal class Staff
    {
        //Name,  Department, Designation, Experience & Salary.
        public String Name;
        public String Department;
        public String Designation;
        public int Experience;
        public double Salary;

        public void GetStaffDetails(){
            Console.Write("Enter Name Of Staff: ");
            Name = Console.ReadLine();

            Console.Write("Enter Department Of Staff: ");
            Department = Console.ReadLine();

            Console.Write("Enter Deaignation Of Staff: ");
           Designation =  Console.ReadLine();

            Console.Write("Enter Experience Of Staff: ");
            Experience = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Salary Of Staff: ");
            Salary = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayStaffDetails()
        {
            Console.WriteLine("Name Of Staff:" + Name);
           
            Console.WriteLine("salary Of Staff:" + Salary);
            Console.WriteLine();
        }
    }
}
