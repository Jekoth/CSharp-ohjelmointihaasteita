using System;

class Program
{
    static void Main(string[] args)
    {
        int[] taulukko = { 1, -2, 3, -4, 5 };
        TulostaTaulukko(taulukko); // kutsutaan metodia TulostaTaulukko, joka tulostaa alkuperäisen taulukon
        VastaluvutaTaulukko(taulukko); // kutsutaan metodia VastaluvutaTaulukko, joka muuttaa taulukon luvut vastaluvuikseen
        TulostaTaulukko(taulukko); // kutsutaan metodia TulostaTaulukko, joka tulostaa vastaluvutettu taulukon
    }

    static void VastaluvutaTaulukko(int[] taulukko)
    {
        for (int i = 0; i < taulukko.Length; i++)
        {
            taulukko[i] = -taulukko[i]; // muutetaan taulukon luku vastaluvuksi
        }
    }

    static void TulostaTaulukko(int[] taulukko)
    {
        for (int i = 0; i < taulukko.Length; i++)
        {
            Console.Write(taulukko[i] + " "); // tulostetaan taulukon luku ja välilyönti
        }
        Console.WriteLine(); // siirrytään seuraavalle riville
    }
}