using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int szam = -6;
            Console.WriteLine(szam);

            double tort = 12.5;
            Console.WriteLine(tort);

            char betu = '?';
            Console.WriteLine(betu);
            Console.WriteLine(betu+2);

            char a = 'a';
            Console.WriteLine((char)(a + 2));
            Console.WriteLine(10 / 3.0);

            int i = 0;
            Console.WriteLine(++i);

            int b;
            b = 5;
            if (b > 2)
            {
                Console.WriteLine("Nagyobb");
            }
            else if(b < 2)
            {
                Console.WriteLine("Kisebb");
            }
            else if(b%2==0)
            {
                Console.WriteLine("Páros");
            }
            else
            {
                Console.WriteLine("Egyenlő");
            }


            switch(b)
            {
                case 1:
                    Console.WriteLine("Egy");
                    break;
                case 2:
                    Console.WriteLine("Ketto");
                    break;
                case 3:
                    Console.WriteLine("Három");
                    break;
                case 4:
                    Console.WriteLine("Négy");
                    break;
                default:
                    Console.WriteLine("Valami más");
                    break;
            }
        }
    }
}
