using System;

class Program
{
    static void Main()
    {
        Console.Title = "Ritariryhmä Liikkeelle";
        Console.Write("Anna kohderivi (1-8): ");
        int rivi = int.Parse(Console.ReadLine()!) - 1;
        Console.Write("Anna kohtisarake (A-H): ");
        int sarake = Console.ReadLine()!.ToUpper()[0] - 'A';

        //Tämä luo kaksiulotteisen taulukon (array), joka sisältää kahdeksan
        //yksittäistä taulukkoa (jokaisessa kaksi kokonaislukua), joita
        //käytetään ritarin liikkeiden määrittämiseen laudalla.
        List<int[]> liikkeet = new List<int[]> {
            new int[] { 2, 1 },
            new int[] { 1, 2 },
            new int[] { -1, 2 },
            new int[] { -2, 1 },
            new int[] { -2, -1 },
            new int[] { -1, -2 },
            new int[] { 1, -2 },
            new int[] { 2, -1 }
        };

        Console.WriteLine("\nRitariryhmä liikkuu:");
        Console.Beep();

        //Tämä funktio laskee ritariryhmän mahdolliset siirrot annettuun
        //kohteeseen pelilaudalla ja tulostaa jokaisen ritarin siirron konsoliin
        for (int i = 0; i < liikkeet.Count; i++)
        {
            int uusiRivi = rivi + liikkeet[i][0];
            int uusiSarake = sarake + liikkeet[i][1];

            if (uusiRivi >= 0 && uusiRivi < 8 && uusiSarake >= 0 && uusiSarake < 8)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Ritari {i + 1} ");
                Console.ResetColor();
                Console.WriteLine($"siirtyy kohteeseen {char.ConvertFromUtf32(uusiSarake + 'A')}{uusiRivi + 1}");
            }
        }
    }
}