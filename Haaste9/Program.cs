using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Syötä numeerinen arvosana (0-5): ");
        int arvosana = int.Parse(Console.ReadLine()!);

        // Tarkistetaan, että arvosana on välillä 0-5
        if (arvosana < 0 || arvosana > 5)
        {
            Console.WriteLine("Virhe: Syötä numeerinen arvosana välillä 0-5.");
        }
        else
        {
            // Tulostetaan arvosanan sanallinen kuvaus
            switch (arvosana)
            {
                case 0:
                    Console.WriteLine("Hylätty");
                    break;
                case 1:
                    Console.WriteLine("Välttävä");
                    break;
                case 2:
                    Console.WriteLine("Tyydyttävä");
                    break;
                case 3:
                    Console.WriteLine("Hyvä");
                    break;
                case 4:
                    Console.WriteLine("Kiitettävä");
                    break;
                case 5:
                    Console.WriteLine("Erinomainen");
                    break;
                default:
                    break;
            }
        }
    }
}