using System;

namespace ExercicioCondicional1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
                Console.WriteLine("Negativo");
            else
            Console.WriteLine("positivo");

        }
    }
}