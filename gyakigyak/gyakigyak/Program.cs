int[] tombKeszit(int darab, int legkisebb, int legnagyobb)
{
    int[] tomb = new int[darab];
    Random rand = new Random();

    for (int i = 0; i < tomb.Length; i++)
    {
        tomb[i] = rand.Next(legkisebb,legnagyobb+1);
    }

    return tomb;
}

int[] szamok = tombKeszit(1000, 100, 999);
int paros =0;
for (int i = 0; i < szamok.Length; i++)
{
    if (szamok[i] % 2 == 0)
    {
        paros++;
    }
}
Console.WriteLine("A számok között {0} páros, és {1} páratlan volt.", paros, szamok.Length-paros);

//következő elem vizsgálata
bool vanEgyenloSzomszed = false;

for (int i = 0; i < szamok.Length - 1; i++)
{
    if (szamok[i] == szamok[i + 1])
    {
        vanEgyenloSzomszed = true;
        break;
    }
}

if (vanEgyenloSzomszed)
{
    Console.WriteLine("Van egyenlő szomszédos elem!");
}
else
{
    Console.WriteLine("Nincs egyenlő szomszédos elem!");
}

//előző elem
bool vanEgyenlo=false;

for (int i = 1; i <szamok.Length; i++)
{
    if (szamok[i] == szamok[i - 1])
    {
        vanEgyenlo = true;
        //break;
        Console.WriteLine("Egyenlő. {0}. és {1}., {2} = {3}", i - 1, i, szamok[i - 1], szamok[i]);
    }
}

if (vanEgyenlo)
{
    Console.WriteLine("Van egyenlő szomszédos elem!");
}
else
{
    Console.WriteLine("Nincs egyenlő szomszédos elem!");
}




/*
int[] szakasz = new int[0];

for (int i = 0; i < szamok.Length-1; i++)
{
    if (szamok[i] < szamok[i+1])
    {
        szakasz[i] = i;
    }
}
*/

void szakasz(int[] szamTomb)
{
    int kezd = 0;
    int veg = 0;
    int maxKezd = 0;
    int maxVeg = 0;

    for (int i = 1; i < szamTomb.Length; i++)
    {
        if (szamTomb[i-1] < szamTomb[i])
        {

        }
        else
        {
            veg = i-1;
            if (veg-kezd+1 > maxVeg-maxKezd+1)
            {
                maxVeg = veg;
                maxKezd = kezd;
            }
            kezd = i;
        }
    }
    Console.Write("A legnagyobb növekvő számsorozat {0} elemű: ", maxVeg-maxKezd);
    for (int i = maxKezd; i < maxVeg + 1; i++)
    {
        Console.Write("{0}, ", szamTomb[i]);
    }
    Console.WriteLine();
}

szakasz(szamok);


void kisebb(int[] szamTomb)
{
    int kezd = 0;
    int veg = 0;
    int maxKezd = 0;
    int maxVeg = 0;

    for (int i = 1; i < szamTomb.Length; i++)
    {
        if (szamTomb[i - 1] > szamTomb[i])
        {

        }
        else
        {
            veg = i - 1;
            if (veg - kezd + 1 < maxVeg - maxKezd + 1)
            {
                maxVeg = veg;
                maxKezd = kezd;
            }
            kezd = i;
        }
    }
    Console.Write("A legnagyobb csökkenő számsorozat {0} elemű: ", maxVeg + maxKezd);
    for (int i = maxKezd; i < maxVeg + 1; i++)
    {
        Console.Write("{0}, ", szamTomb[i]);
    }
    Console.WriteLine();
}

kisebb(szamok);