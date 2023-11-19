// https://arena.petlja.org/competition/takmicenje002#tab_128982 
// https://arena.petlja.org/competition/r1-11-utvrdjivanje-tkm-k001#tab_128986 
// https://arena.petlja.org/competition/r1-08-matrice-02-kvadratne#tab_128982 
// https://petlja.org/biblioteka/r/problemi/takmicenja-srednje-skole/02_transformacija_matrice 
// https://algora.petlja.org/t/resenja-zadataka-kvalifikacije-2018-prvi-krug/1024/3 

using System;

class Tkm_2017_18_K01_Z02_B_Trasformacija_matrice_Bod_100
{
    static void Main()
    {
        // Korak 01: Ulaz - Ucitavanje elemenata matrica A i B	
        int n = int.Parse(Console.ReadLine());
        int[,] A = new int[n, n];               // Matrica A [n x n]
        int[,] B = new int[n, n];               // Matrica B [n x n]

        for (int i = 0; i < n; i++)
        {
            string[] ulaz_red = Console.ReadLine().Split();
            for (int j = 0; j < n; j++) { A[i, j] = int.Parse(ulaz_red[j]); }
        }

        for (int i = 0; i < n; i++)
        {
            string[] ulaz_red = Console.ReadLine().Split();
            for (int j = 0; j < n; j++) { B[i, j] = int.Parse(ulaz_red[j]); }
        }

        // Korak 02: Koliko se elementa matrica A i B razlikuju u svakoj od 4 rotacija
        int R = 0;  int R0 = 0; int R1 = 1; int R2 = 2; int R3 = 3;

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                if (B[i, j] != A[i        , j        ]) { R0 = R0 + 1; }  // Bez rotacije
                if (B[i, j] != A[n - j - 1, i        ]) { R1 = R1 + 1; }  // Nakon jedne rotacije za 90 stepeni
                if (B[i, j] != A[n - i - 1, n - j - 1]) { R2 = R2 + 1; }  // Nakon dve rotacije za 90 stepeni (ukupno 180)
                if (B[i, j] != A[j        , n - i - 1]) { R3 = R3 + 1; }  // Nakon tri rotacije za 90 stepeni
            }

        // Korak 03: Min (R0, R1, R2, R3) -> Najmanji broj potrebnih poteza
        R = R0;
        if (R > R1) { R = R1; }
        if (R > R2) { R = R2; }
        if (R > R3) { R = R3; }

        // Korak 04: Izlaz
        Console.WriteLine(R);
    }
}
