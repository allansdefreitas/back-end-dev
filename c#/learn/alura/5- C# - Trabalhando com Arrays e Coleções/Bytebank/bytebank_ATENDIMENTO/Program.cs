

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

        TestArrayInt();
        TestArrayString();
        TestSearchWord();
       


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
}