using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada kasutajatunnust ja parooli
            //programm kontrollib kasutajatunnust ja parooli
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud parool on "admin1234"
            //programm kuvab "Tere tulemast"
            //muul juhul programm kuvab "Vale kasutajatunnus voi parool,proovi uuesti"
            Console.WriteLine("Sisesta kasutajatunnus:");
            string username = Console.ReadLine();
            Console.WriteLine("Sisesta parool");
            string password = Console.ReadLine();

            /*if (username == "admin" && password == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
            }

            else
            {
                Console.WriteLine("Vale kasutaja tunnus voi parool, proovi uuesti");
            } */
            if (username != "admin" || password != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus voi parool, proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }
        }
    }
}
