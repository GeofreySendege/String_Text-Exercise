using System;
using System.Collections.Generic;

public class CheckDuplicateEx2
{
	public CheckDuplicateEx2()
	{
	}

    // Exercise 2: programe that prompts a user enter a few numbers ,
    // checks if any duplicate number , if yes output the duplicate
    // Implementation needs to  be changed 

    public static void checkForDuplicateNumber()
    {
        string[] elements;
        var list = new List<int>();

        Console.WriteLine("Please enter a few numbers separated by '-' sign:");
        var inputStr = Console.ReadLine();
        if ((!string.IsNullOrEmpty(inputStr)))
        {
            elements = inputStr.Split('-'); // split the string and save it to an array of strings
            foreach (string element in elements)   // iterate through array and convert each element to integers and save it in a list
            {

                list.Add(int.Parse(element)); // add  each converted  number to list of numbers 
            }
            // compare the numbers in the list and check if there is any duplicate
            //  compare the  consective numbers if they are equal display duplicate

            if (list.Count < 1)
            {
                return;
            }
            for (int i = 0; i < list.Count - 1; i++)
            {

                if (list[i + 1] == list[i])
                    Console.WriteLine(" duplicate number");
                else Console.WriteLine("Non duplicate");
            }

        }
        Console.WriteLine(" EXIT");  // figure out how to exit

    }




}
