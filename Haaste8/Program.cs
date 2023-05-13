using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Syötä lompakon saldo: ");
        double lompakko = double.Parse(Console.ReadLine()!);

        Console.Write("Syötä lihapiirakan hinta: ");
        double hinta = double.Parse(Console.ReadLine()!);

        if (lompakko >= hinta)
        {
            double vaihtoraha = lompakko - hinta;
            Console.WriteLine("Ostoksen jälkeen lompakossa on {0:F2} euroa.", vaihtoraha);
        }
        else
        {
            Console.WriteLine("Ei varaa lihapiirakkaan. Paastoaminen on suositeltavaa.");
        }
    }
}