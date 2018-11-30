using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {//task: Write a program, which reads two arrays from the console and checks whether they are equal (two arrays are equal when they are of equal length and all of their elements, which have the same index, are equal).
            bool arraysEqual = true;

            Console.Write("Enter lenght of first array: ");
            int length = int.Parse(Console.ReadLine());

            int[] arrA = new int[length];

            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write("Enter element {0}: ", i);
                arrA[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter lenght of second array: ");

            if (length != int.Parse(Console.ReadLine())) Console.WriteLine("Arrays have different lengths.");
            else
            {
                int[] arrB = new int[length];

                for (int i = 0; i < arrB.Length; i++)
                {
                    Console.Write("Enter element {0}: ", i);
                    arrB[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < arrA.Length; i++)
                {
                    if (arrA[i] != arrB[i])
                    {
                        Console.WriteLine("Arrays are different.");
                        arraysEqual = false;
                        break;
                    }
                }

                if (arraysEqual) Console.WriteLine("Arrays are the same.");
                
            }
            Console.ReadLine();
        }   
    }
}
