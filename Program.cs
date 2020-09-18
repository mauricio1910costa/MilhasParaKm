using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- MilhasParaKm");
            double doubleA = 1;
            double doubleB = 1.609;
            double doubleMultiplicacao = doubleA * doubleB;
            Console.WriteLine($"{doubleA} * {doubleB} = {doubleMultiplicacao}");
        }
    }
}
