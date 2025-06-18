internal class Program
{
    private static void Main(string[] args)
    {

        // Usando LINQ  ==============================================================================================

        /* Dada uma lista de números, criar uma consulta LINQ para retornar apenas os elementos únicos da lista.
         */
        List<int> numeros = new List<int> { 1, 2, 3, 2, 4, 5, 3, 6, 7, 8, 9, 1 };

        var numerosUnicos = numeros.Distinct();

        Console.WriteLine("Números únicos na lista:");
        foreach (var numero in numerosUnicos)
        {
            Console.Write(numero + " ");
        }

        /* Dadas duas listas de números, criar uma consulta LINQ para retornar uma lista que 
         * contenha apenas os números que estão presentes em ambas as listas.*/

        List<int> lista1 = new List<int> { 1, 2, 3, 4, 5 };
        List<int> lista2 = new List<int> { 3, 4, 5, 6, 7 };

        var numerosComuns = lista1.Intersect(lista2);

        Console.WriteLine("Números presentes em ambas as listas:");
        foreach (var numero in numerosComuns)
        {
            Console.Write(numero + " ");
        }

        /* Dada uma lista de livros com título, autor e ano de publicação, criar uma consulta LINQ 
         * para retornar uma lista com os títulos dos livros publicados após o ano 2000, ordenados alfabeticamente.*/

        List<Livro> livros = new List<Livro>
        {
            new Livro { Titulo = "Aprendendo LINQ", Autor = "João Silva", AnoPublicacao = 2005 },
            new Livro { Titulo = "Programação em C#", Autor = "Ana Oliveira", AnoPublicacao = 2010 },
            new Livro { Titulo = "Algoritmos e Estruturas de Dados", Autor = "Carlos Santos", AnoPublicacao = 1998 },
            new Livro { Titulo = "Introdução à Inteligência Artificial", Autor = "Mariana Costa", AnoPublicacao = 2021 },
            new Livro { Titulo = "Design Patterns", Autor = "Paulo Rocha", AnoPublicacao = 2002 }
        };

        var titulosLivrosPublicadosAposAno2000 = livros
            .Where(livro => livro.AnoPublicacao > 2000)
            .OrderBy(livro => livro.Titulo)
            .Select(livro => livro.Titulo)
            .ToList();

        Console.WriteLine("Títulos de livros publicados após 2000, ordenados alfabeticamente:");
        foreach (var titulo in titulosLivrosPublicadosAposAno2000)
        {
            Console.WriteLine(titulo);
        }

        /* Dada uma lista de produtos com nome e preço, criar uma consulta LINQ para calcular o preço médio dos produtos. */
        List<Produto> produtos = new List<Produto>
        {
            new Produto { Nome = "Laptop", Preco = 1200 },
            new Produto { Nome = "Smartphone", Preco = 800 },
            new Produto { Nome = "Tablet", Preco = 500 },
            new Produto { Nome = "Câmera", Preco = 300 }
        };

        var precoMedio = produtos.Average(produto => produto.Preco);
        Console.WriteLine("Preço médio dos produtos: " + precoMedio);

        /* Dada uma lista de strings, criar uma consulta LINQ para ordenar as palavras por 
         * comprimento e retornar apenas aquelas que têm mais de 3 caracteres. */
        
        List<string> palavras = new List<string> { "cachorro", "gato", "elefante", "leão", "cobra" };

        var palavrasFiltradas = palavras
            .Where(palavra => palavra.Length > 3)
            .OrderBy(palavra => palavra.Length)
            .ToList();

        Console.WriteLine("Palavras com mais de 3 caracteres, ordenadas por comprimento:");
        foreach (var palavra in palavrasFiltradas)
        {
            Console.Write(palavra + " ");
        }

        /* Dada uma lista de inteiros, criar uma consulta LINQ para retornar apenas os números pares. */
        List<int> numerosInteiros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var numerosPares = numerosInteiros
            .Where(numero => numero % 2 == 0);

        Console.WriteLine("Números Pares:");
        foreach (var numero in numerosPares)
        {
            Console.Write(numero + " ");
        }

    }



}

class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }
}

class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}