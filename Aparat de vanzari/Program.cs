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
            Console.WriteLine("Aparatul primeste monedele p (cu valoarea 5 centi), d (cu valoarea 10 centi) si q cu valoarea 25 de centi),si va elibera produsul cand in interior se afla cel putin 20 de centi");
            int balance = 0;
            bool itemgiven = false;
            while (!itemgiven)
            {
                Console.WriteLine($"Momentan in automat contine monede cu valoarea {balance} centi,pentru a vi se da un produs mai trebuie sa introduceti {20 - balance} centi");
                char k=char.Parse(Console.ReadLine());
                int d = Convert.ToInt32(k);
                switch (d)
                {case 112:balance += 5;break;
                    case 100:balance += 10;break;
                    case 113:balance += 25;break;
                }
                if (balance >= 20) { balance -= 20;
                                   itemgiven = true;
                    Console.Write("Vi sa eliberat produsul;");
                }
            }
            while(balance>=10) { balance-= 10;
                Console.Write(",vi sa eliberat un d");
            }
            while (balance >= 5) { balance-=5;
                Console.Write(",vi sa eliberat un p");
            }
        }
    }
}
