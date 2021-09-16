using System;

namespace WeatherReportSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mitu kraadi on õues?");
            int oue = Convert.ToInt32(Console.ReadLine());
            switch(oue)
            {
                case var _ when oue < 0:
                    Console.WriteLine("Freezing cold");
                    break;
                case var _ when oue >= 0 && oue < 10:
                    Console.WriteLine("cold");
                    break;
                case var _ when oue >= 10 && oue < 20:
                    Console.WriteLine("chilly");
                    break;
                case var _ when oue >= 25 && oue < 30:
                    Console.WriteLine("nice");
                    break;
                case var _ when oue >= 30 && oue < 35:
                    Console.WriteLine("hot");
                    break;
                case var _ when oue >= 35:
                    Console.WriteLine("boiling hot");
                    break;
            }
        }
    }
}
