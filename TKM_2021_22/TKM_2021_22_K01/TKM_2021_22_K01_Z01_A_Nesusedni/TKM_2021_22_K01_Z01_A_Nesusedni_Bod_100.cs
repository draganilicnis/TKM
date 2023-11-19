// C# - Коришћење градитеља стринга (StringBuilder) - Решење за 100 поена
// https://arena.petlja.org/competition/2021-2022-kv1-testiranje#tab_134035 
// https://algora.petlja.org/t/resenja-zadataka-2021-2022-kvalifikacije-prvi-krug/6882 
// Kurs 1. razred, tema 7.5. String i niz karaktera - Koliko je sporo: https://petlja.org/kurs/11171/36/1399#id5
// Kurs 1. razred, tema 10.3. Argumenti komandne linije programa – Preusmeravanje standardnog ulaza i izlaza:
// https://petlja.org/kurs/11171/44/2431#id2

using System;
using System.Text;

class Tkm_2021_22_K01_Z01_A_Nesusedni_Bod_100
{
    static void Main()
    {
        string ulaz_slova_dva = Console.ReadLine();
        char c1 = ulaz_slova_dva[0];
        char c2 = ulaz_slova_dva[1];

        string[] ulaz_broj_slova = Console.ReadLine().Split();
        int a = int.Parse(ulaz_broj_slova[0]);
        int b = int.Parse(ulaz_broj_slova[1]);

        if (Math.Abs(a - b) > 1)
        {
            Console.WriteLine("nemoguce");
        }
        else
        {
            StringBuilder sRezultat = new StringBuilder();
            // string dva_slova = ulaz_slova_dva; // "" + c1 + c2;
            if (a < b) { sRezultat.Append(c2); }
            int n = Math.Min(a, b);
            for (int i = 0; i < n; i++) { sRezultat.Append(ulaz_slova_dva); }
            if (a > b) { sRezultat.Append(c1); }
            Console.WriteLine(sRezultat);
        }
    }
}
