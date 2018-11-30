using System;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program, which reads from the console two integer numbers N and K (K < N) and array of N integers. Find those K consecutive elements in the array, which have maximal sum.
            int sum = 0;

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K (K < N): ");
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr, (a, b) => b.CompareTo(a));

            for (int i = 0; i < k; i++) sum += arr[i];

            Console.WriteLine("\nBiggest sum is {0}", sum);
            Console.ReadLine();
        }
    }
}
