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