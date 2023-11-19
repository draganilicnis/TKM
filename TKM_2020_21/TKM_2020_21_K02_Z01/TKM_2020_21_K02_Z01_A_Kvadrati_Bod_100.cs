// https://arena.petlja.org/sr-Latn-RS/competition/2020-2021-kv2-testiranje#tab_133586
using System;

public class Tkm_2020_21_K02_Z01_A_Kvadrati_Bod_100
{
    static void Main()
    {
        string[] s1 = Console.ReadLine().Split();
        int x1 = int.Parse(s1[0]);
        int y1 = int.Parse(s1[1]);

        string[] s2 = Console.ReadLine().Split();
        int x2 = int.Parse(s2[0]);
        int y2 = int.Parse(s2[1]);

        int r = 0;

        if (x1 == x2 || y1 == y2) { r = 2; }
        else if (Math.Abs(x2 - x1) == Math.Abs(y2 - y1)) { r = 1; }

        Console.WriteLine(r);
    }
}
