using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize game
        int dragonHealth = 10;
        int cityHealth = 15;
        int round = 1;
        Random rand = new Random();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Lohikäärme lähestyy kaupunkia!");

        // Ask first player for dragon distance
        Console.ForegroundColor = ConsoleColor.White;
        int dragonDistance = -1;
        while (dragonDistance < 0 || dragonDistance > 100)
        {
            Console.Write("Pelaaja 1, kuinka kaukana kaupungista lohikäärme on? ");
            try
            {
                dragonDistance = int.Parse(Console.ReadLine()!);
            }
            catch (FormatException)
            {
                Console.WriteLine("Virheellinen syöte! Syötteen tulee olla kokonaisluku välillä 0-100.");
            }
        }

        // Start game loop
        while (dragonHealth > 0 && cityHealth > 0)
        {
            // Print round and health
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("TILANNE: Kierros: {0} Kaupunki: {1}/15 Lohikäärme: {2}/10", round, cityHealth, dragonHealth);

            // Calculate damage
            int damage = 1;
            if (round % 3 == 0 && round % 5 == 0)
            {
                damage = 10;
            }
            else if (round % 3 == 0 || round % 5 == 0)
            {
                damage = 3;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Taikakanuuna tekee {0} pistettä vahinkoa tällä vuorolla.", damage);

            // Ask second player for target distance
            Console.ForegroundColor = ConsoleColor.White;
            int targetDistance = -1;
            while (targetDistance < 0 || targetDistance > 100)
            {
                Console.Write("Mille etäisyydelle kanuunalla ammutaan? ");
                try
                {
                    targetDistance = int.Parse(Console.ReadLine()!);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Virheellinen syöte! Syötteen tulee olla kokonaisluku välillä 0-100.");
                }
            }

            // Calculate hit or miss
            if (targetDistance < dragonDistance)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Tähtäys oli liian lyhyt ja osuma jäi vajaaksi.");
            }
            else if (targetDistance > dragonDistance)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Tähtäys oli liian pitkä ja ammus lensi ohi.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Osuma! Lohikäärme menettää {0} terveyspistettä.", damage);
                dragonHealth -= damage;
            }

            // Decrease city health if dragon is still alive
            if (dragonHealth > 0)
            {
                cityHealth--;
            }

            // Increase round counter
            round++;
        }

        // Print game result
        Console.ForegroundColor = ConsoleColor.Yellow;
        if (dragonHealth <= 0)
        {
            Console.WriteLine("Onneksi olkoon, lohikäärme on voitettu!");
        }
        else
        {
            Console.WriteLine("Valitettavasti lohikäärme tuhosi kaupungin. Parempaa onnea ensi kerralla!");
        }
    }
}