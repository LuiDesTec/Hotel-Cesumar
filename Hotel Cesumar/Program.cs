using Hotel_Cesumar.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Cesumar
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Além da modelagem disponível para implementação, temos também alguns 
requisitos funcionais que são:
1-A reserva não pode alocar mais hóspedes do que a capacidade da suíte.
2-Bebês até 2 anos não contam na capacidade da suíte.
3-Para o cálculo da diária, multiplique o valor da diária da suíte pela 
quantidade de diárias solicitadas.
4-Para um reserva com mais de 7 dias, deverá ser concedido um desconto de 10%*/

            //         SUITE  Com os dados necessários         //
            Suite suite_a = new Suite();
            suite_a.ValorDiaria = 70.00;
            suite_a.Capacidade = 2;

            Suite suite_b = new Suite();
            suite_b.ValorDiaria = 80.00;
            suite_b.Capacidade = 2;

            Suite suite_c = new Suite();
            suite_c.ValorDiaria = 60.00;
            suite_c.Capacidade = 3;

            Suite suite_d = new Suite();
            suite_d.ValorDiaria = 60.00;
            suite_d.Capacidade = 3;

            //         HOSPEDES          //
            Hospede Karolyn = new Hospede();
            Karolyn.Idade = 11;

            Hospede Kevinyn = new Hospede();
            Kevinyn.Idade = 10;

            Hospede Tatiane = new Hospede();
            Tatiane.Idade = 38;

            Hospede Luiz = new Hospede();
            Luiz.Idade = 45;

            Hospede Taila = new Hospede();
            Taila.Idade = 2;

            //Dois hospedes adultos, suíte_a, com capacidade para 2 pessoas.
            // Diária 70 Reais p/ 2 dias(R$140).
            List<Hospede> hospededicenario1 = new List<Hospede>();
            hospededicenario1.Add(Karolyn);
            hospededicenario1.Add(Kevinyn);

            Reserva reserva1 = new Reserva();
            reserva1.Suite = suite_a;
            reserva1.Hospedes = hospededicenario1;
            reserva1.QuantidadeDias = 2;
            reserva1.QuantidadePessoas = 1;

            Console.WriteLine(":  Cenário1 " + reserva1.ReservarSuite());
            Console.WriteLine(": Quantidade de Pessoas " + reserva1.GetQuantidadePessoas());

            //Dois hospedes adultose e um bêbe suíte_b, com capacidade para 2 pessoas.
            // Diária 80 Reais p/ 2 dias(R$160).
            List<Hospede> hospededicenario2 = new List<Hospede>();
            hospededicenario2.Add(Karolyn);
            hospededicenario2.Add(Kevinyn);
            hospededicenario2.Add(Taila);

            Reserva reserva2 = new Reserva();
            reserva2.Suite = suite_b;
            reserva2.Hospedes = hospededicenario2;
            reserva2.QuantidadeDias = 2;
            reserva1.QuantidadePessoas = 1;

            Console.WriteLine(":  Cenário2 " + reserva2.ReservarSuite());
            Console.WriteLine(": Quantidade de Pessoas " + reserva2.GetQuantidadePessoas());

            //Quatro hospedes adultos  suíte_c, com capacidade para 3 pessoas. EXCEDE!
            // Diária 60 Reais p/ 2 dias(R$240).
            List<Hospede> hospededicenario3 = new List<Hospede>();
            hospededicenario3.Add(Karolyn);
            hospededicenario3.Add(Kevinyn);
            hospededicenario3.Add(Tatiane);
            hospededicenario3.Add(Luiz);

            Reserva reserva3 = new Reserva();
            reserva3.Suite = suite_c;
            reserva3.Hospedes = hospededicenario3;
            reserva3.QuantidadeDias = 4;
            reserva3.QuantidadePessoas = 4;

            Console.WriteLine(": Cenário3 " + reserva3.ReservarSuite());
            Console.WriteLine(": Quantidade de Pessoas " + reserva3.GetQuantidadePessoas());

            //Dois hospedes adultose e um bêbe suíte_b, com capacidade para 4 pessoas.
            // Diária 80 Reais p/ 2 dias(R$486).
            List<Hospede> hospededicenario4 = new List<Hospede>();
            hospededicenario4.Add(Karolyn);
            hospededicenario4.Add(Kevinyn);
            hospededicenario4.Add(Luiz);



            Reserva reserva4 = new Reserva();
            reserva4.Suite = suite_d;
            reserva4.Hospedes = hospededicenario4;
            reserva4.QuantidadeDias = 9;
            reserva1.QuantidadePessoas = 1;

            Console.WriteLine(":  Cenário4: " + reserva4.ReservarSuite());
            Console.WriteLine(": Quantidade de Pessoas " + reserva4.GetQuantidadePessoas());
        }

    }

}
    

