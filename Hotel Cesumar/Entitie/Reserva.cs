using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Cesumar.Entitie
{
    class Reserva
    {
        public List<Hospede> Hospedes { get; private set; }
        public Suite Suite { get; private set; }
        public int QuantidadePessoas { get; private set; }
        public int QuantidadesDias { get; private set; }
        
        public Reserva()
        {

        }
    
    
    }
}
