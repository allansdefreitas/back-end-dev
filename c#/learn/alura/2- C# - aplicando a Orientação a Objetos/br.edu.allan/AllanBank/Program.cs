// See https://aka.ms/new-console-template for more information
Console.Clear();


Account account= new Account();

account.NumeroIndicador = 123;
account.Titular = "Allan";
account.Saldo = 10000;
account.Senha = "12345";

account.ExibirDadosConta();