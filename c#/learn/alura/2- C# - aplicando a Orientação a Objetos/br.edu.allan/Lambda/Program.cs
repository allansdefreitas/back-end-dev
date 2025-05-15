
// Sem lambda ======================================
List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// O FindAll filtra elementos da lista com base numa condição (predicado), dada pela função fornecida como argumento
// O FindAll só adiciona à lista elementos que fazem a função 'BuscarNumerosQueSaoPares' retornar true.
List<int> numerosPares = numeros.FindAll(BuscarNumerosQueSaoPares);


// É função usada como filtro
bool BuscarNumerosQueSaoPares(int numero)
{
    return numero % 2 == 0;
}

foreach (int numero in numerosPares)
{
    Console.WriteLine(numero);
}

// Com lambda ======================================
numerosPares = numeros.FindAll(numero => numero % 2 == 0);

numerosPares.ForEach(numero => Console.WriteLine(numero));