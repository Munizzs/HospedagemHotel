using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioHospedagem.models
{
    public class Reserva
    {
        private List<Pessoa> Hospedes { get; set; }
        private Suite Suite { get; set; }
        private int DiasReservados { get; set; }

        public Reserva() 
        {

        }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
            Hospedes = new List<Pessoa>();
        }

        public void CadastrarHospedes(Pessoa pessoa)
        {
            Hospedes.Add(pessoa);
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
                if(Hospedes.Count()>=0 && Hospedes.Count()<=Suite.Capacidade)
                {
                    return Hospedes.Count();
                }else
                {
                    return -1;
                }        
        }

        public decimal CalcularValorDiaria()
        {
            Decimal valor = Suite.ValorDiaria * DiasReservados;

             if (DiasReservados >= 10)
            {
                return valor - (valor * 0.1M);
            }
            else
            {
                return valor;
            }
        }

    }
}