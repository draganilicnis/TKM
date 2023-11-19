// https://petlja.org/biblioteka/r/problemi/takmicenja-srednje-skole/01_zecevi
using System;
public class Tkm_2017_18_K03_Z01_A_Zecevi_Bod_100
{
    static void Razmeni(ref int a, ref int b)
    {
        int p = a;
        a = b;
        b = p;
    }
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);
        int c = int.Parse(s[2]);

        if (a > b) Razmeni(ref a, ref b);
        if (a > c) Razmeni(ref a, ref c);
        if (b > c) Razmeni(ref b, ref c);

        int d = -1;
        if (b - a == c - b) d = c + (c - b);
        if (d == -1)
        {
            if (b - a == 2 * (c - b)) d = a + (c - b);
        }
        if (d == -1)
        {
            if (2 * (b - a) == c - b) d = b + (b - a);
        }
        Console.WriteLine(d);
    }
}
