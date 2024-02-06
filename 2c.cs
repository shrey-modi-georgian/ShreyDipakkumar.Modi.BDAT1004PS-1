/*
 * Question 2-c
 * Which of the following words is the longest:
    Supercalifragilisticexpialidocious, Honorificabilitudinitatibus, or
    Bababadalgharaghtakamminarronnkonn?
*/

using System;
class 2c
{
    static void Main()
    {
        string word1 = "Supercalifragilisticexpialidocious";
        string word2 = "Honorificabilitudinitatibus";
        string word3 = "Bababadalgharaghtakamminarronnkonn";

        string lw = "";

        if (word1.Length > lw.Length)
        {
            lw = word1;
        }

        if (word2.Length > lw.Length)
        {
            lw = word2;
        }

        if (word3.Length > lw.Length)
        {
            lw = word3;
        }

        Console.WriteLine(lw);
    }
}
