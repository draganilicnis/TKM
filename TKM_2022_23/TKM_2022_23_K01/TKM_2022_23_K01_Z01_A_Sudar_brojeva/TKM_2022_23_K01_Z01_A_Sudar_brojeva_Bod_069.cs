// C# - Решење за 069 поена
// Tkm 2022_23 01 KV 01 Zad 01 A Sudar brojeva
// https://takprog.petlja.org/srednjaskola/post/2022-11-21-kv1-preliminarni-rezultati
// https://arena.petlja.org/sr-Latn-RS/competition/2022-2023-kv1-testiranje#tab_134872

using System;

class Tkm_2022_23_K01_Z01_A_Sudar_brojeva_Bod_069
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());      // 1 <= x <= 10^9 = 1000000000
        int y = int.Parse(Console.ReadLine());      // 1 <= y <= 10^9 = 1000000000

        // x = 1000000000;      // Iz uslova (ogranicenja) zadatka da je najveca moguca ulazna vrednost 10^9 = 1000000000
        // y = 1000000000;      // Iz uslova (ogranicenja) zadatka da je najveca moguca ulazna vrednost 10^9 = 1000000000  

        if (x < y)              // Obezbedjumo da veca ulazna vrednost bude u X, a manja u Y
        {
            int p = x;
            x = y;
            y = p;
        }

        int r = 0;              // Rezultat -> inicijalna vrednost (ne moze biti manja od 1, odnosno od 0
        // r = 11000000000000000000;
        int d = 1;              // Koeficijent za mnozenje (jedinice, desetice, stotine...)
        
        while (x > 0)           // Klasican algoritam za rastavljanje celog broja na cifre
        {
            int cx = x % 10;    
            int cy = y % 10;
            int cr = cx;
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

/*
Напомена:

Приликом тестирања (извршавања) овог програмског кода примећујемо да ће за граничне вредности улазних података (како су наведене у услову/захтеву задатка) односно вредности 1000000000 за обе улазне променљиве (иако су обе максималне вредносту у опсегу целобројног типа int) програм исписивати погрешне, неисправне, некоректне излазне вредности (углавном негативне) уместо очекиване 11000000000000000000 (две јединице иза којих следи 18 нула, односно 11*1018 или 1.1*1019) .
Самим тим можемо да закључујемо да ово решење програмског кода неће проћи све тест примере, те неће имати максималан број бодова. На основу услова наведених у задатку можемо очекивати да ће овај програмски код проћи све тест примере за једноцифрене, двоцифрене и троцифрене бројеве, односно да ће имати најамање 40, али не и 100 бодова.
Да би исправно израчунали вредности бројева већих од 109 (а мањих од 1018) потребно је да уместо типа података int користимо тип Int64, као у следећој верзији програмског кода:

*/
