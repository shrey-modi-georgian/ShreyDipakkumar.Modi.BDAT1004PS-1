/*
 * Question 4
 * Write a program in C# Sharp to separate odd and even integers in separate arrays.
*/

using System;

class q4
{
    static void Main()
    {
        Console.Write("Input the number of elements to be stored in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine($"Input {n} elements in the array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int[] evenArray = new int[n];
        int[] oddArray = new int[n];
        int evenCount = 0;
        int oddCount = 0;

        // This code below is to separate odd and even elements
        foreach (int num in array)
        {
            if (num % 2 == 0)
            {
                evenArray[evenCount] = num;
                evenCount++;
            }
            else
            {
                oddArray[oddCount] = num;
                oddCount++;
            }
        }

        // This is to display even elements
        Console.Write("\nThe Even elements are:\n");
        for (int i = 0; i < evenCount; i++)
        {

            Console.Write($"{evenArray[i]} ");
        }

        // This is to display odd elements
        Console.Write("\nThe Odd elements are:\n");
        for (int i = 0; i < oddCount; i++)
        {
        Console.Write($"{oddArray[i]} ");
        }
    }
}
