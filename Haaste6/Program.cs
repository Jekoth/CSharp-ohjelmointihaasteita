using System;

class Program
{
    static void Main(string[] args)
    {
        // Käy läpi numerot 1-100
        for (int i = 1; i <= 100; i++)
        {
            // Tarkista, onko luku jaollinen sekä 3:lla että 5:llä
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(i + ": Sähkö ja tuli");
            }
            // Tarkista, onko luku jaollinen vain 3:lla
            else if (i % 3 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(i + ": Tuli");
            }
            // Tarkista, onko luku jaollinen vain 5:llä
            else if (i % 5 == 0)
            {                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(i + ": Sähkö");
            }
            // Jos luku ei ole jaollinen 3:lla tai 5:llä, se on normaali ammus
            else
            {
                // Aseta tekstin väri valkoiseksi ja tulosta viesti
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(i + ": Normaali");
            }
        }
    }
}