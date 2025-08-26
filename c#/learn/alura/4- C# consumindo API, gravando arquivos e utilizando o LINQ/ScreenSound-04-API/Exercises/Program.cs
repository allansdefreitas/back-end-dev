using System.Text.Json;
using System.Xml.Linq;

internal class Program
{

    private const string FILENAME = "users-data.json";


    private static void Main(string[] args)
    {
        //Exercise1();
        Exercise2();





    }

    public static void Exercise2()
    {

        GetUsersDataFromJSON(FILENAME);

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

        string nomeDoArquivo = $"{FILENAME}";

        File.WriteAllText(nomeDoArquivo, json);

        Console.WriteLine($"Arquivo \"{nomeDoArquivo}\" JSON criado com sucesso em {Path.GetFullPath(nomeDoArquivo)}!");
    }


    public static void GetUsersDataFromJSON(string filename)
    {
        Console.WriteLine($"Showing data from JSON file {filename}");
        //string fullPathFile = Path.GetFullPath(filename);

        string fileContent = File.ReadAllText(filename);

        Console.WriteLine(fileContent);

    }
}