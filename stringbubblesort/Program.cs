using System;
using System.Collections.Generic;

namespace bubblesort
{
    public class Program
    {
        static void Main()
        {
            List<string> strings = new List<string>();
            int count = 0;
            bool LoopRunner = true;
            int inputNumber;

            Console.WriteLine("Enter a string, type 'EXIT' to quit and 'NEXT' to sorting:");

            while (LoopRunner)
            {
                string inputString = Console.ReadLine();

                if (inputString.ToLower() == "next")
                {
                    BubbleSortAscending(strings, count);

                    Console.WriteLine("Ascending Order:");
                    PrintList(strings, count);

                    BubbleSortDescending(strings, count);

                    Console.WriteLine("Descending Order:");
                    PrintList(strings, count);
                    Console.ReadLine();
                    LoopRunner = true;
                }

                if (inputString.ToLower() == "exit")
                {
                    Console.WriteLine("Elements in the list:");
                    PrintList(strings, count);
                    Console.ReadLine();
                    LoopRunner = true;
                }
                if (!int.TryParse(inputString, out inputNumber))
                {
                    strings.Add(inputString);
                    count++;
                    Console.WriteLine("String added to the list.");
                    LoopRunner = true;
                }
                else
                {
                    Console.WriteLine("You have entered an integer. Please enter a string or a character.");
                }
            }
        }

        public static void BubbleSortAscending(List<string> list, int length)
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    if (string.Compare(list[j], list[j + 1]) > 0)
                    {
                        string temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }

        public static void BubbleSortDescending(List<string> list, int length)
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    if (string.Compare(list[j], list[j + 1]) < 0)
                    {
                        string temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }

        static void PrintList(List<string> list, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
