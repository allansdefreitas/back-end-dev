// See https://aka.ms/new-console-template for more information
Console.Clear();


Account account = new Account();
Titular titularAllan = new Titular();
titularAllan.Nome = "Allan";

account.NumeroIndicador = 123;

account.Titular = titularAllan;
account.Saldo = 10000;
account.Senha = "12345";

account.ExibirDadosConta();