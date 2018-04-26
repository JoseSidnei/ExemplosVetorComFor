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

        }
    }
}
