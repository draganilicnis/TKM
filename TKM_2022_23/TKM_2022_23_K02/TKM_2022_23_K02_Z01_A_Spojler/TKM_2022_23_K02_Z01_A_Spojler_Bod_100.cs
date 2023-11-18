// // https://arena.petlja.org/sr-Latn-RS/competition/2022-23-kvalifikacije-2-testiranje#tab_134951

using System;

public class Tkm_2022_23_K02_Z01_A_Spojler_Bod_100
{
    static void Main()
    {
        string[] s1 = Console.ReadLine().Split();
        int a = int.Parse(s1[0]);
        int b = int.Parse(s1[1]);
        string[] s2 = Console.ReadLine().Split();
        int x = int.Parse(s2[0]);
        int y = int.Parse(s2[1]);
        int p = a - x;
        int d = b - y;
        string r = "?";
        if (p <= 0 && d <= 0) r = "nijedan";
        else if (p <= 0 && d > 0) r = "drugi";
        else if (p > 0 && d <= 0) r = "prvi";
        Console.WriteLine(r);
    }
}
