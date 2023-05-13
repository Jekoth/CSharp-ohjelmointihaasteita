using System;

class Program
{
    static void Main()
    {
        // Kysytään käyttäjältä x- ja y-koordinaatit
        Console.Write("Anna x-koordinaatti: ");
        int x = int.Parse(Console.ReadLine()!);

        Console.Write("Anna y-koordinaatti: ");
        int y = int.Parse(Console.ReadLine()!);

        // Määritetään vihollisen suunta x- ja y-koordinaattien perusteella
        string suunta = "";
        if (x > 0 && y > 0)
        {
            suunta = "koillisesta (NE)";
        }
        else if (x < 0 && y > 0)
        {
            suunta = "luoteesta (NW)";
        }
        else if (x < 0 && y < 0)
        {
            suunta = "lounaasta (SW)";
        }
        else if (x > 0 && y < 0)
        {
            suunta = "kaakosta (SE)";
        }

        // Tulostetaan viesti vihollisen suunnasta
        Console.WriteLine($"Vihollinen tulee {suunta}.");
    }
}