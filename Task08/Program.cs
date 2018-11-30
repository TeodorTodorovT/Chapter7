using System;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Sorting an array means to arrange its elements in an increasing (or decreasing) order. Write a program, which sorts an array using the algorithm "selection sort".
            int i, j, iMin, temp;

            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (j = 0; j < length - 1; j++)
            {
                iMin = j;

                for (i = j + 1; i < length; i++) if (arr[i] < arr[iMin]) iMin = i;

                if (iMin != j)
                {
                    temp = arr[j];
                    arr[j] = arr[iMin];
                    arr[iMin] = temp;
                }
            }

            for (i = 0; i < length; i++) Console.Write("{0} ", arr[i]);
            Console.ReadLine();
        }
    }
}
