using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bekeres
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Console.Write("Kérek egy szöveget: ");
            string szoveg= Console.ReadLine();

            Console.WriteLine("A bekért szöveg: " + szoveg);



            //üres sor végjelig
            szoveg = " ";
            while(szoveg!="")
            {
                Console.Write("Kérek egy szót: ");
                szoveg = Console.ReadLine();
            }


            Console.Write("Kérek egy nem egész számot: ");
            double szam = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A szám négyzete "+szam*szam+1);
            */

            //bekérni szám(egész) utána bekér annyi szo amennyi a szam volt


            /*
            Console.Write("Kérek egy egész számot: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<num;i++)
            {
                Console.Write("Kérem az " + (i+1) + "." + " szót: ");
                Console.ReadLine();
            }
            */

            //uj feladat

            Console.Write("Kérek egy számot: ");
            int sz = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kérek egy második számot: ");
            int h = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sz; i++)
            {
                int w = 0;
                while (w != h)
                {
                    Console.Write("Kérek egy szót: ");
                    Console.ReadLine();
                }
            }


        }

    }
}
