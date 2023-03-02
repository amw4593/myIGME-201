using System;

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
        private EAliveState aliveState;
        public EInfectedState infectedState;

        public EAliveState AliveState
        {
            get
            {
                return aliveState;
            }
            set
            {
                this.aliveState = value;

                if (this.aliveState == EAliveState.dead)
                {
                    this.infectedState = EInfectedState.organic;
                }
            }
        }
    }

    public class Cell
    {
        const int MAX_VIRUSES = 50;
        const int MAX_VACCINES = 50;

        public static int nViruses;
        public static int nVaccines;

        public static int MAX_NEIGHBORS = Enum.GetNames(typeof(EDirection)).Length;

        public Cell[] neighbor = new Cell[MAX_NEIGHBORS];
        public Cell nextCell;

        public StructCellState currentCellState;
        public StructCellState nextCellState;

        static Random rand = new Random();
        
        public Cell(int maxCells, int probability = 4) 
        {
            currentCellState.infectedState = EInfectedState.organic;
            currentCellState.AliveState = EAliveState.dead;

            probability = rand.Next(0, probability);

            if(probability == 0)
            {
                currentCellState.AliveState = EAliveState.alive;

                if(nViruses < MAX_VIRUSES)
                {
                    if(rand.Next(0, maxCells) < maxCells / MAX_VIRUSES)
                    {
                        currentCellState.infectedState = EInfectedState.infected;
                        ++nViruses;
                    }
                }
                if(currentCellState.infectedState == EInfectedState.organic && nVaccines < MAX_VACCINES)
                {
                    if (rand.Next(0, maxCells) < maxCells / MAX_VACCINES)
                    {
                        currentCellState.infectedState = EInfectedState.vaccinated;
                        ++nVaccines;
                    }
                }
            }
        }
        public void SetNextState()
        {
            int nAlive = 0;
            int nInfected = 0;
            int nVaccinated = 0;
            int cntr = 0;

            for (cntr = 0; cntr < MAX_NEIGHBORS; ++cntr)
            {
                Cell neighborCell = this.neighbor[cntr];

                if (neighborCell != null)
                {
                    if (neighborCell.currentCellState.infectedState == EInfectedState.infected)
                    {
                        ++nInfected;
                    }
                    if (neighborCell.currentCellState.infectedState == EInfectedState.vaccinated)
                    {
                        ++nVaccinated;
                    }
                    if (neighborCell.currentCellState.AliveState == EAliveState.alive)
                    {
                        ++nAlive;
                    }
                }
            }
            nextCellState.infectedState = currentCellState.infectedState;
            nextCellState.AliveState = currentCellState.AliveState;

            if (nAlive < 2 || nAlive > 3)
            {
                nextCellState.AliveState = EAliveState.dead;
            }
            else
            {
                if (nAlive == 3)
                {
                    nextCellState.AliveState = EAliveState.alive;
                }
            }
            if (currentCellState.AliveState == EAliveState.alive && nextCellState.AliveState == EAliveState.alive)
            {
                if (nInfected > 0 && nInfected > nVaccinated && nextCellState.infectedState != EInfectedState.vaccinated)
                {
                    nextCellState.infectedState = EInfectedState.infected;
                }
                else if (nVaccinated > 0)
                {
                    nextCellState.infectedState = EInfectedState.vaccinated;
                }
            }
        }
    }
    static internal class Program
    {
        public static int MAX_ROWS = 30;
        public static int MAX_COLS = 80;

        public static Cell[,] organism = new Cell[MAX_ROWS, MAX_COLS];

        public static bool bExit = false;
        static void Main(string[] args)
        {
            MyMethod();

            for(int row = 0; row < MAX_ROWS; row++)
            {
                for(int col = 0; col < MAX_COLS; col++)
                {
                    for( int cntr = 0; cntr < Cell.MAX_NEIGHBORS; cntr++)
                    {
                        Cell neighborCell = null;

                        switch (cntr)
                        {
                            case (int)EDirection.right:
                                if(col < MAX_COLS - 1)
                                {
                                    neighborCell = organism[row, col + 1];
                                    organism[row, col].nextCell = organism[row, col + 1];
                                }
                                else if (row < MAX_ROWS - 1)
                                {
                                    organism[row, col].nextCell = organism[row + 1, col];
                                }
                                break;
                        }
                    }
                }
            }

        }
        static void MyMethod()
        {

        }
    }
}
