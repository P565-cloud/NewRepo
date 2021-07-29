using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gittest1
{
    public class BankingClass
    {
        
        public static int counter = 1;
        public int accountbalance { get; set; }
        public int withdrwal;
        public int deposit;
        public int accno=counter++;
        public BankingClass()
        {
            this.accno = counter++;
            this.accountbalance = 0;
            this.withdrwal = 0;
            this.deposit = 0;

        }
        public BankingClass(int acbal)
        {
            this.accno = counter++;
            this.accountbalance = acbal;
            this.withdrwal = 0;
            this.deposit = 0;

        }
        
        public int withdrawal(int acbal,int wa)
        {
            Console.WriteLine("Enter you account no.");
            //int acno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the amount you want to withdraw");
            //int amount = Convert.ToInt32(Console.ReadLine());

            acbal = acbal - wa;
            Console.WriteLine("Your Balance left is:{0}", acbal);
            return acbal;
            
            

        }
    }
}
