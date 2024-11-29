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
        var vowel = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });  // declared and initialized a list of vowels
        var elements = input.Split(' '); // split the string and save it to an array of strings'
        if (elements.Length != 1)
        {
            Console.WriteLine("Input should be one word.");
            return;
        }
        var vowelCount = 0;

        for (var i = 0; i < input.Length; i++) 
        {
            if (vowel.Contains(input[i]))
                vowelCount++;
        }
        foreach (var character in input)// iterate through character[] array and check if character is found in the list of vowel1
        {
            if (vowel.Contains(character))
            {
                vowelCount++;
            }
        }

        Console.WriteLine(input[1]);
        Console.WriteLine("Total number of vowels is:" + vowelCount);
    }
}
