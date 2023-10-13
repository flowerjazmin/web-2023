/*void kiir(int[] tomb)
{
    foreach (int i in tomb)
    {
        Console.WriteLine("{0}. szám.", i);
    }

}


// See https://aka.ms/new-console-template for more informatio

int[] szamok = new int[100];

for (int i = 0; i < szamok.Length; i++)
{
    szamok[i] = i+1;
}

Console.WriteLine(szamok);

foreach (int i in szamok)
{
    Console.WriteLine("{0}. szám.", i);
}

for (int i = 0; i < szamok.Length; i++)
{
    szamok[i] = szamok[i] * 2;
}

kiir(szamok);
*/

using System.ComponentModel.DataAnnotations;
/*
Console.Write("Hány sor legyen?: ");
int sor = Convert.ToInt32(Console.ReadLine());

Console.Write("Hány oszlop legyen?: ");
int oszlop = Convert.ToInt32(Console.ReadLine());

string[,] tabla = new string[ sor, oszlop];

for (int i = 0; i < tabla.GetLength(0); i++)
{
    for (int k = 0; k < tabla.GetLength(1); k++)
    {
        tabla[i, k] = "";
        for (int u = 1; u < i + 1; u++)
        {
            tabla[i, k] = tabla[i, k] + "a";
        }
        for (int m = 1; m < k + 1; m++)
        {
            tabla[i, k] = tabla[i, k] + "b";
        }
    }
}


foreach (string szo in tabla)
{
    Console.WriteLine(szo);
}

Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < tabla.GetLength(0); i++)
{
    for (int k = 0; k < tabla.GetLength(1); k++)
    {
        Console.Write("{0,5} ", tabla[i, k]);
    }
    Console.WriteLine();
}
*/

/*
Console.Write("Kérek egy számot: ");
int szam = Convert.ToInt32(Console.ReadLine());

string[] tabla= new string[szam];

for (int i = 0;i < tabla.Length; i++)
{
    Console.Write("Kérek egy szót: ");
    tabla[i] = Console.ReadLine();
}

string max = "";

for (int i = 0; i < tabla.Length; i++)
{
    if (tabla[i].Length > max.Length)
    {
        max = tabla[i];
    }
}

Console.WriteLine("A leghosszabb elem: {0}",max);


//index keresés
int maxIndex = 0;
for (int i = 0; i < tabla.Length; i++)
{
    if (tabla[i] == max)
    {
        maxIndex = i;
    }
}

//máshogy
max = "";
maxIndex=0;
for (int i = 0; i < tabla.Length; i++)
{
    if (tabla[i].Length > max.Length)
    {
        max = tabla[i];
        maxIndex = i;
    }
}


//megen mashogy

maxIndex = 0;
for (int i = 0; i < tabla.Length; i++)
{
    if (tabla[i].Length > tabla[maxIndex].Length)
    {
        maxIndex = i;
    }
}
*/
/*
string[] szavak = new string[] { "alma", "körte", "narancs", "mandula", "ananász", "banán" };

string[] rovid = new string[szavak.Length];
string[] hosszu = new string[szavak.Length];

int rovidIndex = 0;
int hosszuIndex = 0;

for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i].Length <= 5)
    {
        rovid[rovidIndex] = szavak[i];
        rovidIndex++;
    }
    else
    {
        hosszu[hosszuIndex++] = szavak[i];
    }
}

for (int i = 0;i < rovid.Length;i++)
{
    Console.WriteLine(rovid[i]);
}

for (int i = 0; i < hosszu.Length; i++)
{
    Console.WriteLine(hosszu[i]);
}
*/

int[] szamok = new int[1000];

for (int i = 0; i < szamok.Length; i++)
{
    Random rand = new Random();
    rand.Next(99,1000);
}