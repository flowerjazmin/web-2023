using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 10000001;
            while (szam<0 || szam>=1000000)
            {
                Console.Write("Kérek egy számot: ");
                szam = Convert.ToInt32(Console.ReadLine());
                if (szam > 100000)
                {
                    Console.WriteLine("A szám 6 jegyű.");
                }
                else if (szam > 10000)
                {
                    Console.WriteLine("A szám 5 jegyű.");
                }
                else if (szam > 1000)
                {
                    Console.WriteLine("A szám 4 jegyű.");
                }
                else if (szam > 100)
                {
                    Console.WriteLine("A szám 3 jegyű.");
                }
                else if (szam > 10)
                {
                    Console.WriteLine("A szám 2 jegyű.");
                }
                else
                {
                    Console.WriteLine("A szam 1 jegyű.");
                }

            }


            Console.WriteLine();
            Console.WriteLine();

            int szam2 = 0;
            Console.Write("Kérek egy számot: ");
            szam2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= szam2; i++)
            {
                Console.WriteLine("Szám 10-szerese 0-tól kezdve: " + (i*10));
            }


            Console.WriteLine();
            Console.WriteLine();

            int szam3 = 0;
            Console.Write("Kérek egy újabb számot: ");
            szam3=Convert.ToInt32(Console.ReadLine());

            for (int i=1; i <= szam3; i++)
            {
                for(int k=1;k<=szam3;k++)
                {
                    Console.Write(i*k+ "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            int szam4 = 0;
            int annyi = 0;
            for (int i=1;  i <= 999; i++)
            {
                if (i + szam4 <= 999)
                {
                    szam4 = i + szam4;
                    annyi++;
                }
            }
            Console.WriteLine("Ennyiszer kell összeadni: " + annyi);

            Console.WriteLine();
            Console.WriteLine();

            //while-os megoldás

            int szam5 = 1;
            int h = 0;
            int szam6 = 0;
            while (szam5 < 999)
            {
                h++;
                //Console.WriteLine(h);
                szam5 = szam5 + h;
                szam6++;
            }
            Console.WriteLine("Ennyiszer kell összeadni: " + (szam6 - 1));

        }
    }
}
