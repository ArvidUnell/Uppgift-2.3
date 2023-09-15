using System;
namespace Uppgift_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till [BILHUTHYRNINGSFIRMA].");
            Console.WriteLine("Hur många dagar vill du hyra bilen?");
            byte dagar = byte.Parse(Console.ReadLine());
            Console.WriteLine("Hur många kilometer har du tänkt köra?");
            int kilometer = int.Parse(Console.ReadLine());

            Console.WriteLine($"Det kommer att kosta {300 + (dagar - 1)*500 + kilometer} kronor.");

            Console.ReadKey();
        }
    }
}