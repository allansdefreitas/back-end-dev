Produto produto = new Produto();
produto.Preco = -5;  // Preço inválido, será atribuído 0
Console.WriteLine(produto.Preco); // Saída: 0

produto.Preco = 20;  // Preço válido
Console.WriteLine(produto.Preco); // Saída: 20
