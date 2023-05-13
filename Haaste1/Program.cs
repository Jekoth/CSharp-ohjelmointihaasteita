using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Kuinka monta kalaa karhut ovat tänään saaneet? ");
        int saalis = int.Parse(Console.ReadLine()!);
        int kalat_per_karhu = saalis / 4;
        int kissan_saalis = saalis % 4;
        Console.WriteLine("Karhuille jaetaan {0} kalaa per karhu.", kalat_per_karhu);
        Console.WriteLine("Kissalle jää {0} kalaa.", kissan_saalis);

        //On olemassa kolme kala määrää missä kissa saa enemmän kalaa kuin karhut: 1, 2 ja 3.
    }
}