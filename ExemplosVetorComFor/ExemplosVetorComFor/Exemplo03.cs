using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosVetorComFor
{
    public class Exemplo03
    {
        public Exemplo03() 
        {
            Console.Write("Digite a quantidade de registros que deseja cadastrar: ");
            int quantidadeRegistros = Convert.ToInt32(Console.ReadLine());

            string[] fazendas = new string[quantidadeRegistros];
            int[] quantidadePorcos = new int[quantidadeRegistros];

            for (int i = 0; i < fazendas.Length; i++)
            {
                Console.Write("Nome da Fazenda: ");
                fazendas[i] = Console.ReadLine();
                Console.Write("Quntidade de suínos: ");
                quantidadePorcos[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Fazenda com a maior qauntidade de suínos
            int maiorQuantidadeSuinos = int.MinValue;
            string fazendaMaiorQuantidadeSuinos = "";
            for (int i = 0; i < quantidadePorcos.Length; i++)
            {
                if (quantidadePorcos[i] > maiorQuantidadeSuinos)
                {
                    maiorQuantidadeSuinos = quantidadePorcos[i];
                    fazendaMaiorQuantidadeSuinos = fazendas[i];
                }

            }

            Console.WriteLine(
                 "FAZENDA COM A MAIOR QUANTIDADE DE SUÌNOS: " +
                  fazendaMaiorQuantidadeSuinos + " Contém " + 
                  maiorQuantidadeSuinos);

            // Fazenda como enor nome
            string menorNome = "";
            for (int i = 0; i < 1000; i++)
            {
                if (i % 2 == 0)
                {
                    menorNome = menorNome + "a";
                }
                else
                {
                    menorNome = menorNome + "e";
                }
            }
        }
    }
}
