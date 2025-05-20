using System;

namespace PetShop.Models;

internal class Medico
{

    public string Nome { get; set; }
    public string Especialidade { get; }
    private List<Consulta> _consultas;


    public Medico(string nome)
    {
        Nome = nome;
        _consultas = new List<Consulta>();
    }

    public Medico(string nome, string especialidade)
    {
        Nome = nome;
        Especialidade = especialidade;
        _consultas = new List<Consulta>();
    }

    public void RealizarConsulta(Consulta consulta)
    {
        _consultas.Add(consulta);
    }

    public void ExibirHistoricoConsultas()
    {
        Console.WriteLine($"Histórico de consultas realizadas por {this.Nome}:\n");
        foreach(var consulta in _consultas)
        {
            DateTime dateOnly = consulta.Data.Date;
            string dataFormatada = dateOnly.ToString("dd/MM/yyyy");

            Console.Write(
            $"Data: {dataFormatada} \n" +
            $"Dono: {consulta.Dono.Nome} \n" +
            $"Pet: {consulta.Pet.Nome} ({consulta.Pet.Raca}) \n" +
            $"Diagnóstico: {consulta.Diagnostico}");
        }
    }


}
