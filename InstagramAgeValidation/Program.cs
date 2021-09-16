using System;

namespace InstagramAgeValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //programm kontrollib, kas kasutaja on vanem kui 13 või 13 aastat vana;
            //kui kasutaja on 13 voi vanem voib kasutada instagrami
            //kui kasutaja on noorem ei voi

            Console.WriteLine("Sisestage oma sünniaasta.");

            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int Age = 2021 - YearOfBirth;

            if(Age >= 13)
            {
                Console.WriteLine("Olete piisavalt vana.");
            }
            else if (Age < 13)
            {
                Console.WriteLine("Olete liiga noor");
            }

        }
    }
}
