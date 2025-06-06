using GerenciadorArquivos.Modelos;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Arquivo arquivo = new Arquivo();
        arquivo.NomeArquivo = "file.txt";

        arquivo.Salvar();
        arquivo.Recuperar();

        BancoDeDados bancoDeDados = new BancoDeDados();
        bancoDeDados.NomeBanco = "postgresql_db";
        bancoDeDados.Salvar();
        bancoDeDados.Recuperar();
    }
}