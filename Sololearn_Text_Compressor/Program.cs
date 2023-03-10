using System;
/*

@author Stephen Bailey
@version 1.0
Date 3-10-2023

Sololearn Program

You need to decompress text. The compressed version has a number next to each symbol/letter, representing the amount of time that symbol should appear. 
For example, a2b3 is the compressed version of aabbb

Task: 
Write a program that takes the compressed text as input and outputs the decompressed version.

Input Format: 
A single string with letters/symbols, each followed by a number.

Output Format: 
A string, representing the decompressed text.

Sample Input: 
k2&4b1

Sample Output: 
kk&&&&b

 */
namespace Sololearn_Text_Compressor
{
    class Program
    {
        static void Main(string[] args)
        {
            // tester input variable, comment out before live on Sololearn
            string inputText = "k2&4b1";

            // get text, uncomment out before live Sololearn
            //string text =  Console.ReadLine();

            // new text uncompressor object
            TextUncompressor newTextUncompressor = new TextUncompressor(inputText);

            // return uncompressed input
            Console.WriteLine(newTextUncompressor.Uncompress());

            // hold the console open, comment out before live on Sololearn
            Console.ReadLine();
        }

        // class definition
        class TextUncompressor
        {
            //
            private string tempCharacterToUncompress = "";
            private int tempCompressionTimes = 0;           

            // constructor
            public TextUncompressor(string inputText)
            {
                // loop through the 
                for (int i = 0; i < inputText.Length; i++)
                {
                    // reset variables
                    tempCharacterToUncompress = "";
                    tempCompressionTimes = 0;

                    // if remainder IS zero, index is even, character must be the text to uncompress
                    if (i % inputText.Length == 0)
                    {
                        tempCharacterToUncompress = inputText[i].ToString();
                    }
                    else// else remainder NOT zero, index is odd, character must be the number of uncompressions
                    {
                        tempCompressionTimes = inputText[i];
                    }
                }
            }

            // method to uncompress text input
            public bool Uncompress()
            {
                throw new NotImplementedException();
            }
        }
    }
}