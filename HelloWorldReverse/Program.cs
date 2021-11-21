using System;

namespace HelloWorldReversed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello, World!" tagurpidi

            string word = "Hello, World!";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }
        }
    }
}