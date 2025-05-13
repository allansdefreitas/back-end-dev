
Dictionary<string, string> perguntasRespostas = new Dictionary<string, string>{
    {"Quantos livros chamados de 'evangelhos' têm no Novo Testamento da Bíblia Sagrada?", "4"},
    {"Quantos livros há na Bíblia Sagrada?", "66"},

    {"Quem construiu a arca para sobreviver ao dilúvio?", "Noé"},
    {"Quem foi lançado na cova dos leões?", "Daniel"},
    {"Qual o primeiro livro da Bíblia?", "Gênesis"},
    {"Quem foi a mãe de Jesus?", "Maria"},
    {"Quem traiu Jesus por 30 moedas de prata?", "Judas Iscariotes"},
    {"Qual o nome do mar que Moisés abriu?", "Mar Vermelho"},
    {"Quantos discípulos Jesus teve?", "12"},
    {"Quem foi engolido por um grande peixe?", "Jonas"},
    {"Qual o nome do gigante derrotado por Davi?", "Golias"},
    {"Quem foi o primeiro homem criado por Deus?", "Adão"},

    // Médias
    {"Qual apóstolo era cobrador de impostos?", "Mateus"},
    {"Quem escreveu a maioria das cartas do Novo Testamento?", "Paulo"},
    {"Qual o nome do irmão de Moisés?", "Arão"},
    {"Qual o nome da esposa de Abraão?", "Sara"},
    {"Qual o último livro da Bíblia?", "Apocalipse"},
    {"Quem teve um sonho com uma escada que chegava ao céu?", "Jacó"},
    {"Qual o nome do rei que pediu a cabeça de João Batista?", "Herodes"},
    {"Quem foi o profeta que desafiou os profetas de Baal no Monte Carmelo?", "Elias"},
    {"Qual o nome do discípulo que duvidou da ressurreição de Jesus?", "Tomé"},
    {"Quem escreveu o livro de Salmos em sua maioria?", "Davi"},

    // Difíceis
    {"Qual profeta casou-se com uma mulher adúltera como símbolo do relacionamento de Deus com Israel?", "Oséias"},
    {"Quem foi o rei mais jovem de Judá?", "Joás"},
    {"Qual o nome do servo de Eliseu que ficou leproso?", "Geazi"},
    {"Qual o nome do pai de João Batista?", "Zacarias"},
    {"Quem foi o profeta que teve uma visão de ossos secos?", "Ezequiel"},
    {"Qual o nome do homem que caiu da janela enquanto Paulo pregava?", "Êutico"},
    {"Quem foi a única juíza de Israel mencionada na Bíblia?", "Débora"},
    {"Qual o nome do rei que viu a escrita na parede?", "Belsazar"},
    {"Quem foi o profeta que teve uma visão de um rolo voador?", "Zacarias"},
    {"Qual o nome do homem que ajudou Jesus a carregar a cruz?", "Simão Cireneu"},

    {"Qual o nome do filho de Abraão com Agar?", "Ismael"},
    {"Quem foi o sucessor de Moisés?", "Josué"},
    {"Qual o nome da cidade onde Jesus nasceu?", "Belém"},
    {"Quem batizou Jesus?", "João Batista"},
    {"Qual o nome do apóstolo conhecido por ser médico?", "Lucas"},
    {"Quem foi o primeiro rei de Israel?", "Saul"},
    {"Qual o nome da mulher que se tornou rainha e salvou os judeus?", "Ester"},
    {"Qual o nome do monte onde Moisés recebeu os Dez Mandamentos?", "Monte Sinai"},
    {"Quem foi o pai de Davi?", "Jessé"},
    {"Qual o nome do discípulo que era irmão de Pedro?", "André"},
    {"Quem foi o profeta que subiu ao céu num redemoinho?", "Elias"},
    {"Qual o nome do homem que viu uma escada com anjos subindo e descendo?", "Jacó"},
    {"Quem escreveu o livro de Lamentações?", "Jeremias"},
    {"Qual o nome do rei que construiu o templo em Jerusalém?", "Salomão"},
    {"Quem foi o profeta que confrontou o rei Davi sobre seu pecado com Bate-Seba?", "Natã"},

};

Random random = new Random();


Console.Clear();
MostrarAberturaPrograma();
Console.WriteLine("\n");
Console.Clear();

while (true)
{

    int numeroAleatorioPergunta = random.Next(0, perguntasRespostas.Count);
    KeyValuePair<string, string> perguntaAleatoria = perguntasRespostas.ElementAt(numeroAleatorioPergunta);

    Console.Write($"{perguntaAleatoria.Key} ");
    string respostaUsuario = Console.ReadLine()!;

    string resposta = perguntaAleatoria.Value;
    if (respostaUsuario.Equals(resposta))
    {
        Console.WriteLine(@"✅");
        Console.WriteLine("Resposta correta!");
    }
    else
    {
        Console.WriteLine(@"❌");
        Console.WriteLine("Resposta incorreta");
    }
    Console.WriteLine();
    Console.Write("Deseja responder outra pergunta? (S/N): ");
    string opcaoMenu = Console.ReadLine()!;
    opcaoMenu = opcaoMenu.ToLower();

    switch (opcaoMenu)
    {
        case "s":
            continue;
        case "n":
            break;
        default:
            Console.WriteLine("Opção inválida");
            continue;
    }

    Console.WriteLine("...");
    Thread.Sleep(2000);
    Console.Clear();
    MostarEncerramentoPrograma();

}

