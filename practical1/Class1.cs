using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical1
{
    internal class Candidate
    {
        public int id;
        public string name;
        public int age;
        public double weight;
        public double height;


        public void GetCandidateDetails() {
            Console.Write("Enter Id Of Candidates: ");
            id=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name Of Candidates: ");
            name = Console.ReadLine();

            Console.Write("Enter age Of Candidates: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter height Of Candidates: ");
            height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Weight Of Candidates: ");
            weight = Convert.ToDouble(Console.ReadLine());


        }

        public void DisplayCandidateDetails() {
            Console.WriteLine("Id Of Candidates:"+id);
            Console.WriteLine("Name Of Candidates:" + name);
            Console.WriteLine("age Of Candidates:" + age);
            Console.WriteLine("height Of Candidates:" + height);
            Console.WriteLine("weight Of Candidates:" + weight);
        }
    }
}
