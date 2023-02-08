using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,,] computations = new double[3, 3, 3];

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    for (int z = 0; z < 3; z++)
                    {
                        computations[x, y, z] = x + y + z;
                    }
                }
            }
        }
    }
}
