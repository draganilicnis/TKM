// https://arena.petlja.org/competition/r1-08-matrice-01#tab_128986 
// https://arena.petlja.org/competition/takmicenje002 
// https://petlja.org/biblioteka/r/problemi/takmicenja-srednje-skole/01_mala_matrica 
// https://algora.petlja.org/t/resenja-zadataka-kvalifikacije-2018-drugi-krug/1025/2 
using System;
class Tkm_2017_18_K02_Z01_A_Mala_matrica_Bod_100
{
    static void Main()
    {
        // Korak 01: Ulaz - Ucitavanje elemenata matrice	
        int[,] A = new int[2, 3];             // matrica 2 x 3

        for (int i = 0; i < 2; i++)
        {
            string[] ulaz_red = Console.ReadLine().Split();
            for (int j = 0; j < 3; j++) { A[i, j] = int.Parse(ulaz_red[j]); }
        }

        // Korak 02: Zamena nula jedinicama u srednjoj koloni, koja ne utice na zbir leve i desne kolone
        if (A[0, 1] == 0) { A[0, 1] = 1; }
        if (A[1, 1] == 0) { A[1, 1] = 1; }

        // Korak 03: Prebrojavanje nula u prvoj i trecoj koloni	
        int N1 = 0; // Broj nula u prvoj koloni
        int N3 = 0; // Broj nula u trecoj koloni

        if (A[0, 0] == 0) { N1++; }
        if (A[1, 0] == 0) { N1++; }
        if (A[0, 2] == 0) { N3++; }
        if (A[1, 2] == 0) { N3++; }

        // Korak 04: Ukupan broj nula u prvoj i trecoj koloni
        int N4 = N1 + N3;

        // Korak 05: Izracunavanje zbira prve i trece kolone	
        int S1 = A[0, 0] + A[1, 0];
        int S3 = A[0, 2] + A[1, 2];

        // Korak 06: Glavni deo programa (algoritma)

        // Korak 06_01: Ako je broj nula u prvoj i trecoj koloni = 4
        if (N4 >= 4)
        {
            N4 = 0;
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                    if (A[i, j] == 0) { A[i, j] = 1; }
        }

        // Korak 06_02: Ako je broj nula u prvoj i trecoj koloni = 3
        if (N4 == 3)
        {
            if (N1 == 1)
            {
                if (A[0, 0] == 0) { A[0, 0] = 1; } else { A[1, 0] = 1; }
                N4 = 2;
                N1 = 0;
                S1 = S1 + 1;
            }
            else
            {
                if (A[0, 2] == 0) { A[0, 2] = 1; } else { A[1, 2] = 1; }
                N4 = 2;
                N3 = 0;
                S3 = S3 + 1;
            }
        }

        // Korak 06_03:    Ako je broj nula u prvoj i trecoj koloni = 2
        // Korak 06_03_01: Ako je broj nula u prvoj i trecoj koloni = 2 i obe nule su u prvoj koloni 
        if (N4 == 2 && N1 == 2)
        {
            N4 = 0;
            N1 = 0;
            S1 = S3;
            A[0, 0] = A[0, 2];
            A[1, 0] = A[1, 2];
        }
        // Korak 06_03_02: Ako je broj nula u prvoj i trecoj koloni = 2 i obe nule su u trecoj koloni 
        if (N4 == 2 && N3 == 2)
        {
            N4 = 0;
            N3 = 0;
            S3 = S1;
            A[0, 2] = A[0, 0];
            A[1, 2] = A[1, 0];
        }

        // Korak 06_03_03: Ako je broj nula u prvoj i trecoj koloni = 2 i po jedna nula je u prvoj i trecoj koloni 
        if (N4 == 2 && N1 == 1)
        {
            if (S1 > S3)
            {
                N4 = 1;
                N1 = 0;
                S1 = S1 + 1;
                if (A[0, 0] == 0) { A[0, 0] = 1; } else { A[1, 0] = 1; }
            }
            else
            {
                N4 = 1;
                N3 = 0;
                S3 = S3 + 1;
                if (A[0, 2] == 0) { A[0, 2] = 1; } else { A[1, 2] = 1; }
            }
        }

        // Korak 06_04: Ako je broj nula u prvoj i trecoj koloni = 1
        int SR = Math.Abs(S1 - S3);         // Razlika zbira prve i trece kolone
        if (N4 == 1 && SR > 0)
        {
            N4 = 0;
            N1 = 0;
            N3 = 0;
            if (A[0, 0] == 0) { A[0, 0] = SR; }
            if (A[1, 0] == 0) { A[1, 0] = SR; }
            if (A[0, 2] == 0) { A[0, 2] = SR; }
            if (A[1, 2] == 0) { A[1, 2] = SR; }
        }

        S1 = A[0, 0] + A[1, 0]; // Novi zbir prve kolone
        S3 = A[0, 2] + A[1, 2]; // Novi zbir trece kolone

        // Korak 07_01: Ako jos uvek postoje nule u 1. i 3. koloni ili su zbirovi 1. i 3 kolone razliciti 
        if (N4 > 0 || S1 != S3)
        {
            Console.WriteLine("-1");
        }
        else
        {
            // Korak 07_02: Stampanje vrednosti elemenata matrice
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
