using System;

namespace Nummerkul
{
    class Program
    {
        static void Main(string[] args)
        {
            Random press = new Random();
            int returnvalue = press.Next(1, 100);

            Console.WriteLine("Skriv ett heltal mellan 1 - 100: ");
            int innit = int.Parse(Console.ReadLine());
            int counter = 1;

            while(innit != returnvalue)
            {
                counter=counter + 1;

                if(innit < returnvalue)
                {
                    Console.WriteLine("Hmm, jag tror du får gissa högre.");
                    innit = int.Parse(Console.ReadLine());
                }

                if(innit > returnvalue)
                {
                    Console.WriteLine("Oj! Inte så stort, gissa mindre tack.");
                    innit = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Vad bra!" + " Det tog bara "+ counter + " försök.");
        }
       
    }
}
