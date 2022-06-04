using System;
using System.Collections.Generic;

namespace Hotel_Cesumar.Entitie
{
    public class Reserva
    {
        public List<Hospede> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int QuantidadePessoas { get; set; }
        public int QuantidadeDias { get; set; }


        public int VerificarIdade()
        {
            int soma = 0;
            foreach (Hospede hospede in Hospedes)
            {
                if (hospede.Idade <= 2)
                {
                    soma += 1;
                }

            }
            return soma;
        }
        public bool VerificarCapacidade()
        {

            int pessoas = QuantidadePessoas - VerificarIdade();
            if (pessoas <= Suite.Capacidade)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public double CalcularDiaria()
        {
            double q = Suite.ValorDiaria * QuantidadeDias;
            if (QuantidadeDias > 7)
            {
                double q1 = q * 0.1;
                return q - q1;
            }



            return q;
        }

        public string ReservarSuite()
        {
            bool avaliar = VerificarCapacidade();
            if (avaliar == true)
            {
                return "Valor da RESERVA: R$" + CalcularDiaria();
            }
            return ("INFELIZMENTE! Não foi possível fazer sua RESERVA.");
        }

        public int GetQuantidadePessoas()
        {
            return Hospedes.Count;
        }

    }
}
