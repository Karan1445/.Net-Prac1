using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace practical1
{
    //    Write a pogram to Create a class Bank_Account with Account_No, Email,
    //User_Name, Account_Type and Account_Balance as data members.Also
    //create a Member function GetAccountDetails() & DisplayAccountDetails().
    internal class Bank_Account
    {
        public int Account_No;
        public string Email;
        public string User_Name;
        public string Account_Type;
        public double Account_Balance;

        public void GetAccountDetails() {
            Console.Write("Enter Account_No: ");
            Account_No = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Email: ");
            Email = Console.ReadLine();

            Console.Write("Enter User Name: ");
            User_Name = Console.ReadLine();

            Console.Write("Enter Account type: ");
            Account_Type = Console.ReadLine();

            Console.Write("Enter account balance : ");
            Account_Balance = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayAccountDetails() {
            Console.WriteLine("-------------Disply-Details--------------");
            Console.WriteLine("Account numner:" + Account_No);
            Console.WriteLine("Email Adress:" + Email);
            Console.WriteLine("User Name:" + User_Name);
            Console.WriteLine("Account type:" + Account_Type);
            Console.WriteLine("Account Balance:" + Account_Balance);
        }

    }
}
