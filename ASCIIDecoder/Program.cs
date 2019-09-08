using System;

namespace ASCIIDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число ");
            sbyte a = sbyte.Parse(Console.ReadLine());
            if ((a < 32) && (a > 127))
            {
                Console.WriteLine("Введите другое число, для продолжения нажмите ENTER");
                Console.ReadLine();
            }
            else
            {
                
            }

        }
    }
}
