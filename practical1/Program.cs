using practical1;
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;

public class Program {

    public static void Main(string[] karan) {
        string loop_repeat = "yes";
        int Program_Number;
        while (loop_repeat=="yes") {
            Console.WriteLine();
            Console.WriteLine("Want to Repeat: Enter Yes");
            loop_repeat = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Enter Program Number:1 to 10");
            Program_Number = Convert.ToInt32(Console.ReadLine());

            switch (Program_Number) {

                case 1:
                    Candidate candidate = new Candidate();
                    candidate.GetCandidateDetails();
                    Console.WriteLine();
                    candidate.DisplayCandidateDetails();
                    break;
                case 2:
                    Staff[] StaffDemo= new Staff[2];
                    for (int i = 0; i < 2; i++) {
                        StaffDemo[i] = new Staff();
                        StaffDemo[i].GetStaffDetails();
                        Console.WriteLine();
                    }
                    for (int i = 0; i < 2; i++)
                    {
                        if((StaffDemo[i].Designation).ToString().ToLower()=="hod")
                            StaffDemo[i].DisplayStaffDetails();
                    }
                    break;
                case 3:
                    Bank_Account DemobankAccount=new Bank_Account();
                    DemobankAccount.GetAccountDetails();
                    Console.WriteLine();
                    DemobankAccount.DisplayAccountDetails();
                    break;
                case 4:
                    Student DemoStudent = new Student(1234567,"karan",8,9.02,9.4);
                    DemoStudent.DisplayStudentDetails();
                    break;

                case 5:
                    CalculateArea Calculate = new CalculateArea(12, 12);
                    break;
                case 6:
                    Interst DemoIntres = new Interst("Name",12000,1,6.89);
                    DemoIntres.Calculate();
                    break;
                case 7:
                    Salary DemoSalary = new Salary(500,122,589,12000);
                    DemoSalary.Calculate_Salary();
                    break;
                case 8:
                    Distance DemoDistance = new Distance(582.22,89.05);
                    DemoDistance.Calculate_Distance();
                    break;
                case 9:
                    Tables DemoTables = new Tables(51, 589.55, "wood", 15);
                    DemoTables.Calculate_price();
                    break;
                case 10:
                    Employee Demoemp = new Employee("Karan",785,589,78,12000);
                    Demoemp.Gross_sal();
                    Demoemp.basic_sal();
                    break;

            }

        }

        //Program 1--------------------
        //Candidate candidate = new Candidate();
        //candidate.GetCandidateDetails();
        //Console.WriteLine();
        //candidate.DisplayCandidateDetails();

        //Progarm 2--------------------

        //Staff[] StaffDemo= new Staff[2];
        //for (int i = 0; i < 2; i++) {
        //    StaffDemo[i] = new Staff();
        //    StaffDemo[i].GetStaffDetails();
        //    Console.WriteLine();
        //}
        //for (int i = 0; i < 2; i++)
        //{
        //    if((StaffDemo[i].Designation).ToString().ToLower()=="hod")
        //        StaffDemo[i].DisplayStaffDetails();
        //}

        //Progream 3---------------------

        //Bank_Account DemobankAccount=new Bank_Account();
        //DemobankAccount.GetAccountDetails();
        //Console.WriteLine();
        //DemobankAccount.DisplayAccountDetails();

        //program 4-----------
        //Student DemoStudent = new Student(1234567,"karan",8,9.02,9.4);
        //DemoStudent.DisplayStudentDetails();

        //program 5------------
        //CalculateArea Calculate = new CalculateArea(12, 12);

        //rogram 6-------------

        //Interst DemoIntres = new Interst("Name",12000,1,6.89);
        //DemoIntres.Calculate();

        //Program 7-------------
        //Salary DemoSalary = new Salary(500,122,589,12000);
        //DemoSalary.Calculate_Salary();

        //program 8-------------

        //Distance DemoDistance = new Distance(582.22,89.05);
        //DemoDistance.Calculate_Distance();

        //program 9------------
        //Tables DemoTables = new Tables(51, 589.55, "wood", 15);
        //DemoTables.Calculate_price();

        //program 10-----------
        //Employee Demoemp = new Employee("Karan",785,589,78,12000);
        //Demoemp.Gross_sal();
        //Demoemp.basic_sal();

    }
}