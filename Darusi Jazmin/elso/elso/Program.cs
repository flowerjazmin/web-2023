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

            int t = 0;
            Console.WriteLine(++t);

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

            double number = 1;
            while (number<3)
            {
                Console.WriteLine(number);
                number += .1;
            }
            do
            {
                number -= .2;
                Console.WriteLine(number);
            }
            while (number > 2);

            char az = 'a';
            while(az <= 'z')
            {
                Console.Write(az);
                az = (char)(az + 1);
            }
            Console.WriteLine();

            int n = 32;
            while (n <= 250)
            {
                Console.Write((char)n+"  ");
                if (n % 8 == 7)
                {
                    Console.WriteLine();
                }
                n++;

                
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int szamol = 0;
            for (int i = 100; i <=999 ; i++)
            {
                szamol += i;
            }
            Console.WriteLine(szamol);


            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(9 - i);
            }


            

            for (int i = 10; i <= 99; i++)
            {
                if(i%5==0)
                {
                    Console.WriteLine(i + " : ");
                }
            }
            Console.WriteLine();

            for (int i = 10; i < 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i + " : ");
                }
            }

            for (int i = 10; i < 100; i+=5)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            




        }
    }
}
