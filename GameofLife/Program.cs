using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameofLife
{
    public enum EAliveState
    {
        alive, 
        dead
    }

    public enum EInfectedState
    {
        organic, 
        vaccinated, 
        infected
    }

    public enum EDirection
    {
        right,
        down, 
        left, 
        up, 
        topLeft,
        topRight,
        bottomLeft,
        bottomRight
    }

    public struct StructCellState
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
