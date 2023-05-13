using System;

class Program
{
    static void Main(string[] args)
    {
        // Tulostetaan valikko
        Console.WriteLine("Valikko:");
        Console.WriteLine("1. Kalorit jouleiksi");
        Console.WriteLine("2. Joulet kaloreiksi");

        // Pyydetään käyttäjältä valinta
        Console.Write("Valitse muunnos: ");
        int valinta = int.Parse(Console.ReadLine()!);

        // Suoritetaan muunnos käyttäjän valinnan perusteella
        if (valinta == 1)
        {
            Console.Write("Anna kalorimäärä: ");
            double kalorit = double.Parse(Console.ReadLine()!);
            double joulet = kalorit * 4.184;
            Console.WriteLine(kalorit + " cal = " + joulet + " J");
        }
        else if (valinta == 2)
        {
            Console.Write("Anna joulemäärä: ");
            double joulet = double.Parse(Console.ReadLine()!);
            double kalorit = joulet * 0.2390;
            Console.WriteLine(joulet + " J = " + kalorit + " cal");
        }
        else
        {
            Console.WriteLine("Virheellinen valinta!");
        }
    }
}