using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorArquivos.Modelos;

public class Arquivo : IArmazenavel
{
    public string NomeArquivo { get; set; }

    public void Salvar()
    {
        Console.WriteLine($"Salvando dados no arquivo {NomeArquivo}.");
    }

    public void Recuperar()
    {
        Console.WriteLine($"Recuperando dados do arquivo {NomeArquivo}.");
    }
}