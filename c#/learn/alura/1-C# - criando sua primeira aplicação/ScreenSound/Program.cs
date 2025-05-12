using System.Text;

string welcomeMessage = "Welcome to Screen Sound!";
List<string> bandsList = new List<string> { "Arautos do Rei", "Prisma Brasil", "Banda e Orquestra Canaã" };


void ShowLogo()
{

    // got at https://fsymbols.com/
    Console.WriteLine(@"
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine(welcomeMessage);

}

void ShowMainMenu()
{
    ShowLogo();
    Console.WriteLine("\nType 1 to insert a band");
    Console.WriteLine("Type 2 to show all bands");
    Console.WriteLine("Type 3 to rate a band");
    Console.WriteLine("Type 4 to show the average of a band");
    Console.WriteLine("Type -1 to exit");

    Console.Write("\nType an option: ");
    string chosenOption = Console.ReadLine()!;

    int chosenOptionInt = int.Parse(chosenOption);

    switch (chosenOptionInt)
    {
        case 1:
            InsertBand();
            break;
        case 2:
            ListBands();
            break;
        case 3:
            Console.WriteLine("You chose option " + chosenOption);
            break;
        case 4:
            Console.WriteLine("You chose option " + chosenOption);
            break;
        case -1:
            Console.WriteLine("You chose option " + chosenOption);
            Console.WriteLine("Vale, persona!");
            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
}

void ShowMenuTitle(string title)
{

    int lettersQuantity = title.Length;
    string asterisks = string.Empty.PadLeft(lettersQuantity, '*');

    Console.WriteLine(asterisks);
    Console.WriteLine(title);
    Console.WriteLine(asterisks + "\n");

}

void InsertBand()
{
    Console.Clear();
    ShowMenuTitle("Insert a band");
    Console.WriteLine("Type the name of the band: ");
    string bandName = Console.ReadLine()!;
    bandsList.Add(bandName);
    Console.WriteLine($"The band {bandName} was inserted successfully!");
    Thread.Sleep(2000);
    Console.Clear();

    ShowMainMenu();
}

void ListBands()
{

    Console.Clear();
    ShowMenuTitle("List bands");
    // for (int i = 0; i < bandsList.Count; i++)
    // {
    //     Console.WriteLine($"{i + 1}. {bandsList[i]}");
    // }

    foreach (string band in bandsList)
    {
        Console.WriteLine($"Band: {band}");
    }

    Console.WriteLine("\nType any key to back to main menu");
    Console.ReadKey();
    Console.Clear();
    ShowMainMenu();
}

ShowMainMenu();
Environment.Exit(0);



