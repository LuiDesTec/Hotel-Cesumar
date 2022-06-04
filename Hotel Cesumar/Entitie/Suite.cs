using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Cesumar.Entitie
{
    public class Suite
    {
        public int Numero { get;  private set; }
        public string Tipo { get;  set; }
        public int Capacidade { get;  private set; }
        public double Valor { get;  private set; }

        public Suite()
        {

        }
        public void SetCapacidade(int capacidade)
        {

            this.Capacidade = capacidade;
        }

        public void SetValorDiaria(double valor)
        {

            this.Valor = valor;
        }

    }
}
