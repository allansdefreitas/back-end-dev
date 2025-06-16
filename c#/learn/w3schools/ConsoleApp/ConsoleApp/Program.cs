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
            //Console.WriteLine("Enter your age:");
            //int age = Convert.ToInt32( Console.ReadLine() );
            //Console.WriteLine("Your age is: " + age);


            Console.WriteLine("10 % 3 = {0}", 10 % 3);

            Console.WriteLine(5 > 3);

            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: {0}", txt.Length);
            Console.WriteLine(txt.ToLower());


            string title = "MsC ";
            string firstName = "John ";
            string lastName = "Doe";
            string name = string.Concat(title, firstName, lastName);
            Console.WriteLine(name);

            // Interpolação
            firstName = "Allan";
            lastName = "Freitas";
            string fullName = $"My full name is: {firstName} {lastName} {"MsC"}";
            Console.WriteLine(fullName);

            //Caracteres especiais
            txt = "The character \"\\\" is called \'backslash\'.";
            Console.WriteLine(txt);
            
            // Caracteres de escape
            txt = "Jonh\b"; // volta o cursor para a esquerda, mas como não tem nada depois pra..
            Console.WriteLine(txt); // ...sobrescrever, não surte efeito de apagar

            txt = "Jonh\b "; // o espaço sobrescreve o h
            Console.WriteLine(txt);

            txt = "Jo\bnh";
            Console.WriteLine(txt); // o 'o' é sobrescrito pelo n

            txt = "Jonh\nMariah";
            Console.WriteLine(txt);

            txt = "John\tDoe";
            Console.WriteLine(txt);

            Console.Clear();

            // Operador ternário
            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            string result = (time < 22) ? "Dia bom e fresquinho" : "Dia bom";
            Console.WriteLine(result);


            Console.Clear();
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }

            Console.Clear();


            // While ===================================================
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            
            // Do/While 

            i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 5);


            Console.Clear();

            // For loop =========================================
            for (i = 0; i <= 10; i = i + 2)
            {
                Console.WriteLine(i);
            }

            Console.Clear();

            // Foreach loop =====================================

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda", "Yaris", "Spin Activ 7" };
            foreach (string carro in cars)
            {
                Console.WriteLine(carro);
            }

            Console.Clear();
            // Break/Continue ===================================

            for (i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    Console.WriteLine("4 found...continue");
                    continue;
                }
                Console.WriteLine(i);
            }

            Console.Write("\n\n");

            for (i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    Console.WriteLine("4 found...break");
                    break;
                }
                Console.WriteLine(i);
            }

            Console.Clear();

            for (i = 0; i < 10; i++)
            {

                for(int j = 0; j < 10; j++)
                {
                    if (i == 4)
                    {
                        Console.WriteLine("i==4 found...break");
                        break;
                    }
                    Console.WriteLine($"{i} {j}");
                }
                
            }

            Console.Clear();

            // Arrays ===================================================
            string[] names = { "Allan", "Samuel", "Pedro", "Rebeca" };

            Console.WriteLine(names[2]);

            names[0] = "Laudicea";

            Console.WriteLine(names[0]);

            int[] ints = { 1, 2, 3, 4, 5, 6 };


            for (i = 0; i< ints.Length; i++)
            {
                Console.WriteLine(i);   
            }

            // Outra forma de criar arrays
            string[] livros = new string[4];

            livros[0] = "Calendário da Profecia";
            livros[1] = "Daniel e Apocalipse";
            livros[2] = "Pureza Sexual";
            livros[3] = "Começando Juntos";

            string[] paises = new string[3] { "EUA", "Portugal", "Israel" };

            string[] cidades = new string[] { "Tenessee", "Monte Mor", "Haifa" };

            string[] conferencias = { "CVPR", "IJCNN", "IEEE/CVF", "BRACIS" };


            Console.Clear();

            //foreach (type variableName in arrayName) 
            foreach (string cidade in cidades) {
                Console.WriteLine($"I will visit the {cidade} city!");
            }

            Console.Clear();
            
            // Sort arrays ---------
            Array.Sort(paises); // Aqui, a chamada é por referência
            foreach (var pais in paises)
            {
                Console.WriteLine(pais);
            }


            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int number in myNumbers)
            {
                Console.WriteLine(number);
            }

            // Using System.Linq namespace ====================
            Console.WriteLine(myNumbers.Max());

            Console.Clear();


            // Arrays de duas dimensões ===========================================
            int[,] array2D = { { 1, 4, 2 }, { 3, 6, 8 } };

            Console.WriteLine(array2D[0, 2]);
            array2D[0, 2] = 1;

            Console.WriteLine(array2D[0, 2]);

            Console.Clear();

            int[,] matriz = { { 1, 4, 2 }, { 3, 6, 8 } };
            
            int contador = 0;
            foreach (int e in matriz)
            {
                Console.WriteLine(e);
                contador++;
            }

            Console.WriteLine("contador: {0}", contador);


            Console.WriteLine(matriz.Length);

            Console.WriteLine("matriz.GetLength(0) = {0}", matriz.GetLength(0)); // 2 linhas
            Console.WriteLine("matriz.GetLength(1) = {0}", matriz.GetLength(1)); // 3 colunas

            //Console.Clear();

            for (i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"matriz[{i}, {j}]= {matriz[i, j]}");
                }
            }


            // Métodos/funções: Argumento padrão /Parâmetro opcional ========================

            Console.Clear();
            MyMethod();

            // Named Arguments =============================================================
            Console.Clear();
            NamedArguments(child3: "John", child1: "Liam", child2: "Liam");

            // Sobrecarga de métodos =============================================================
            Console.Clear();
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);

            Car car = new Car();
            car.honk();

            // Enums =========================
            Console.Clear();
            Level nivel = Level.Medium;
            
            Console.WriteLine(nivel);
            Console.WriteLine(Level.High);
            Console.WriteLine((int) (Level.High));


            int myNum = (int)Months.April;
            Console.WriteLine(myNum);
        }

        static void MyMethod(string country = "Norway")
        {
            Console.WriteLine(country);
        }

        static void NamedArguments(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }
    }

    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field

        public Car()
        {
        }
    }

    sealed class Animal
    {
        public string sciName;
        public void move()
        {
            Console.WriteLine("The animal is moving");
        }
    }

    //class Dog : Animal // 'class1' : cannot derive from sealed type 'class2'
    //{
    //    public string name;
    //}

    // Interface ================================================================
    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    class Pig : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    enum Level
    {
        Low, // O valor é o próprio nome da propriedade
        Medium,
        High
    }

    enum Months
    {
        January,    // 0
        February,   // 1
        March,      // 2
        April,      // 3
        May,        // 4
        June,       // 5
        July        // 6
    }


}
