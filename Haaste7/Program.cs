using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1 = Kivi, 2 = Paperi, 3 = Sakset ?");

        // Pelaajan valinta
        int playerChoice = int.Parse(Console.ReadLine()!);

        // Tietokoneen valinta
        Random random = new Random();
        int computerChoice = random.Next(1, 4);

        // Voittajan määrittäminen
        string winner;
        if (playerChoice == computerChoice)
        {
            winner = "Tasapeli!";
        }
        else if (playerChoice == 1 && computerChoice == 3 ||
                 playerChoice == 2 && computerChoice == 1 ||
                 playerChoice == 3 && computerChoice == 2)
        {
            winner = "Pelaaja voittaa!";
        }
        else
        {
            winner = "Tietokone voittaa!";
        }

        // Voittajan ilmoittaminen
        Console.WriteLine($"Tietokone valitsi: {computerChoice}");
        Console.WriteLine(winner);
    }
}