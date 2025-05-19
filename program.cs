using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Fluxograma da Engenharia ---");

        Console.Write("O objeto está se movendo (S/N)? ");
        string movendo = Console.ReadLine().Trim().ToUpper();

        if (movendo == "S")
        {
            Console.Write("Deveria? (S/N) ");
            string deveria = Console.ReadLine().Trim().ToUpper();

            if (deveria == "S")
            {
                Console.WriteLine("Ótimo!");
            }
            else
            {
                Console.WriteLine("Use Silver Tape.");
            }
        }
        else
        {
            Console.Write("Deveria? (S/N) ");
            string deveria = Console.ReadLine().Trim().ToUpper();

            if (deveria == "S")
            {
                Console.WriteLine("Use WD-40.");
            }
            else
            {
                Console.WriteLine("Ótimo!");
            }
        }
    }
}
