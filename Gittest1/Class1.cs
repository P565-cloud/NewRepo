using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gittest1
{
   public class Class1
    {
        private static void display()
        {
            Console.WriteLine("Chhanges made in git");
        }

        private static void display1()
        {
            Console.WriteLine("Chhanges made in local");
        }

        public int add(int a,int b)
        {
            return a + b;
        }
        public string Greet(string name)
        {
            return "Hello" +" "+ name;
        }

        public float calculateamount(int qty,int price)
        {
            return qty * price;
        }

        public bool CheckAdd(int a,int b)
        {
            float f = calculateamount(a, b);
            if (f > 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

