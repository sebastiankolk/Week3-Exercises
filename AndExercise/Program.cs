using System;

namespace AndExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks
            //miinimum matemaatikas 85 punkti 
            //miinimum keemias 90 punkti
            //miinimum bioloogias 95 punkti
            //programm kusib kasutajal sisestada tema eksami punktid ja otsustab,kas kasutaja saab arstiks oppida
            Console.WriteLine("sisesta matemaatika punktid");
            int matemaatika = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisesta keemia punktid");
            int keemia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisesta bioloogia punktid");
            int bioloogia = Convert.ToInt32(Console.ReadLine());
            if (matemaatika >= 85 && keemia >=90 && bioloogia >= 95 )
            {
                Console.WriteLine("Võid sisseastumisele minna.");
            }
            else
            {
                Console.WriteLine("Pole võimalik minna sisseastumisele.");
            }
        }
    }
}
