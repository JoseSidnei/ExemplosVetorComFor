using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosVetorComFor
{
    public class Exemplo02
    {
        public Exemplo02()
        {
            int[] levelNoLOL = new int[3];
            // preenche o vetor
            for (int i = 0; i < levelNoLOL.Length; i++)
            {
                Console.Write("Digiteo seu level no LOL: ");
                levelNoLOL[i] = Convert.ToInt32(Console.ReadLine());
            }

            // soma todos os valores contidos no vetor
            // para posteriormente poder realizar a média
            int somaLevels = 0;

            for (int i = 0; i < levelNoLOL.Length; i++)
            {
                 somaLevels = levelNoLOL[i] + somaLevels;
            }

            double mediaLevel = somaLevels / levelNoLOL.Length;
            Console.WriteLine("Média: " + mediaLevel);
        }
    }
}
