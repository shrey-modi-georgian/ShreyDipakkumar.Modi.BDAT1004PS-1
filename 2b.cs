/*
 * Question 2-b
 * Does 'Supercalifragilisticexpialidocious' contain 'ice' as a substring? 
*/


using System;

class 2b
{
    static void Main()
    {
        string word = "Supercalifragilisticexpialidocious";
        string sub = "ice";

        bool ans = word.Contains(sub);

        Console.WriteLine(ans);
    }
}