void MostrarAberturaPrograma()
{

    MostrarLogo();

    Console.WriteLine("Quiz de perguntas e respostas");

    Console.WriteLine("Vamos iniciar? ");
    Thread.Sleep(2000);
    Console.WriteLine("Digite qualquer tecla para iniciar ");
    Console.ReadKey();
    Console.WriteLine("...");
}

void MostrarLogo()
{
    Console.WriteLine(@"
───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────
─██████████████───██████──██████─██████████─██████████████████────██████████████───██████████─██████████████───██████─────────██████████─██████████████─██████████████─
─██░░░░░░░░░░██───██░░██──██░░██─██░░░░░░██─██░░░░░░░░░░░░░░██────██░░░░░░░░░░██───██░░░░░░██─██░░░░░░░░░░██───██░░██─────────██░░░░░░██─██░░░░░░░░░░██─██░░░░░░░░░░██─
─██░░██████░░██───██░░██──██░░██─████░░████─████████████░░░░██────██░░██████░░██───████░░████─██░░██████░░██───██░░██─────────████░░████─██░░██████████─██░░██████░░██─
─██░░██──██░░██───██░░██──██░░██───██░░██───────────████░░████────██░░██──██░░██─────██░░██───██░░██──██░░██───██░░██───────────██░░██───██░░██─────────██░░██──██░░██─
─██░░██──██░░██───██░░██──██░░██───██░░██─────────████░░████──────██░░██████░░████───██░░██───██░░██████░░████─██░░██───────────██░░██───██░░██─────────██░░██──██░░██─
─██░░██──██░░██───██░░██──██░░██───██░░██───────████░░████────────██░░░░░░░░░░░░██───██░░██───██░░░░░░░░░░░░██─██░░██───────────██░░██───██░░██─────────██░░██──██░░██─
─██░░██──██░░██───██░░██──██░░██───██░░██─────████░░████──────────██░░████████░░██───██░░██───██░░████████░░██─██░░██───────────██░░██───██░░██─────────██░░██──██░░██─
─██░░██──██░░██───██░░██──██░░██───██░░██───████░░████────────────██░░██────██░░██───██░░██───██░░██────██░░██─██░░██───────────██░░██───██░░██─────────██░░██──██░░██─
─██░░██████░░████─██░░██████░░██─████░░████─██░░░░████████████────██░░████████░░██─████░░████─██░░████████░░██─██░░██████████─████░░████─██░░██████████─██░░██████░░██─
─██░░░░░░░░░░░░██─██░░░░░░░░░░██─██░░░░░░██─██░░░░░░░░░░░░░░██────██░░░░░░░░░░░░██─██░░░░░░██─██░░░░░░░░░░░░██─██░░░░░░░░░░██─██░░░░░░██─██░░░░░░░░░░██─██░░░░░░░░░░██─
─████████████████─██████████████─██████████─██████████████████────████████████████─██████████─████████████████─██████████████─██████████─██████████████─██████████████─
───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");

}

void MostrarAutor()
{
    Console.WriteLine(@"B⃨y⃨ A⃨l⃨l⃨a⃨n⃨ S⃨a⃨n⃨t⃨o⃨s⃨");
}

void MostarEncerramentoPrograma()
{
    Console.WriteLine(@"
───────────────────────────────────────────────────────────────────────────────────
─██████████████─██████████████─██████──██████─██████████████─██████──██████─██████─
─██░░░░░░░░░░██─██░░░░░░░░░░██─██░░██──██░░██─██░░░░░░░░░░██─██░░██──██░░██─██░░██─
─██████░░██████─██░░██████████─██░░██──██░░██─██░░██████░░██─██░░██──██░░██─██░░██─
─────██░░██─────██░░██─────────██░░██──██░░██─██░░██──██░░██─██░░██──██░░██─██░░██─
─────██░░██─────██░░██─────────██░░██████░░██─██░░██████░░██─██░░██──██░░██─██░░██─
─────██░░██─────██░░██─────────██░░░░░░░░░░██─██░░░░░░░░░░██─██░░██──██░░██─██░░██─
─────██░░██─────██░░██─────────██░░██████░░██─██░░██████░░██─██░░██──██░░██─██████─
─────██░░██─────██░░██─────────██░░██──██░░██─██░░██──██░░██─██░░██──██░░██────────
─────██░░██─────██░░██████████─██░░██──██░░██─██░░██──██░░██─██░░██████░░██─██████─
─────██░░██─────██░░░░░░░░░░██─██░░██──██░░██─██░░██──██░░██─██░░░░░░░░░░██─██░░██─
─────██████─────██████████████─██████──██████─██████──██████─██████████████─██████─
───────────────────────────────────────────────────────────────────────────────────");
}