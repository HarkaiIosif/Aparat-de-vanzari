using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aparat_de_vanzari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The vending machine will despense the product when it contains 20 cents,the machine accepts pennys , cents and quarters ");
            Console.WriteLine("- To imput a penny please press p,a penny is worth 5 cents");
            Console.WriteLine("- To imput a dime please press d,a dime is worth 10 cents"); 
            Console.WriteLine("- To imput a quarter please press q , a quarter is worth 25 cents");
            int balance = 0;
            bool itemgiven = false;
            while (!itemgiven)
            {   
                Console.WriteLine($"Currently there are {balance} cents in the machine,to recieve a product you still need to imput {20 - balance} cents");
                char k=char.Parse(Console.ReadLine());
                int d = Convert.ToInt32(k);
                switch (d)
                {case 112:balance += 5;break;
                    case 100:balance += 10;break;
                    case 113:balance += 25;break;
                    default: Console.WriteLine("The machine does not accept this");break;
                }
                if (balance >= 20) { balance -= 20;
                                   itemgiven = true;
                    Console.Write("You have recieved a product");
                }
            }
            while(balance>=10) { balance-= 10;
                Console.Write(",the machine has dispensed a dime in change");
            }
            while (balance >= 5) { balance-=5;
                Console.Write(",the machine has dispensed a penny in change");
            }
            Console.Write(".");
            Console.WriteLine();
        }
    }
}
