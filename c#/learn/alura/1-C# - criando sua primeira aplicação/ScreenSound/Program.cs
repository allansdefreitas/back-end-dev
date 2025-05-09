void ShowWelcomeMessage()
{
    string welcomeMessage = "Welcome to Screen Sound!";

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

void ShowOptionsMenu()
{
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
            Console.WriteLine("You chose option " + chosenOption);
            break;
        case 2:
            Console.WriteLine("You chose option " + chosenOption);
            break;
        case 3:
            Console.WriteLine("You chose option " + chosenOption);
            break;
        case 4:
            Console.WriteLine("You chose option " + chosenOption);
            break;
        case -1:
            Console.WriteLine("You chose option " + chosenOption);
            Console.WriteLine(@"
            ██╗░░░██╗░█████╗░██╗░░░░░███████╗░░░  ██████╗░███████╗██████╗░░██████╗░█████╗░███╗░░██╗░█████╗░██╗
            ██║░░░██║██╔══██╗██║░░░░░██╔════╝░░░  ██╔══██╗██╔════╝██╔══██╗██╔════╝██╔══██╗████╗░██║██╔══██╗██║
            ╚██╗░██╔╝███████║██║░░░░░█████╗░░░░░  ██████╔╝█████╗░░██████╔╝╚█████╗░██║░░██║██╔██╗██║███████║██║
            ░╚████╔╝░██╔══██║██║░░░░░██╔══╝░░██╗  ██╔═══╝░██╔══╝░░██╔══██╗░╚═══██╗██║░░██║██║╚████║██╔══██║╚═╝
            ░░╚██╔╝░░██║░░██║███████╗███████╗╚█║  ██║░░░░░███████╗██║░░██║██████╔╝╚█████╔╝██║░╚███║██║░░██║██╗
            ░░░╚═╝░░░╚═╝░░╚═╝╚══════╝╚══════╝░╚╝  ╚═╝░░░░░╚══════╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚══╝╚═╝░░╚═╝╚═╝");
            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }


}

ShowWelcomeMessage();
ShowOptionsMenu();



