using Exercises.Modelos;
using System.Text.Json;
using System.Xml.Linq;

internal class Program
{

    private const string FILENAME = "users-data";

    private static void Main(string[] args)
    {
        //Exercise1();
        //Exercise2();
        //Exercise3MelhorSolucao();
        //Exercise4();
        Exercise5();

    }

    private static void Exercise5()
    {
        /* 5. Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, permite ao usuário 
         * inserir uma idade e exibe as pessoas com aquela idade. */

        string filename = FILENAME + "-list.json";

        string jsonString = File.ReadAllText(filename);

        // Desserializar JSON para objeto Pessoa
        List<User> users = JsonSerializer.Deserialize<List<User>>(jsonString);


        Console.WriteLine("Enter a value for age you want to search: ");
        string ageString = Console.ReadLine()!;
        int age = int.Parse(ageString);

        List<User> userInAge = users
            .Where(x => x.Age == age)
            .ToList();

        int quantityUsersInAge = userInAge.Count();

        Console.WriteLine($"{quantityUsersInAge} users have the age of {age} years old:\n");

        foreach (User user in userInAge)
        {
            user.ShowInfo();

        }

    }

    private static void Exercise4()
    {
        /* 4. Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, ,
         * desserializa essas informações em uma lista e exibe na tela. */

        string filename = FILENAME + "-list.json";

        Console.WriteLine($"Showing data from file {filename}");

        string jsonString = File.ReadAllText(filename);

        // Desserializar JSON para objeto Pessoa
        List<User> users = JsonSerializer.Deserialize<List<User>>(jsonString);

        foreach(var user in users)
        {
            user.ShowInfo();
        }
    }

    private static void Exercise3()
    {
        /* 3. Criar um programa que permite ao usuário inserir informações de várias pessoas, 
         * armazena essas informações em uma lista, serializa a lista em formato JSON e salva
         * em um arquivo */

        string name, email, option;
        int age;

        List<User> users = new List<User>();

        while (true)
        {
            Console.WriteLine("Do you want enter a user? (Y | N) ");
            option = Console.ReadLine()!;

            if (option.Equals("Y") || option.Equals("y"))
            {
                Console.WriteLine();
                Console.WriteLine("Type the name: \n");
                name = Console.ReadLine()!;

                Console.WriteLine("Type the email: \n");
                email = Console.ReadLine()!;

                Console.WriteLine("Type the age: \n");
                string ageString = Console.ReadLine()!;
                age = int.Parse(ageString);

                User user = new User();
                user.Name = name;
                user.Email = email;
                user.Age = age;

                users.Add(user);

                Console.Clear();

            }
            else if (option.Equals("N") || option.Equals("n"))
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong option! Type another option!");
            }

        }

        GerarArquivoJSONWithUserDataList(FILENAME + "-list.json", users);

    }

    private static void Exercise3MelhorSolucao()
    {
        /* 3. Criar um programa que permite ao usuário inserir informações de várias pessoas, 
         * armazena essas informações em uma lista, serializa a lista em formato JSON e salva
         * em um arquivo */

        string name, email, option;
        int age;

        List<User> users = new List<User>();

        while (true)
        {
            Console.WriteLine("Do you want enter a user? (Y | N) ");
            option = Console.ReadLine()!;

            if (option.Equals("Y") || option.Equals("y"))
            {
                Console.WriteLine();
                Console.WriteLine("Type the name: \n");
                name = Console.ReadLine()!;

                Console.WriteLine("Type the email: \n");
                email = Console.ReadLine()!;

                Console.WriteLine("Type the age: \n");
                string ageString = Console.ReadLine()!;
                age = int.Parse(ageString);

                User user = new User();
                user.Name = name;
                user.Email = email;
                user.Age = age;

                users.Add(user);

                Console.Clear();

            }
            else if (option.Equals("N") || option.Equals("n"))
            {
                break;
            }
            else
            {
                Console.WriteLine("Wrong option! Type another option!");
            }

        }

        // Serializar a lista em JSON
        string jsonString = JsonSerializer.Serialize(users);
        string filename = FILENAME + "-list.json";

        File.WriteAllText(filename, jsonString);

    }

  

    public static void Exercise2()
    {
        /* 2. Criar um programa que lê um arquivo JSON contendo informações de uma pessoa, desserializa essas 
         * informações e exibe na tela.
         */

        GetUsersDataFromJSON2(FILENAME + ".json");

    }

    public static void Exercise1()
    {
        /* 
         * 1. Criar um programa que permite ao usuário inserir informações de uma pessoa (nome, idade, e e-mail), 
         * serializa essas informações em formato JSON e salva em um arquivo. */

        string name, email;
        int age;
        Console.WriteLine("Type your data");


        Console.WriteLine("Type your name: \n");
        name = Console.ReadLine()!;

        Console.WriteLine("Type your email: \n");
        email = Console.ReadLine()!;

        Console.WriteLine("Type your age: \n");
        string ageString = Console.ReadLine()!;
        age = int.Parse(ageString);

        Console.Clear();

        GerarArquivoJSONWithUserData(name, age, email);
    }

    public static void GerarArquivoJSONWithUserData(string name, int age, string email)
    {


        // Criando um objeto anônimo
        string json = JsonSerializer.Serialize(new
        {
            Name = name,
            Age = age,
            Email = email
        });

        string nomeDoArquivo = $"{FILENAME}.json";

        File.WriteAllText(nomeDoArquivo, json);

        Console.WriteLine($"Arquivo \"{nomeDoArquivo}\" JSON criado com sucesso em {Path.GetFullPath(nomeDoArquivo)}!");
    }

    public static void GerarArquivoJSONWithUserDataList(string filename, List<User> users)
    {

        string json = null;

        foreach (User user in users)
        {
            // Criando um objeto anônimo
            json = JsonSerializer.Serialize(new
            {
                Name = user.Name,
                Age = user.Age,
                Email = user.Email
            });

            File.AppendAllText(filename, json);

        }

        
    }


    public static void GetUsersDataFromJSON(string filename)
    {
        Console.WriteLine($"Showing data from JSON file {filename}");
        //string fullPathFile = Path.GetFullPath(filename);

        string fileContent = File.ReadAllText(filename);

        Console.WriteLine(fileContent);

    }
    public static void GetUsersDataFromJSON2(string filename)
    {
        Console.WriteLine($"Showing data from JSON file {filename}");
        //string fullPathFile = Path.GetFullPath(filename);


        string jsonString = File.ReadAllText(filename);

        // Desserializar JSON para objeto Pessoa
        User user = JsonSerializer.Deserialize<User>(jsonString);

        // Show info
        user.ShowInfo();

    }


    
}