// https://arena.petlja.org/competition/20182019kvalifikaciie2-vezba#tab_129377

using System;
class Tkm_2018_19_K01_Z01_A_Nadovezivanje_Bod_020
{
    static void Razmeni(ref string a, ref string b)
    {
        string p = a;
        a = b;
        b = p;
    }
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        if (s[0].CompareTo(s[1]) < 0) Razmeni(ref s[0], ref s[1]);
        if (s[0].CompareTo(s[2]) < 0) Razmeni(ref s[0], ref s[2]);
        if (s[1].CompareTo(s[2]) < 0) Razmeni(ref s[1], ref s[2]);
        string r = s[0] + s[1] + s[2];
        Console.WriteLine(r);
    }
}
