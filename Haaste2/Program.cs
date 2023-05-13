using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Syötä pelaajan maatilojen määrä: ");
        int maatilat = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Syötä pelaajan herttuakuntien määrä: ");
        int herttuakunnat = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Syötä pelaajan maakuntien määrä: ");
        int maakunnat = int.Parse(Console.ReadLine()!);

        int pisteet = maatilat * 1 + herttuakunnat * 3 + maakunnat * 6;

        Console.WriteLine("Pelaajan pisteet yhteensä: " + pisteet);
    }
}