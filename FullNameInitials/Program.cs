using System;

namespace FullNameInitials
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Console.WriteLine("Sisesta eesnimi: ");
            string fullName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();
            string fullName = $"{firstName}{lastName}";

            int charCounter = 0;

            foreach (char c in = fullName)
            {
                charCounter++;
            }

            Console.WriteLine(charCounter);



        }
    }
}
