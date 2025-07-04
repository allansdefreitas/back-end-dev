﻿
namespace ControleAcessoPredio.Modelos;

internal class Visitante : IResumoAcesso
{

    public string Nome { get; }
    public string Documento { get; }
    public string Sala { get; }

    public string Resumo => $"Visita de {Nome}, doc nº {Documento}, à sala {Sala}";
    
    public Visitante(string nome, string documento, string sala)
    {
        Nome = nome;
        Documento = documento;
        Sala = sala;
    }
}