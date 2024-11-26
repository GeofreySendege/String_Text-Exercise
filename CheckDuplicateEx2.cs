using System;
using System.Collections.Generic;

public class CheckDuplicateEx2
{
	public CheckDuplicateEx2()
	{
	}

    // Exercise 2: programe that prompts a user enter a few numbers ,
    // checks if any duplicate number , if yes output the duplicate
    // Updated and made changes in CheckDuplicate   functionality

    public static void checkForDuplicateNumber()
    {
        Console.WriteLine("Next:Program checks for duplicate numbers");
        string[] elements;
        var list = new List<int>();

        Console.WriteLine("Please enter a few numbers separated by:'-'");
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
            // Create a list of uniquenumbers 

            var listOfUniqueNumbers= new List<int>();
            if (list.Count < 1)
            {
                return;
            }
            for (int i = 0; i < list.Count - 1; i++)
            {
                var number =list[i];

                if (listOfUniqueNumbers.Contains(number))
                {
                    Console.WriteLine("Duplicate Number:");
                    return;
                }
                listOfUniqueNumbers.Add(number); // add the number to the list of  unique numbers 
            }
        }
        Console.WriteLine(" Non Duplicate"); 

    }




}
