using System;

class Program
{
    static void Main(string[] args)
    {
        int pinKoodi = 1234; // PIN koodi
        int pukKoodi = 87654321; // PUK koodi
        int yritysLaskuri = 0; // laskuri väärille yrityksille
        int koodi; // käyttäjän syöttämä koodi

        Console.WriteLine("Syötä nelinumeroinen PIN koodi:");

        while (true)
        {
            koodi = int.Parse(Console.ReadLine()!);

            if (koodi == pinKoodi)
            {
                Console.WriteLine("PIN koodi oikein!");
                break;
            }
            else
            {
                yritysLaskuri++;
                Console.WriteLine("PIN koodi väärin!");

                if (yritysLaskuri == 3)
                {
                    Console.WriteLine("Liian monta yritystä, syötä 8 numeroinen PUK koodi:");
                    break;
                }
            }
        }

        if (yritysLaskuri == 3) // Jos PIN koodi syötetty väärin 3 kertaa
        {
            yritysLaskuri = 0; // Nollataan laskuri
            while (true)
            {
                koodi = int.Parse(Console.ReadLine()!);

                if (koodi == pukKoodi)
                {
                    Console.WriteLine("PUK koodi oikein!");
                    break;
                }
                else
                {
                    yritysLaskuri++;
                    Console.WriteLine("PUK koodi väärin!");

                    if (yritysLaskuri == 3)
                    {
                        Console.WriteLine("Liian monta yritystä, ohjelma lopetetaan.");
                        return;
                    }
                }
            }
        }
    }
}