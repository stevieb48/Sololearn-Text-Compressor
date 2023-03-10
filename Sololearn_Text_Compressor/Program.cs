using System;
using System.Text;
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
            //string inputText = "k2&4b1";

            // get text, uncomment out before live Sololearn
            string inputText =  Console.ReadLine();

            // new text uncompressor object passing input text
            TextUncompressor newTextUncompressor = new TextUncompressor(inputText);

            // return uncompressed input
            Console.WriteLine(newTextUncompressor.ReturnUncompressedText());

            // hold the console open, comment out before live on Sololearn
            //Console.ReadLine();
        }

        // class definition
        class TextUncompressor
        {
            // temporary variables
            private string tempCharacterToUncompress = "";
            private int tempCompressionTimes = 0;

            // final text
            private string uncompressedText = "";

            // create new string builder
            StringBuilder newStringBuilder = new StringBuilder();

            // constructor call method to start uncompressing
            public TextUncompressor(string inputText) => StartUncompression(inputText);

            // method to start uncompressing text
            private void StartUncompression(string inputText)
            {
                // loop through the input text
                for (int i = 0; i < inputText.Length; i++)
                {
                    // if remainder IS zero, index is even, character must be the text to uncompress
                    if (i % 2 == 0)
                    {
                        // set the temporary character to uncompress
                        tempCharacterToUncompress = inputText[i].ToString();
                    }
                    else// else remainder NOT zero, index is odd, character must be the number of uncompressions
                    {
                        // set the temporary number of uncompressions
                        tempCompressionTimes = int.Parse(inputText[i].ToString());

                        // call method to uncompress
                        UncompressText();

                        // reset variables
                        tempCharacterToUncompress = "";
                        tempCompressionTimes = 0;
                    }
                }
            }

            // method to uncompress text input
            private void UncompressText()
            {
                // loop to uncompress
                for (int i = 0; i < tempCompressionTimes; i++)
                {
                    // build new uncompressed text
                    newStringBuilder.Append(tempCharacterToUncompress);
                }
            }

            // method to return uncompressed text
            public string ReturnUncompressedText()
            {
                return uncompressedText = newStringBuilder.ToString();
            }
        }
    }
}