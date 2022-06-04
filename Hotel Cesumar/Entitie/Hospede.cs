using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Cesumar.Entitie
{
    public class Hospede
    {
        public int Codigo { get; private set; }
        public int Nome { get; private set; }
        public int Endereco { get; private set; }
        public int Idade { get; private set; }

        public Hospede()
        {

        }
       public void GetIdade(int idade)
        {
            this.Idade = idade;
        }
    }
}
