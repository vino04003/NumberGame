using System;

namespace Nummerkul
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();
            int returnvalue = slump.Next(1, 100);

            Console.WriteLine("Skriv ett yäni heltal mellan 1 o 100: ");
            int clabb = int.Parse(Console.ReadLine());
            int counter = 1;

            while(clabb != returnvalue)
            {
                counter=counter + 1;

                if(clabb < returnvalue)
                {
                    Console.WriteLine("Talet är mycket för lite");
                    clabb = int.Parse(Console.ReadLine());
                }

                if(clabb > returnvalue)
                {
                    Console.WriteLine("Talet är mycket större än det minsta");
                    clabb = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Vad bra!" + " Det tog "+ counter + " försök.");
        }
       
    }
}
