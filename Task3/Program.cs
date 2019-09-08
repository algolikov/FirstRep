using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите напряжение");
            string U = Console.ReadLine();
            int Uint = int.Parse(U);

            Console.WriteLine("Введите сопротивление");
            string R = Console.ReadLine();
            int Rint = int.Parse(R);

            int I = Uint / Rint; //Сила тока
            int P = ((Uint * Uint) / Rint); // Мощность цепи

            Console.WriteLine("Сила тока = " + I);
            Console.WriteLine("Мощность цепи = " + P);

            Console.WriteLine("Для выхода нажмите ENTER");
            Console.ReadLine();
        }
    }
}
