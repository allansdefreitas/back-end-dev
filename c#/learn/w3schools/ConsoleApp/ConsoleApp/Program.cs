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

            // Números em  notação científica

            float f1 = 4e-1F; //4 => (move vírgula para esquerda 1 vez) => 0.4
            Console.WriteLine(f1);
            double d1 = 10E4D; // 10 => (move vírgula para direita 4 vezes) => 100000
            Console.WriteLine(d1);

            bool isTilapiaADeliciaBom = true;
            bool isRefrigeranteSaudavel = false;

            Console.WriteLine(isTilapiaADeliciaBom);

            char grade = 'A';
            Console.WriteLine(grade);

            // Conversão implícita: De tamanho menor para maior
            // char -> int -> long -> float -> double
            int castCharToInt = grade;
            Console.WriteLine(castCharToInt);

            // Conversão explícita: De tamanho maior para menor
            // double -> float -> long -> int -> char
            double meuDouble = 9.75;
            int meuInt = (int) meuDouble;

            Console.WriteLine(meuDouble);
            Console.WriteLine(meuInt);

            int myInt2 = 10;
            double myDouble2 = 5.25;
            bool myBool2 = true;

            // Conversão explícita com métodos embutidos
            Console.WriteLine("\n\nConversão explícita com métodos embutidos\n");
            Console.WriteLine(Convert.ToString(myInt2));
            Console.WriteLine(Convert.ToDouble(myInt2));
            Console.WriteLine(Convert.ToInt32(myDouble2));
            Console.WriteLine(Convert.ToString(myBool2));


            // User inputs
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("Your age is: " + age);




        }
    }
}