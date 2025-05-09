string welcomeMessage = "Welcome to Screen Sound";
Console.WriteLine(welcomeMessage);


string curso = "C#: Criando sua primeira aplicação C#";
string nome = "Guilherme Lima & Daniel Portugal";

Console.WriteLine("O nome do curso é : " + curso);
Console.WriteLine("Os nomes dos instrutores são: " + nome);



Console.WriteLine("Qual é o seu nome?");
string name = Console.ReadLine();
Console.WriteLine("Olá, " + name + "!");

Console.WriteLine($"Hi, {name}!");

Console.WriteLine("Olá, {0}!", nome);

Console.WriteLine("Hello, student {0} and teachers {1}!", name, nome);





List<string> languages = new List<string> { "C", "C++", "Java", "Python", "C#" };

Console.WriteLine(languages[4]);

Console.WriteLine("Type the desired position: ");
string position = Console.ReadLine()!;
int positionInt = int.Parse(position);

string language = languages[positionInt];

Console.WriteLine($"The desired position contains the {language} element!");

