﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaAuto.Modelos
{
    public class Veiculo : IPilotavel, IVoavel
    {

        public string Marca { get; }

        public string Modelo { get; }

        public int Ano { get; }

        public string Placa { get; }

        public Proprietario Proprietario { get; }


        public Veiculo(string marca, string modelo, int ano, Proprietario proprietario) { 
        
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Proprietario = proprietario;

            proprietario.AdquirirVeiculo(this);
        
        }

        public void Pilotar()
        {
            Console.WriteLine($"Veículo {this.Marca} está pilotando");
        }

        public void Voar()
        {
            Console.WriteLine($"Veículo {this.Modelo} está voando");
        }
    }
}
