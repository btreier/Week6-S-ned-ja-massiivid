using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Don't Panic" nulliga (0)
            //programm asendab kõik 'a' tähed samas lauses numbriga 4

            string word = "Don't Panic";

            word = word.Replace('o', '0');
            word = word.Replace('a', '4');
            Console.WriteLine(word);
        }
    }
}
