using System;
using System.Collections.Generic;

public class PascalCaseEx4
{
	public PascalCaseEx4()
	{
	}

    public static void PascalCase1()
    { 
        Console.WriteLine("Next: Program that Combines Words Together:");

        Console.WriteLine("Enter few separated words ");
        var inPut = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(inPut))
        {
            Console.WriteLine("Invalid Input:");
            return;
        }
    
        var words = inPut.Split(' '); //  split words into segments and save them in an array 
        var combinedString = "";  // create an empty string to hold the combined words

        foreach (var word  in words)  // we deal with each word in the array one at a time, change first character to uppercase
                                      //add & keep rest of characters in lowercase, starting with the first index of the word
        {
         var wordPascal=  char.ToUpper(word[0]) + word.ToLower().Substring(2); // change first character to uppercase and keep rest of characters in lowercase
                                                                               // Substring(1) retrieves characters starting from the first index of the word
          
            combinedString += wordPascal; // add the word to the combined string
        }
        
        Console.WriteLine(combinedString);

    }


/*   method2  first letter of each word was not uppercase , cutting input text to always two words. incase have a longer input text
    public static void PascalCase()
    {
        Console.WriteLine("Next: Program that Combines Words Together:");

        Console.WriteLine("Enter few separated words ");
        var inPut = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(inPut))
        {
            Console.WriteLine("Invalid Input:");
            return;
        }

        // otherwise split sentence into segments of words and save each segment at a string in an array 
        // each index will hold a text and later join the segments together
        //  how do i keep track of  the gaps between words 
        // think of  spliting string with indexOf() method check examples 14 in lessons
        /// 
        var index1 = inPut.IndexOf(' '); // find the index of the first space in the input string
        var firstword = inPut.Substring(0, index1); // 0 is the starting point and index1 is the end point
                                                    // (retrieves characters of the input string starting index o to the index of the fisrt space) 
        var secondword = inPut.Substring(index1 + 1);// retrieves characters of the input string starting from the index of the first space to the end of the string    
        Console.WriteLine("First word" + firstword);
        Console.WriteLine("Second word" + secondword);

        ///
        var words = inPut.Split(' '); //  split words into segments and save them in an array 

        var combinedWords = new List<string>();
        var totalcharacters = 0;

        // Figure out how to combine the words together with first letter of each word in uppercase
        foreach (var word in words)
        {
            combinedWords.Add(word);
            totalcharacters += word.Length + 1;
            while (totalcharacters < combinedWords.Count)
            {
                Console.WriteLine(string.Join("Check  available words: ", combinedWords));
            }

        }
        // Combining the words 
        for (int i = 0; i < combinedWords.Count - 1; i++)
        {
            var joinedWord = combinedWords[i] + combinedWords[i + 1];
            Console.WriteLine("Joined word2:" + joinedWord);
        }
        //Console.WriteLine(" Combination functionality does not seem work well, need to check it out ");
    }*/
    ////
}
