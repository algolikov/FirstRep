using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первый Катет =");
            string first = Console.ReadLine();
            int f = int.Parse(first);

            Console.WriteLine("Второй Катет =");
            string second = Console.ReadLine();
            int s = int.Parse(second);

            double gip = 0;// гипотенуза
            gip = Math.Sqrt(f * f + s * s);

            Console.WriteLine("Гипотенуза = " + gip);
            Console.WriteLine("Для выхода нажите ENTER");
            Console.ReadLine();
        }
    }
}
