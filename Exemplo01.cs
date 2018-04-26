using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosVetorComFor
{
    public class Exemplo01
    {
        public Exemplo01()
        {
            string[] mortesDoFilme = new string[5];
            // forma old
            // mortesDoFilme[0] = "tony Stark";

            // ARMAZENA AS INFORMAÇÔES NO VETOR
            for (int i = 0; 1 < mortesDoFilme.Length; i++)
            {
                Console.Write("Digite o nome dapessoa que morre no filme: ");
                mortesDoFilme[i] = Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine("Pessoas Cadastradas: ");
            // APRESENTA AS INFORMAÇÔES DO VETOR
            for (int i = 0; i < mortesDoFilme.Length; i++)
            {
                Console.WriteLine("Nome: " + mortesDoFilme[i]);
            }

        }
    }
}
