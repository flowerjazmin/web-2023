using System;
using System.Collections;
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
            /*
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


            Console.WriteLine();
            Console.WriteLine();

            int szamm = 0;
            while (szamm<=100 || szamm>999)
            {
                Console.Write("Kérek egy újabb számot: ");
                szamm = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 2; i <= szamm/2 ; i++)
            {
                if (szamm % i == 0)
                {
                    Console.WriteLine(i);
                }
            }


            Console.WriteLine();
            Console.WriteLine();

            int szamm1 = 0;
            int szamm2 = 0;
            int nagyobb = 0;
            while (szamm1 <= 100 || szamm1 > 999)
            {
                Console.Write("Kérem az első számot: ");
                szamm1 = Convert.ToInt32(Console.ReadLine());
            }

            while (szamm2 <= 100 || szamm2 > 999)
            {
                Console.Write("Kérem a második számot: ");
                szamm2 = Convert.ToInt32(Console.ReadLine());
            }

            if (szamm1 > szamm2)
            {
                nagyobb = szamm1;
            }
            else 
            {
                nagyobb = szamm2;
            }

            for (int i = 2; i <= nagyobb / 2; i++)
            {
                if (szamm1 % i == 0 && szamm2%i==0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            */
            /*
            int oszto = 0;
            Console.Write("Kérek egy számot: ");
            oszto = Convert.ToInt32(Console.ReadLine());
            */
            /*
            for (int i = 10000; i <= 99999; i++)
            {
                if (i % oszto == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = -99999; i <= -10000; i++)
            {
                if (i % oszto == 0)
                {
                    Console.Write(i + " ");
                }
            }
            
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 99999; i >= 10000; i--)
            {
                if (i % oszto == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = -10000; i >= -99999; i--)
            {
                if (i % oszto == 0)
                {
                    Console.Write(i + " ");
                }
            }
            */
            /*
            int tizedik = 0;
            for (int i = 10000; i <= 99999; i++)
            {
                if (i % oszto == 0)
                {
                    Console.Write(i + "\t");
                    tizedik++;
                    if (tizedik % 10==0)
                    {
                        Console.WriteLine();
                    }
                }
            }
            

            for (int i = -99999; i <= -10000; i++)
            {
                if (i % oszto == 0)
                {
                    Console.Write(i + "\t");
                    tizedik++;
                    if (tizedik % 10 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 99999; i >= 10000; i--)
            {
                if (i % oszto == 0)
                {
                    Console.Write(i + "\t");
                    tizedik++;
                    if (tizedik % 10 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }

            for (int i = -10000; i >= -99999; i--)
            {
                if (i % oszto == 0)
                {
                    Console.Write(i + "\t");
                    tizedik++;
                    if (tizedik % 10 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
            */


            /*
            double hm = 1;
            while (hm % 1.2 >= 0.001)
            {
                Console.Write("Kérek egy számot: ");
                hm = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(hm % 1.2);
            }

            hm = Convert.ToInt32(hm);

            for (int i = 2; i <= hm / 2; i++)
            {
                if (hm % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */




            
            double x = 0;
            for (double i = -10; i <= 10; i += 0.1)
            {
                //Console.WriteLine(i);
                x = ((int)(i * 10)) / 10.0;
                Console.WriteLine(((((x * x) + (3 * x)) / 9) - 5 * (x * x) - (6 * (9 - x)) / 2 + 12 + 6 * (1 / (((x * x) + 1) * ((x * x) + 1)) - 12 * x)));
            }


            //1. feladat
            /*
            int szam1 = 0;
            int szam2 = 0;
            int szam3 = 0;
            int nagyobb = 0;
            Console.Write("Kérek egy számot: ");
            szam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérek egy másik számot: ");
            szam2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérek egy harmadik számot: ");
            szam3 = Convert.ToInt32(Console.ReadLine());

            if (szam1 > szam2)
            {
                if (szam1 > szam3) 
                {
                    Console.WriteLine(szam1);
                }
                else 
                {
                    Console.WriteLine(szam3);
                }
            }
            else
            {
                if (szam2 > szam3) 
                {
                    Console.WriteLine(szam2);
                }
                else
                { 
                    Console.WriteLine(szam3);
                }
            }
            */



            /*
            if (szam1 > szam2)
            {
                nagyobb = szam1;
            }
            else if (szam1 > szam3)
            {
                nagyobb = szam1;
            }
            else if (szam2 > szam1)
            {
                nagyobb = szam2;
            }
            else if (szam2 > szam3)
            {
                nagyobb = (szam2);
            }
            else if (szam3 > szam1)
            {
                nagyobb = (szam3);
            }
            else
            {
                nagyobb = szam3;
            }
            Console.WriteLine(nagyobb);
            */





            //2. feladat
            /*
            int szam = 0;
            string word = "";
            Console.Write("Kérek egy számot: ");
            szam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérek egy betűt: ");
            word = Console.ReadLine();

            for (int i = 0; i <= szam; i++)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            */



            //3. feladat
            /*
            int szam1 = 0;
            int szam2 = 0;
            Console.Write("Kérek egy számot: ");
            szam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérek egy másik számot: ");
            szam2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A számok négyzeteinek összege: "+((szam1*szam1)+(szam2*szam2)));
            */



            //4. feladat
            /*
            int szam1 = 0;
            int szam2 = 0;
            int kisebb = 0;
            int nagyobb = 0;
            Console.Write("Kérek egy számot: ");
            szam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérek egy másik számot: ");
            szam2 = Convert.ToInt32(Console.ReadLine());

            if (szam1 > szam2)
            {
                kisebb = szam2;
            }
            else
            {
                kisebb = szam1;
            }

            if (szam1 > szam2)
            {
                nagyobb = szam1;
            }
            else
            {
                nagyobb = szam2;
            }

            int ossz = 0;
            for (int i=kisebb;i<=nagyobb;i++)
            {
                ossz += i * i;
            }
            Console.WriteLine(ossz);
            */


        }
    }
}
