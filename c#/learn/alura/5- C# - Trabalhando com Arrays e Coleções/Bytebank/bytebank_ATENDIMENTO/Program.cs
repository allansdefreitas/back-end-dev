

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

        //TestArrayInt();
        //TestArrayString();
        //TestSearchWord();
        //TestArrayInt2();



        Array sample = Array.CreateInstance(typeof(double), 6);
        sample.SetValue(7.5, 3);
        sample.SetValue(7.9, 1);
        sample.SetValue(8, 2);
        sample.SetValue(9, 5);
        sample.SetValue(10, 4);
        sample.SetValue(9.9, 0);

        CalculateMedian(sample);


    }

    private static void TestSearchWord()
    {
        string[] words = new string[5];

        for (int i = 0; i < words.Length; i++)
        {
            Console.Write($"Enter the {i+1}º word: ");
            string wordInserted = Console.ReadLine()!;
            words[i] = wordInserted;
        }

        Console.Write("\nType a word to search: ");
        var searchWord = Console.ReadLine()!;
        bool searchWordWasFound = false;

        for (int i = 0;i < words.Length; i++)
        {
            string word = words[i];
            if (searchWord.Equals(word))
            {
                searchWordWasFound = true;
                break;
            }
        }

        if (searchWordWasFound)
        {
            Console.WriteLine($"The word \"{searchWord}\" was found!");
        }
        else
        {
            Console.WriteLine($"The word \"{searchWord}\" was NOT found!");
        }

    }

    private static void TestArrayString()
    {
        string[] names = new string[] { "Allan", "Ester" };


        foreach (string name in names)
        {
            Console.WriteLine($"Name: {name}");
        }
    }

    private static void TestArrayInt()
    {

        int[] ages = new int[5];

        ages[0] = 10;
        ages[1] = 14;
        ages[2] = 12;
        ages[3] = 25;
        ages[4] = 33;

        int agesSummation = 0;


        for (int i = 0; i < ages.Length; i++)
        {
            int ithAge = ages[i];
            agesSummation += ithAge;

            Console.WriteLine($"{i + 1}. {ithAge}");
        }

        double average = (double)agesSummation / ages.Length;
        Console.WriteLine($"The average of ages is {average}");

    }


    private static void CalculateMedian(Array array)
    {

        if(array == null || array.Length == 0)
        {
            Console.WriteLine("Array is empty or is null");
        }

        double[] sortedNumbers = (double[]) array.Clone();

        Array.Sort(sortedNumbers);

        int length = sortedNumbers.Length;
        int middle = length / 2;

        double median = (length % 2) != 0 ? sortedNumbers[middle] : 
                ( (sortedNumbers[middle] + sortedNumbers[middle - 1])/2 );


        Console.WriteLine($"The median is {median}");

    }
}