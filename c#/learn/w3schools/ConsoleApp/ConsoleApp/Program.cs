using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            char letter = 'A';

            Console.WriteLine(letter);

            const int constNumber = 10;

            Console.WriteLine($"constNumber: {constNumber}");

            int x = 5, y = 10, z = 15;
            double a, b, c;
            Console.WriteLine(x + y + z);
            
            a = b = c = 10.5;
            Console.WriteLine(a);

            // Data types
            double myDouble = 7.5D;
            Console.WriteLine(myDouble);

            float myFloat = 9.5F;
            Console.WriteLine(myFloat);

            float floatTest = 8.7f;
            Console.WriteLine(floatTest);

            int myInt = int.MaxValue;

            Console.WriteLine(myInt);

            Console.WriteLine(myInt + 1);


            /*
            checked
            {
                int myInt2 = int.MaxValue;

                Console.WriteLine(myInt2);

                Console.WriteLine(myInt2 + 1); // Arithmetic operation resulted in an overflow.
            }
            */


        }
    }
}