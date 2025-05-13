
Dictionary<string, string> perguntasRespostas = new Dictionary<string, string>{
    {"Que país colonizou o Brasil por mais tempo?", "Portugal"},
    {"Em que ano ocorreu a reforma protestante", "1517"},
    {"Quantos livros chamados de 'evangelhos' têm no Novo Testamento da Bíblia Sagrada?", "4"},
    {"Quantos livros há na Bíblia Sagrada?", "66"},
};



Console.Clear();
Console.WriteLine("Quiz de perguntas e respostas");


Console.WriteLine("Vamos iniciar?");
Console.WriteLine("...\n");
Thread.Sleep(2000);

Random random = new Random();
int numeroAleatorioPergunta = random.Next(0, perguntasRespostas.Count);

KeyValuePair<string, string> perguntaAleatoria = perguntasRespostas.ElementAt(numeroAleatorioPergunta);


Console.Write($"{perguntaAleatoria.Key} ");
string respostaUsuario = Console.ReadLine()!;

string resposta = perguntaAleatoria.Value;
if (respostaUsuario.Equals(resposta))
{
    Console.WriteLine("Resposta correta!");
}
else
{
    Console.WriteLine("Resposta incorreta");
}




