using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace practical1
{
    internal class Student
    {
        //        Data Members: Enrollment_No, Student_Name, Semester, CPI and SPI
        //Get Students Details using constructor and DisplayStudentDetails() using 
        //member function

        int Enrollment_No;
        string Student_Name;
        int Semester;
        double cpi;
        double spi;

        public Student( int Enrollment_No, string Student_Name, int Semester, double cpi, double spi) {
            this.Enrollment_No = Enrollment_No;
            this.Student_Name = Student_Name;
            this.Semester = Semester;
            this.cpi = cpi;
            this.spi = spi;
        }
        public void  DisplayStudentDetails() {
            Console.WriteLine("-------------Disply-Details--------------");
            Console.WriteLine("Enrollment numner:" + Enrollment_No);
            Console.WriteLine("student name:" + Student_Name);
            Console.WriteLine("Semester:" + Semester);
            Console.WriteLine("cpi:" + cpi);
            Console.WriteLine("spi:" + spi);
        }
    }
}
