using System;

namespace Gittest1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            BankingClass obj = new BankingClass();
            //Console.WriteLine("Enter your account balance");
            
           // BankingClass b = new BankingClass(200);
            Console.WriteLine("Your account balance is");
            int accountbalace = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the amount u want to withdraw");
            int amount= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(b.accno);
            //Console.WriteLine(b.accountbalance);


            obj.withdrawal(accountbalace,amount);
        }
        

        
    }
}
