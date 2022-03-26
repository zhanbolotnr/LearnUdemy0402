using System;

namespace LearnUdemy0402
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers2 = { 0, 3, 2, 1, 5, 4, 6, 7, 8, 9 };
            foreach (int n in numbers2)
            {
                /* if (n % 2 == 0)
                 {
                     Console.WriteLine(n);
                 }*/

                if (n % 2 != 0)
                    continue;

                Console.Write($"\t{n}");
            }
            Console.ReadLine();
            
            int[] numbers = { 0, 3, 2, 1, 5, 4, 6, 7, 8, 9 };
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Number = {numbers[i]} ");
                for (int j = 0; j < letters.Length; j++)
                {
                    if (numbers[i] == j)
                        break;
                    Console.Write($" {letters[j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
