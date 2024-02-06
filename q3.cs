/*
 * Question 3
 * Implement function triangleArea(a,b,c) that takes as input the lengths of the 3
    sides of a triangle and returns the area of the triangle. By Heron's formula, the area
    of a triangle with side lengths a, b, and c is s(s - a)(s -b)(s -c), where s = (a+b+c)/2. 
*/

using System;

class q3
{
    static void Main()
    {
        // This code below is to get input from user
        Console.Write("Enter a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double result = TriangleArea(a, b, c);

        Console.WriteLine($"The area of the triangle with sides {a}, {b}, and {c} is: {result}");
    }

    static double TriangleArea(double a, double b, double c)
    {
        // The formula was given is question
        double s = (a + b + c) / 2;
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        return area;
    }
}
