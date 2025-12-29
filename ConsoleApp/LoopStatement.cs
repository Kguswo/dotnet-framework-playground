using System;

namespace ConsoleApp
{
    internal class LoopStatement
    {
        public static void Run()
        {
            Console.WriteLine("ch.6 반복문");

            Console.WriteLine("For 문:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"반복 {i + 1}");
            }

            // while loop
            Console.WriteLine("\nWhile 문:");
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine($"반복 {j + 1}");
                j++;
            }
            // do-while loop
            Console.WriteLine("\nDo-While 문:");
            int k = 0;
            do
            {
                Console.WriteLine($"반복 {k + 1}");
                k++;
            } while (k < 5);
            Console.WriteLine();

            string[] strs = { "Apple", "Banana", "Cherry" };
            for (int i = 0; i < strs.Length; i++)
            {
                Console.WriteLine(strs[i]);
            }
            foreach (string i in strs)
            {
                Console.WriteLine(i);
            }
        }
    }
}
