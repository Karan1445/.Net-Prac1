using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace practical1
{
    internal class Account_Details
    {
        public string Name;
        public double balance;
        public int time;
        public double rate;

        public void get_Account_Details(string Name,double balance,int time,double rate) { 
            this.Name = Name;
            this.balance= balance;
            this.time=time;
            this.rate=rate;
        }
    }
    class Interst : Account_Details
    {
        public Interst(string Name, double balance, int time, double rate) {
            get_Account_Details(Name, balance, time, rate);
        }

        public void Calculate()
        { Console.WriteLine("=========Intrest========");
            Console.WriteLine("Hello,......"+Name);
            Console.WriteLine("Interest rate is: " +((balance*time*rate)/100));
        }
    }
        
}
