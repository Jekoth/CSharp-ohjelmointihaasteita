using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFilePath = "input.txt";
        string outputFilePath = "output.txt";

        // Lue syötekansiosta tekstitiedosto.
        string inputText = File.ReadAllText(inputFilePath);

        // Muunna numerot merkkijonoiksi.
        string outputText = ConvertNumbersToStrings(inputText);

        // Tallenna muunnettu teksti tekstitiedostoon.
        File.WriteAllText(outputFilePath, outputText);

        Console.WriteLine("Tiedosto tallennettu onnistuneesti.");
    }

    static string ConvertNumbersToStrings(string text)
    {
        string[] numbers = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        string[] strings = { "nolla", "yksi", "kaksi", "kolme", "neljä", "viisi", "kuusi", "seitsemän", "kahdeksan", "yhdeksän" };

        // Korvaa kaikki numerot vastaavilla merkkijonoilla.
        foreach (string number in numbers)
        {
            text = text.Replace(number, strings[int.Parse(number)]);
        }

        return text;
    }
}