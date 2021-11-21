using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendest on pikem, kas ees- või perekonnanimi



            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();


            if (firstName.Length > lastName.Length)
            {
                Console.WriteLine($"Sinu eesnimes on rohkem sümboleid, kui perenimes.({firstName.Length})");
            }
            else if (firstName.Length < lastName.Length)
            {
                Console.WriteLine($"Sinu perenimes on rohkem sümboleid, kui eesnimes.({lastName.Length})");
            }
            else
            {
                Console.WriteLine($"Sinu eesnimes ja perenimes on sama arv sümboleid.({lastName.Length})");
            }
        }
    }
}
