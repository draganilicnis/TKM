// https://arena.petlja.org/competition/20202021kvalifikacije1-vezba#tab_133441 
using System;

class Tkm_2020_21_K01_Z01_A_Minimalan_trud_Bod_100
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();
        int b = int.Parse(s[0]);
        int c = int.Parse(s[1]);
        int a = 0;
        if (b + c < 256)
        {
            if (b < c) 
            { 
                a = 256 - c;  
            }
            else
            {
                a = 256 - b;
            }
        }
        Console.WriteLine(a);
    }
}
