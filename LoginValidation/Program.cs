using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kasutajatunnus:");
            string userNme = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string password = Console.ReadLine();

            if (userName == "admin" && password == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale kasutajatunnus või parool. Proovi uuesti");
            }
            */

            if (userName != "admin" || password != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või parool. Proovi uuesti!");
            }
            else
            { 
                Console.WriteLine("Tere tulemast!");
            }

        }
    }
}
