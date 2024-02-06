/*
 * Question 5-a
 * Write a function inside(x,y,x1,y1,x2,y2) that returns True or False
    depending on whether the point (x,y) lies in the rectangle with lower left
    corner (x1,y1) and upper right corner (x2,y2).
*/

using System;

class q5a
{
    static void Main()
    {
        // These lines are to get user input for point and rectangle coordinates
        Console.Write("Enter x: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter x1: ");
        int x1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter y1: ");
        int y1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter x2: ");
        int x2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter y2: ");
        int y2 = Convert.ToInt32(Console.ReadLine());

        bool result = Inside(x, y, x1, y1, x2, y2);
        Console.WriteLine($"inside({x}, {y}, {x1}, {y1}, {x2}, {y2}):\n{result}");
    }

    static bool Inside(int x, int y, int x1, int y1, int x2, int y2)
    {
        return x1 <= x && x <= x2 && y1 <= y && y <= y2;
    }
}
