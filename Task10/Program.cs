using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program, which finds the most frequently occurring element in an array.
            int counter = 0, tempCounter = 1, foundNumber = 0;

            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            for (int i = 0; i < length - 1; i++)
            {
                if (arr[i] == arr[i + 1]) tempCounter++;
                else tempCounter = 1;
                if (tempCounter > counter)
                {
                    counter = tempCounter;
                    foundNumber = arr[i];
                }
            }

            Console.WriteLine("{0} was found {1} times.", foundNumber, counter);
            Console.ReadLine();
        }
    }
}
