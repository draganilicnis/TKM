// https://arena.petlja.org/competition/20202021kvalifikacije3-vezba#tab_133606

using System;

class Tkm_2020_21_K03_Z01_A_Sampion_Bod_100
{
    static void Main()
    {
        var ulaz = Console.ReadLine().Split();
        Int64 x = Int64.Parse(ulaz[0]);
        Int64 y = Int64.Parse(ulaz[1]);
        Int64 t = Int64.Parse(ulaz[2]);
        Int64 k = t / x;
        // Console.WriteLine(k);
        Int64 s = t - k * x;
        // Console.WriteLine(s);
        Int64 r = k * (x + y) + s;
        // Console.WriteLine(r);
        if (t % x == 0) // s == 0
        {
            r = k * (x + y) - y; // r = r - y;
        }
        Console.WriteLine(r);
    }
}


// https://arena.petlja.org/competition/20202021kvalifikacije3-vezba#tab_133606 
// Takmicenje iz programiranja 2021
// 3. krug kvalifikacija - 24.01.2021. godine
// Zadatak 01: Sampion
// Link zadatka: https://arena.petlja.org/sr-Latn-RS/competition/2020-2021-kv3-testiranje#tab_133606 
// Link resenja: https://algora.petlja.org/t/resenja-zadataka-2020-2021-kvalifikacije-treci-krug/5648 
// Link takmicenja: https://takprog.petlja.org/srednjaskola 
// Resenje za 100 poena
// Tekst zadatka ukratko: Dzoan igra Tetris ukupno T minuta, ali tako sto nakon svakih X minuta igre pravi puazu Y minuta.
// Ulaz: U jedinoj liniji ulaza nalaze se tri cela broja X, Y i T.
// Izlaz: U jedinoj izlaznoj liniji ispisati koliko minuta je potrebno od pocetka treninga kako bi Dzonas odigrao T minuta 
//
// Ogranicenja:
// 1 <= X, T <= 10^15,
// 1 <= Y <= 1000
// Primer 1
// Ulaz
// 5 4 8
// Izlaz
// 12
// Primer2
// Ulaz
// 3456 1 1800
// Izlaz
// 36897880205
