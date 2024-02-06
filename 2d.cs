/*
 * Question 2-d
 * Which composer comes first in the dictionary: 'Berlioz', 'Borodin', 'Brian',
    'Bartok', 'Bellini', 'Buxtehude', 'Bernstein'. Which one comes last?
*/

using System;

class 2d
{
    static void Main()
    {
        string[] composers = { "Berlioz", "Borodin", "Brian", "Bartok", "Bellini", "Buxtehude", "Bernstein" };

        Array.Sort(composers);

        string firstComposer = composers[0];
        string lastComposer = composers[composers.Length - 1];
        Console.WriteLine("First composer:");
        Console.WriteLine(firstComposer);
        Console.WriteLine("Last composer: ");
        Console.WriteLine(lastComposer);
    }
}