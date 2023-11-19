// https://arena.petlja.org/competition/20182019kvalifikaciie2-vezba#tab_129377

using System;
class Tkm_2018_19_K01_Z01_A_Nadovezivanje_Bod_100
{
    static void Razmeni(ref string a, ref string b)
    {
        string p = a;
        a = b;
        b = p;
    }
    static void Sortiraj(ref string x)
    {
        string[] s = x.Split();
        if ((s[0] + s[1]).CompareTo(s[1] + s[0]) < 0) Razmeni(ref s[0], ref s[1]);
        if ((s[0] + s[2]).CompareTo(s[2] + s[0]) < 0) Razmeni(ref s[0], ref s[2]);
        if ((s[1] + s[2]).CompareTo(s[2] + s[1]) < 0) Razmeni(ref s[1], ref s[2]);
        x = s[0] + s[1] + s[2];
    }
    static void Main()
    {
        string s = Console.ReadLine();
        Sortiraj(ref s);
        Console.WriteLine(s);
    }
}
