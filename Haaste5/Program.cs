using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int arvattavaNumero = 0;
        bool validInput = false;

        // Pyydä ensimmäiseltä pelaajalta numeron syöttöä kunnes syöte on validi
        while (!validInput)
        {
            Console.WriteLine("Ensimmäinen pelaaja, syötä numero väliltä 1-100:");
            string input = Console.ReadLine()!;

            // Tyhjennetään konsoli ja siirrytään toisen pelaajan arvausvaiheeseen
            if (int.TryParse(input, out arvattavaNumero) && arvattavaNumero >= 1 && arvattavaNumero <= 100)
            {
                validInput = true;
                Console.Clear();
                break;
            }
            else
            {
                Console.WriteLine("Virheellinen syöte, yritä uudelleen.");
            }
        }

        Console.WriteLine("Toinen pelaaja, arvaa numero:");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int arvaus))
            {
                if (arvaus == arvattavaNumero)
                {
                    Console.WriteLine("Onneksi olkoon, arvasit oikein!");
                    return;
                }
                else if (arvaus < arvattavaNumero)
                {
                    Console.WriteLine("{0} on liian pieni!", arvaus);
                }
                else
                {
                    Console.WriteLine("{0} on liian suuri!", arvaus);
                }
            }
            else
            {
                Console.WriteLine("Virheellinen syöte, yritä uudelleen.");
            }
        }
    }
}