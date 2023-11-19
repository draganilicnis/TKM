// https://arena.petlja.org/competition/r1-11-utvrdjivanje-tkm-k001#tab_128957 
// https://petlja.org/biblioteka/r/problemi/takmicenja-srednje-skole/01_trotoar 
using System;
class Tkm_2016_17_K01_Z01_A_Trotoar_Bod_100
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);
        int c = int.Parse(s[2]);
        int r = int.MaxValue;
        if (r > a + b + c) { r = a + b + c; }
        if (r > a + b * c) { r = a + b * c; }
        if (r > a * b + c) { r = a * b + c; }
        if (r > a * b * c) { r = a * b * c; }
        Console.WriteLine(r);
    }
}
