using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!"




            string word = "Hello World!".ToLower();
            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;


            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'h')
                {
                    hCounter++;
                }
            }

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'o')
                {
                    oCounter++;
                }
            }

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'l')
                {
                    lCounter++;
                }
            }

            if (hCounter != 1)
            {
                Console.WriteLine($"Lauses 'Hello World!' on {hCounter} 'h' tähte.");
            }
            else
            {
                Console.WriteLine($"Lauses 'Hello World!' on {hCounter} 'h' täht.");
            }

            if (oCounter != 1)
            {
                Console.WriteLine($"Lauses 'Hello World!' on {oCounter} 'o' tähte.");
            }
            else
            {
                Console.WriteLine($"Lauses 'Hello World!' on {oCounter} 'o' täht.");
            }

            if (lCounter != 1)
            {
                Console.WriteLine($"Lauses 'Hello World!' on {lCounter} 'l' tähte.");
            }
            else
            {
                Console.WriteLine($"Lauses 'Hello World!' on {lCounter} 'l' täht.");
            }
        }
    }
}
