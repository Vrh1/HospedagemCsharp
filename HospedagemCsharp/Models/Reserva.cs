using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospedagemCsharp.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes (List<Pessoa> hospedes)
        {
            // Verificar se a capacidade é maior ou igual ao número de hóspeedes sendo recebido
            if (Suite.Capacidade > hospedes.Capacity)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception($"Número de hospedes é maior que a capacidade do quarto");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;
            if (DiasReservados >= 10)
            {
                valor = valor * 10 / 100 ;
            }

            return valor;
        }
    }
}
