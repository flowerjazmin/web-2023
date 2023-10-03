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
        Console.WriteLine("Nem jó formátum!");
        jo = false;
        continue;
    }

    Console.WriteLine(szam);
}
