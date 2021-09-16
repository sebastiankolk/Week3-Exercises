using System;

namespace VowelsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tähte
            //programm kontrollib, kas sisestatud täht on
            //taishaalik voi kaashaalik
            //kui sisestatud taht on taishaalik programm kuvab taishaalik
            //kui sisestatud taht on kaashaalik programm kuvab kaashaalik
            //kasutame switchi
            //"mingi sone" - string
            //a character ehk char
            Console.WriteLine("Sisesta täht:");
            char userCharacter = Convert.ToChar(Console.ReadLine().ToLower());
            switch (userCharacter)
            {
                case 'a':
                    Console.WriteLine("täishäälik");
                    break;
                case 'e':
                    Console.WriteLine("täishäälik");
                    break;
                case 'i':
                    Console.WriteLine("täishäälik");
                    break;
                case 'o':
                    Console.WriteLine("täishäälik");
                    break;
                case 'u':
                    Console.WriteLine("täishäälik");
                    break;
                default:
                    Console.WriteLine("kaashäälik");
                    break;
            }
        }
    }
}
