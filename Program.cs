using System;

namespace lab2
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(RomanNumber.Add(new RomanNumber(10), new RomanNumber(5)));
            Console.WriteLine(RomanNumber.Sub(new RomanNumber(10), new RomanNumber(5)));
            Console.WriteLine(RomanNumber.Mul(new RomanNumber(10), new RomanNumber(5)));
            Console.WriteLine(RomanNumber.Div(new RomanNumber(10), new RomanNumber(5)));
            RomanNumber[] romanNumberArray = new RomanNumber[10];
            for (int i = 0; i < 10; i++)
            {
                romanNumberArray[i] = new RomanNumber((ushort)(new Random().Next(1, 1000)));
                Console.Write(romanNumberArray[i] + " ");
            }
            Console.WriteLine();

            Array.Sort(romanNumberArray);

            for (int i = 0; i < 10; i++)
            {
                Console.Write(romanNumberArray[i] + " ");
            }


        }
    }
}
