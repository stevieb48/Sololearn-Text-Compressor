using System;
/*

@author Stephen Bailey
@version 1.0
Date 3-10-2023

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
            string text = "k2&4b1";

            // get text, uncomment out before live Sololearn
            //string text =  Console.ReadLine();

            // new text uncompressor object
            TextUncompressor newTextUncompressor = new TextUncompressor(text);

            // return
            Console.WriteLine(newTextUncompressor.Uncompress());

            // hold the console open, comment out before live on Sololearn
            Console.ReadLine();
        }

        // class definition
        class TextUncompressor
        {
            // constructor
            public TextUncompressor(string text)
            {
                throw new NotImplementedException();
            }

            // method to uncompress text input
            public bool Uncompress()
            {
                throw new NotImplementedException();
            }
        }
    }
}