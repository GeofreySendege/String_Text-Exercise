using System;
using System.Collections.Generic;

public class PascalCaseEx4
{
	public PascalCaseEx4()
	{
	}
     
    public static void PascalCase()
    {
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
        var index1 = inPut.IndexOf(' ');
        var firstword = inPut.Substring(0, index1);
        var secondword = inPut.Substring(index1 + 1);
        Console.WriteLine("First word" + firstword);
        Console.WriteLine("Second word" + secondword);

        ///
        var words = inPut.Split(' '); //  split words into segments and save them in an array 

        var combinedWords = new List<string>();
        var totalcharacters = 0;

        // Figure out how to combine the words without cutting them out 
        foreach (var word in words)
        {
            combinedWords.Add(word);
            totalcharacters += word.Length + 1;
            while (totalcharacters < combinedWords.Count)
            {
                Console.WriteLine(string.Join("check Test: ", combinedWords));
            }

        }


        // need to remove the space between Geofrey and Sendege
        // Think alittle bit more how to combine the words without cutting them 

        for (int i = 0; i < combinedWords.Count - 1; i++)
        {
            var joinedWord = combinedWords[i] + combinedWords[i + 1];
            Console.WriteLine("Joined word2:" + joinedWord);
        }

    }

}
