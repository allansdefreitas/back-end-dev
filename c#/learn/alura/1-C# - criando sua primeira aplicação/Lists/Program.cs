﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


for (int i = 0; i < numeros.Count; i++)
{
    if (numeros[i] % 2 == 0) // Verifica se o número é par
    {
        Console.WriteLine(numeros[i]);
    }
}


foreach (int numero in numeros)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine(numero);
    }
}