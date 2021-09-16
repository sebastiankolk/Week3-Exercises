using System;

namespace Week3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN koodi
            //programm võrdleb sisestatud PIN koodi arvuga 1234
            //Kui sisestatud PIN kood on 1234
            //programm kuvab konsoolis "Tere tulemast!"
            //Kui sisestatud PIN on vale, programm kuvab konsoolis
            //"Vale PIN. Proovi uuesti."

            Console.WriteLine("Sisesta PIN-kood.");

            int kood1 = Convert.ToInt32(Console.ReadLine());

            /*if (kood1 == 1234)
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale PIN, proovi uuesti.");
            }*/
            if(kood1 != 1234)
            {
                Console.WriteLine("Vale PIN, proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere Tulemast!");
            }
        }
    }
}
