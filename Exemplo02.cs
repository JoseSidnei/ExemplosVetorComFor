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
            int[] levelNoLOL = new int[5];
            for (int i = 0; i < levelNoLOL.Length; i++)
            {
                Console.Write("Digiteo seu level no LOL: ");
                levelNoLOL[i] = Convert.ToInt32(Console.ReadLine());
            }

            int somaLevels = 0;

            for (int i = 0; i < levelNoLOL.Length; i++)
            {
                 somaLevels = levelNoLOL[i] + somaLevels;
            }

            double mediaLevel = somaLevels / levelNoLOL.Length;
        }
    }
}
