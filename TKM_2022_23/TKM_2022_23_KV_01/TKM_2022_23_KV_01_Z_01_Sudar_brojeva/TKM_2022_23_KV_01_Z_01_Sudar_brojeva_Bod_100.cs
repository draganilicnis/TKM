// C# - Решење за 100 поена – UInt64
// Tkm 2022_23 01 KV 01 Zad 01 A Sudar brojeva
// https://takprog.petlja.org/srednjaskola/post/2022-11-21-kv1-preliminarni-rezultati
// https://arena.petlja.org/sr-Latn-RS/competition/2022-2023-kv1-testiranje#tab_134872

using System;

class Tkm_2022_23_KV_01_Z_01_Sudar_brojeva_Bod_100
{
    static void Main()
    {
        uint x = uint.Parse(Console.ReadLine());      // 1 <= x <= 10^9 = 1000000000
        uint y = uint.Parse(Console.ReadLine());      // 1 <= y <= 10^9 = 1000000000

        // x = 1000000000;      // Iz uslova (ogranicenja) zadatka da je najveca moguca ulazna vrednost 10^9 = 1000000000
        // y = 1000000000;      // Iz uslova (ogranicenja) zadatka da je najveca moguca ulazna vrednost 10^9 = 1000000000  

        if (x < y)              // Obezbedjumo da veca ulazna vrednost bude u X, a manja u Y
        {
            uint p = x;
            x = y;
            y = p;
        }

        UInt64 r = 0;              // Rezultat -> inicijalna vrednost (ne moze biti manja od 1, odnosno od 0
        // r = 11000000000000000000;
        UInt64 d = 1;              // Koeficijent za mnozenje (jedinice, desetice, stotine...)
        
        while (x > 0)           // Klasican algoritam za rastavljanje celog broja na cifre
        {
            uint cx = x % 10;    
            uint cy = y % 10;
            uint cr = cx;
            if (cy > cx) { cr = cy; }

            r = r + cr * d;

            if (cx == cy && y > 0)  // Ukoliko su obe cifre jednake onda obe dopisujemo.
            {
                d = d * 10;
                r = r + cr * d;
            }
            d = d * 10;
            x = x / 10;
            y = y / 10;
        }

        Console.WriteLine(r);
    }
}
