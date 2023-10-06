
string[] hosszusag = { "mm", "cm", "dm", "m", "km" };
int[] hosszusagValto = { 10, 10, 10, 1000, 1 };


string[] terulet = { "mm2", "cm2", "dm2", "m2", "km2" };
int[] teruletValto = { 100, 100, 100, 100000, 1 };

string[] tomeg = { "mg","g", "dkg", "kg", "q", "t" };
int[] tomegValto = { 1000, 10, 100, 100, 10, 1 };

string[] urtartalom = { "ml", "cl", "dl", "l", "hl" };
int[] urValto = { 10, 10, 10, 100, 1 };

string[] terfogat = { "mm3", "cm3", "dm3", "m3" };
int[] terfogatValto = { 1000, 1000, 1000, 1 };


bool jo = false;

double szam = 0;
string forrasMertegy = ("");

string[] egyseg = { };
int[] valto= { };

while (!jo)
{
    jo = true;

    Console.Write("Mit váltsak át? (pl. 12 kg): ");
    string beker = Console.ReadLine();



    string[] darab = beker.Split(" ");
    if (darab.Length != 2)
    {
        jo = false;
        continue;
    }


    try
    {
        szam = Convert.ToDouble(darab[0]);
    }
    catch (Exception)
    {
        Console.WriteLine("Nem jó formátum! Legyen ilyen: 12,2 kg");
        jo = false;
        continue;
    }

    Console.WriteLine(szam);

    if (hosszusag.Contains(darab[1]))
    {
        forrasMertegy = darab[1];
        egyseg = hosszusag;
        valto = hosszusagValto;
    }
    else if (terulet.Contains(darab[1]))
    {
        forrasMertegy = darab[1];
        egyseg = terulet;
        valto = teruletValto;
    }
    else if (tomeg.Contains(darab[1]))
    {
        forrasMertegy = darab[1];
        egyseg = tomeg;
        valto = tomegValto;
    }
    else if (urtartalom.Contains(darab[1]))
    {
        forrasMertegy = darab[1];
        egyseg = urtartalom;
        valto = urValto;
    }
    else if (terfogat.Contains(darab[1]))
    {
        forrasMertegy = darab[1];
        egyseg = terfogat;
        valto = terfogatValto;
    }
    else
    {
        Console.WriteLine("Nem jó mértékegység!");
        jo = false;
        continue;
    }
}

Console.WriteLine("Mire szeretnéd átváltani?: ");
for (int i = 0; i < egyseg.Length; i++)
{
    Console.WriteLine(egyseg[i]);
}

string valasz = " ";

while (!egyseg.Contains(valasz))
{
    Console.Write("Választásod: ");
    valasz = Console.ReadLine();
}

int index1 = Array.IndexOf(egyseg, forrasMertegy);
int index2 = Array.IndexOf(egyseg, valasz);

double eredmeny = 0;

int szorzo = 1;
if (index1 < index2)
{
    for (int i = index1; i < index2; i++)
    {
        szorzo = szorzo * valto[i];
    }
    eredmeny = szam / szorzo;
}
else
{
    for (int i = index2; i < index1; i++)
    {
        szorzo = szorzo * valto[i];
    }
    eredmeny = szam * szorzo;
}

Console.WriteLine("{0} {1} = {2} {3}", szam, forrasMertegy, eredmeny, valasz);
