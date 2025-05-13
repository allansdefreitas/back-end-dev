

Dictionary<string, List<double>> studentAndGrades = new Dictionary<string, List<double>>
{
    {"Allan", new List<double> { 10, 7.5, 9, 8}},
    {"Micah", new List<double> { 10, 7, 9, 8}},
    {"Junior", new List<double>{ 10, 8, 10, 8}}
};


void ShowMainMenu()
{
    Console.WriteLine("Type 1 to show grades of all students");
    Console.WriteLine("Type 2 to show the average grades of all students");
    Console.WriteLine("Type -1 to exit");

    Console.Write("\nType an option: ");
    string chosenOption = Console.ReadLine()!;

    int chosenOptionInt = int.Parse(chosenOption);

    switch (chosenOptionInt)
    {
        case 1:
            ShowGradesAllStudents();
            break;

        case 2:
            ShowAverageGradesAllStudents();
            break;
        case -1:
            Console.WriteLine("Bye, bye!");
            Thread.Sleep(2000);
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid option");
            Thread.Sleep(2000);
            break;
    }
}

void ShowGradesAllStudents()
{
    Console.Clear();

    foreach (KeyValuePair<string, List<double>> kvpStudent in studentAndGrades)
    {
        Console.WriteLine("Student: {0}", kvpStudent.Key);

        Console.Write("Grades: ");
        foreach (double grade in kvpStudent.Value)
        {
            Console.Write("{0} ", grade);
        }
        Console.Write("\n\n");
    }

    WaitUserConfirmation();
}

void ShowAverageGradesAllStudents()
{
    Console.Clear();

    foreach (KeyValuePair<string, List<double>> kvpStudent in studentAndGrades)
    {
        Console.WriteLine("Student: {0}", kvpStudent.Key);
        Console.Write("Average: {0}", kvpStudent.Value.Average());
        Console.Write("\n\n");
    }
    WaitUserConfirmation();

}

void WaitUserConfirmation()
{
    Console.WriteLine("\nType any key to back to main menu");
    Console.ReadKey();
    Console.Clear();
    ShowMainMenu();
}


while (true)
{
    ShowMainMenu();
}




