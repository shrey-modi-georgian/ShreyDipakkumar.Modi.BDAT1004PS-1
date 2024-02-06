/*
 * Question 5-b
 * Use function inside() from part a. to write an expression that tests whether
    the point (1,1) lies in both of the following rectangles: one with lower left
    corner (0.3, 0.5) and upper right corner (1.1, 0.7) and the other with lower
    left corner (0.5, 0.2) and upper right corner (1.1, 2). 
*/

using System;

class q5b
{
    static void Main()
    {
        // (1,1) point as given in question
        int x = 1;
        int y = 1;

        // Rec1 where x1,y1 is (0.3,0.5) and x2,y2 is (1.1,0.7)
        double x1Rec1 = 0.3;
        double y1Rec1 = 0.5;
        double x2Rec1 = 1.1;
        double y2Rec1 = 0.7;

        // Rec2 where x1,y1 is (0.5,0.2) and x2,y2 is (1.1,2)
        double x1Rec2 = 0.5;
        double y1Rec2 = 0.2;
        double x2Rec2 = 1.1;
        double y2Rec2 = 2;

        // This is to check if the point (1, 1) is inside Rec1
        bool isInRect1 = Inside(x, y, x1Rec1, y1Rec1, x2Rec1, y2Rec1);
        if (isInRect1)
        {
            Console.WriteLine($"The point ({x}, {y}) is inside Rectangle 1.");
        }
        else
        {
            Console.WriteLine($"The point ({x}, {y}) is not inside Rectangle 1.");
        }

        // This is to check if the point (1, 1) is inside Rec2
        bool isInRect2 = Inside(x, y, x1Rec2, y1Rec2, x2Rec2, y2Rec2);
        if (isInRect2)
        {
            Console.WriteLine($"The point ({x}, {y}) is inside Rectangle 2.");
        }
        else
        {
            Console.WriteLine($"The point ({x}, {y}) is not inside Rectangle 2.");
        }
    }

    static bool Inside(int x, int y, double x1, double y1, double x2, double y2)
    {
        return x1 <= x && x <= x2 && y1 <= y && y <= y2;
    }
}
