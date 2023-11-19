// https://petlja.org/biblioteka/r/problemi/takmicenja-srednje-skole/01_prva_cifra 
// https://arena.petlja.org/competition/r1-11-utvrdjivanje-tkm-k001#tab_128981 
// https://arena.petlja.org/competition/tkm001#tab_128981 
using System;

class Tkm_2017_18_K01_Z01_A_Prva_cifra_Bod_100
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int x = int.Parse(s[0]);
        int y = int.Parse(s[1]);
        int x1 = x;
        int y1 = y;
        while (x >= 10) { x = x / 10; }
        while (y >= 10) { y = y / 10; }
        if (x > y) { Console.WriteLine(x1); }
        if (x < y) { Console.WriteLine(y1); }
        if (x == y)
        {
            if (x1 > y1) { Console.WriteLine(x1); }
            else         { Console.WriteLine(y1); }
        }
    }
}
