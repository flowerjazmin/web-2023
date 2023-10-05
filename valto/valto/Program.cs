
string[] hosszusag = { "mm", "cm", "dm", "m", "km" };


bool jo = false;

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

    double szam = 0;
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

    }
    else
    {
        Console.WriteLine("Nem jó mértékegység!");
        jo = false;
        continue;
    }
}

Console.WriteLine("Mire szeretnéd átváltani?: ");
for (int i = 0; i < hosszusag.Length; i++)
{
    Console.WriteLine(hosszusag[i]);
}

Console.Write("Választásod: ");
string valasz = Console.ReadLine();
