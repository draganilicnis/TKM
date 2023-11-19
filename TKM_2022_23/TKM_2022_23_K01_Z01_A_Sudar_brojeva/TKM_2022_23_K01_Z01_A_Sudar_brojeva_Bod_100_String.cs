// C# - Решење за 100 поена – String
// Tkm 2022_23 01 KV 01 Zad 01 A Sudar brojeva
// https://takprog.petlja.org/srednjaskola/post/2022-11-21-kv1-preliminarni-rezultati
// https://arena.petlja.org/sr-Latn-RS/competition/2022-2023-kv1-testiranje#tab_134872

using System;

class Tkm_2022_23_K01_Z01_A_Sudar_brojeva_Bod_100
{
    static void Main()
    {
        String x = Console.ReadLine();      // 1 <= x <= 10^9 // x = "1000000000";
        String y = Console.ReadLine();      // 1 <= x <= 10^9 // y = "1000000000";

        if (x.Length < y.Length)
        {
            String p = x;
            x = y;
            y = p;
        }

        int nx = x.Length;
        int ny = y.Length;

        String r = "";  // r = "11000000000000000000";

        for (int i = ny - 1; i >= 0; i--)
        {
            // Console.WriteLine(x[i + nx - ny] + " " + y[i]);

            if (x[i + nx - ny] < y[i])
            {
                r = y[i] + r;
            }
            else
            {
                r = x[i + nx - ny] + r;
            }

            if (x[i + nx - ny] == y[i])
            {
                r = y[i] + r;
            }
        }

        for (int i = nx - ny - 1; i >= 0; i--)
        {
            // Console.WriteLine(x[i]);
            r = x[i] + r;
        }

        Console.WriteLine(r); 
    }
}

/*
Напомена:

Када имамо велике целе бројеве (веће од 1018), односно целе бројеве са по неколико десетина цифара, онда је једно од решења да користимо низове цифара или стрингове, као у следећој верзији кода:...

*/
