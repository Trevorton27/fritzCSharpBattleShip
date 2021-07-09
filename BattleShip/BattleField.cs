using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class BattleField
    {
        public int EnemyRow;
        public int EnemyColumnOne;
        public int EnemyColumnTwo;
        public int EnemyColumnThree;
        public int EnemyColumnFour;
        public int EnemyColumnFive;
        public int Cannons;
        public int EnemyLife;
        public string[,] gridSpace;

        public BattleField(int _enemyRow, int _enemyColumn, string[,] gridTemp)
        {
            EnemyRow = _enemyRow;
            EnemyColumnOne = _enemyColumn++;
            EnemyColumnTwo = _enemyColumn++;
            EnemyColumnThree = _enemyColumn++;
            EnemyColumnFour = _enemyColumn++;
            EnemyColumnFive = _enemyColumn++;
            gridSpace = gridTemp;
            Cannons = 8;
            EnemyLife = 5;
    }


        public void drawBoard()
        {
            
            Console.WriteLine("  0 1 2 3 4 5 6 7 8 9 ");
            Console.WriteLine(" =====================");
            for (int i = 0; i < gridSpace.GetLength(0); i++)
            {
                Console.Write("| ");
                for (int j = 0; j < gridSpace.GetLength(1); j++)
                {
                    Console.Write( "{0} ",gridSpace[i, j]);
                }
                Console.WriteLine("|{0} ", i);
            }
            Console.WriteLine(" =====================");

            Console.WriteLine("\nCannons Left: {0}", Cannons);
            Console.WriteLine("Enemy Life: {0}\n", EnemyLife);
        }

        public void checkLocation(int cannonColumn, int cannonRow)
        {
            
            if(gridSpace[cannonRow, cannonColumn] == "-")
            {
                hitCheck(cannonColumn, cannonRow);
            } else
            {
                Console.Clear();
                drawBoard();
                Console.WriteLine("General You've already fired at this location\n");
            }
        }

        public void hitCheck(int cannonColumn, int cannonRow)
        {
            string shotOutcome;

            if(cannonRow == EnemyRow && (cannonColumn == EnemyColumnOne || cannonColumn == EnemyColumnTwo || cannonColumn == EnemyColumnThree || cannonColumn == EnemyColumnFour || cannonColumn == EnemyColumnFive))
            {
                gridSpace[cannonRow, cannonColumn] = "X";
                EnemyLife--;
                shotOutcome = "hit";
            } else
            {
                gridSpace[cannonRow, cannonColumn] = "O";
                shotOutcome = "missed";
            }

            Cannons--;
            Console.WriteLine(this.EnemyRow);
            Console.WriteLine(this.EnemyColumnFour);
            Console.Clear();
            drawBoard();

            Console.WriteLine("General you {0} the ship\n", shotOutcome);
        }
    }
}
