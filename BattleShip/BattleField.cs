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
        public string[,] GridSpace;

        public BattleField(int _enemyRow, int _enemyColumn, string[,] grid)
        {
            EnemyRow = _enemyRow;
            EnemyColumnOne = _enemyColumn++;
            EnemyColumnTwo = _enemyColumn++;
            EnemyColumnThree = _enemyColumn++;
            EnemyColumnFour = _enemyColumn++;
            EnemyColumnFive = _enemyColumn++;
            GridSpace = grid;
            Cannons = 8;
            EnemyLife = 5;
    }

        public void drawBoard()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   0 1 2 3 4 5 6 7 8 9 ");
            Console.WriteLine("  =====================");
            for (int i = 0; i < GridSpace.GetLength(0); i++)
            {
                Console.Write("{0}| ", i);
                for (int j = 0; j < GridSpace.GetLength(1); j++)
                {
                    Console.Write( "{0} ",GridSpace[i, j]);
                }
                Console.WriteLine("| ");
            }
            Console.WriteLine("  =====================");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nCannons Left: {0} ", Cannons);
            Console.WriteLine("Enemy Life: {0}\n", EnemyLife);          
        }

        public void checkLocation(int cannonColumn, int cannonRow)
        {
            
            if(GridSpace[cannonRow, cannonColumn] == "-")
            {
                hitCheck(cannonColumn, cannonRow);
            } else
            {
                Console.Clear();
                drawBoard();
                Console.WriteLine("General, you've already fired at this location\n");
            }
        }

        public void hitCheck(int cannonColumn, int cannonRow)
        {
            string shotOutcome;

            if(cannonRow == EnemyRow && (cannonColumn == EnemyColumnOne || cannonColumn == EnemyColumnTwo || cannonColumn == EnemyColumnThree || cannonColumn == EnemyColumnFour || cannonColumn == EnemyColumnFive))
            {
                GridSpace[cannonRow, cannonColumn] = "X";
                EnemyLife--;
                shotOutcome = "hit";
            } else
            {
                GridSpace[cannonRow, cannonColumn] = "O";
                shotOutcome = "missed";
            }

            Cannons--;
            Console.Clear();
            drawBoard();

            Console.WriteLine("General, you {0} the enemy!\n", shotOutcome);
        }

            public static string[,] populateGrid()
        {
            string[,] gridTemplate = new string[10, 10];

            for (int i = 0; i < gridTemplate.GetLength(0); i++)
            {
                for (int j = 0; j < gridTemplate.GetLength(1); j++)
                {
                    gridTemplate[i, j] = "-";
                }
            }

            return gridTemplate;
        }
        public void RunGame()
            {
             Console.Title = "BATTLESHIP FIRE! Find the Enemy";
            
            
        NewGame:
            Console.Clear();

            string[,] grid = populateGrid();
            Random random = new Random();
            int enemyRow = random.Next(0, 10);
            int enemyColumn = random.Next(0, 5);
           
          
            drawBoard();

        Restart:

            try
            {
                Console.Write("General, please designate Row number: ");
                int cannonRow = Convert.ToInt32(Console.ReadLine());
                Console.Write("General, please designate Column number: ");
                int cannonColumn = Convert.ToInt32(Console.ReadLine());
                
                checkLocation(cannonColumn, cannonRow);
   
            }
            catch (Exception e)
            {

                Console.Clear();
               drawBoard();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.WriteLine("Please select a number between 0-9\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto Restart;
            }

            if (Cannons == 0 || EnemyLife == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Game Over!\nPress Y key to play again");
                Console.ForegroundColor = ConsoleColor.White;
                if(Console.ReadKey().Key != ConsoleKey.Y)
                {
                    Console.WriteLine("Pressed {0}\nTill next time, General!", Console.ReadKey().Key);                  
                } else
                {               
                goto NewGame;
                }
                
            }
            else
            {
                    goto Restart;
            }
        }

    
        
    }
}
