using System;
using System.Collections.Generic;

public class CountVowels
{
    public CountVowels()
    {
    }

    /* Exercise 5: Write a program and ask the user to enter an English word.
    //Count the number of vowels (a, e, o, u, i) in the word. 
     So, if the user enters "inadequate", the program should display 6 on the console.
    */

    public static void CountVowelsInWord()
    {
        Console.WriteLine("Next:Program counts the number of vowels in a word");
        Console.WriteLine("Please enter a word");
        var input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid Input");
            return;
        }
        // create a list of vowels  and initialize it with vowels
        var vowels = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });
        // its always good to deal with the limitations at  the begining 
        if (input.Length < 2)  // if the word is less than 2 characters 
        {
            Console.WriteLine("Sorry Word is inadequate: 6");
            return;
        }
        var vowel = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });  // declared and initialized a list of vowels

        var elements = input.Split(' '); // split the string and save it to an array of strings
        var vowelCount = 0;
        foreach (var items in elements)   // iterate through array and convert each element to integers and save it in a list
        {
            var character1 = items.ToCharArray(); // convert each string in to characters & save characters in an array

            foreach (var character in character1)// iterate through character[] array and check if character is found in the list of vowel1
            {
                if (vowel.Contains(character))
                {
                    vowelCount++;
                }

            }

        }
        Console.WriteLine("Total number of vowels is:" + vowelCount);


    }
}
