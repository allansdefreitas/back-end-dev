Produto produto = new Produto();
produto.Preco = -5;  // Preço inválido, será atribuído 0
Console.WriteLine(produto.Preco); // Saída: 0

produto.Preco = 20;  // Preço válido
Console.WriteLine(produto.Preco); // Saída: 20

Console.Clear();

Estoque estoqueMercadinhoAlfa = new Estoque();
estoqueMercadinhoAlfa.Nome = "Estoque do Mercadinho Alfa";



Produto produtoGranola = new Produto();
produtoGranola.Nome = "Granola sem Glúten";
produtoGranola.Marca = "São Braz";
produtoGranola.Preco = 12.50;

Produto produtoMaca = new Produto();
produtoMaca.Nome = "Maçã Argentina";
produtoMaca.Preco = 2.50;

Produto produtoIogurteNatural = new Produto();
produtoIogurteNatural.Nome = "Iogurte Natural Desnatado";
produtoIogurteNatural.Marca = "Betânia";
produtoIogurteNatural.Preco = 4.55;


estoqueMercadinhoAlfa.AdicionarProduto(produtoGranola);
estoqueMercadinhoAlfa.AdicionarProduto(produtoMaca);
estoqueMercadinhoAlfa.AdicionarProduto(produtoIogurteNatural);

estoqueMercadinhoAlfa.ExibirProdutos();



