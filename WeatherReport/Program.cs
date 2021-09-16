using System;

namespace WeatherReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib mitu kraadi oues on
            //kui oues on rohkem kui 35 kraadi, programm kuvab "boiling hot"
            //kui oues on 30-35 kraadi, programm kuvab "hot";
            //kui oues on 20-30 kraadi, programm kuvab "nice";
            //kui oues on 10-20 kraadi, programm kuvab "chilly";
            //kui oues on 0-10 kraadi, programm kuvab "cold";
            Console.WriteLine("Mitu kraadi on õues?");
            int oue = Convert.ToInt32(Console.ReadLine());
            if (oue >= 35)
            {
                Console.WriteLine("boiling hot");
            }
            else if (oue >=30 && oue <35)
            {
                Console.WriteLine("Hot");
            }
            else if (oue >= 20 && oue < 30)
            {
                Console.WriteLine("nice");
            }
            else if (oue >= 10 && oue < 20)
            {
                Console.WriteLine("chilly");
            }
            else if (oue >= 0 && oue < 10)
            {
                Console.WriteLine("cold");
            }
            else
            {
                Console.WriteLine("Freezing cold");
            } 
        }
    }
}
