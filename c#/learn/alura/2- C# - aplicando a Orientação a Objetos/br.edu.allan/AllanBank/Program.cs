// See https://aka.ms/new-console-template for more information
Console.Clear();


Account account= new Account();

account.numeroIndicador = 123;
account.titular = "Allan";
account.saldo = 10000;
account.senha = "12345";

account.ExibirDadosConta();