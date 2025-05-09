
Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 101); // Get a random number between 1 and 100
int numeroTentativas = 0;

do
{
    Console.Write("Digite um número entre 1 e 100: ");
    int chute = int.Parse(Console.ReadLine());
    numeroTentativas++;

    if (chute == numeroSecreto)
    {
        Console.WriteLine("Parabéns! Você acertou o número com {0} tentativas", numeroTentativas);
        break;
    }
    else if (chute < numeroSecreto)
    {
        Console.WriteLine("O número é maior.");
    }
    else
    {
        Console.WriteLine("O número é menor.");
    }

} while (true);

Console.WriteLine("O jogo acabou. Você acertou o número secreto!");