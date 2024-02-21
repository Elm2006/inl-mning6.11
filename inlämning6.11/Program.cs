using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vad ska ena sidan av figuren va");
        int storlek = int.Parse(Console.ReadLine());
        Console.WriteLine("Vilket tecken ska de vara?");
        char tecken = char.Parse(Console.ReadLine());
        Console.WriteLine("Vad ska avståndet vara");
        int avstånd = int.Parse(Console.ReadLine());
        if( avstånd > 0)
        {
            RitaKvadrat(storlek, tecken, avstånd);
        }
        else
        {

            RitaKvadrat(storlek, tecken);
        }
    }
    static void RitaKvadrat(int x, char c, int y)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write(c);
                for (int k = 0; k < y; k++)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            for(int k = 0; k < y; k++)
            {
                Console.WriteLine();
            }
        }
    }
    static void RitaKvadrat(int x, char c)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}