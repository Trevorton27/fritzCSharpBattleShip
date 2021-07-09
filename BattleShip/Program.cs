using System;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "FIRE! Find the Enemy";
           
        NewGame:

            string[,] freshGrid = populateGrid();
            Random random = new Random();
            int enemyRow = random.Next(0, 10);
            int enemyColumn = random.Next(0, 5);
           
            BattleField gameBoard = new BattleField(enemyRow, enemyColumn, freshGrid);


            gameBoard.drawBoard();

        Restart:

            try
            {
                Console.Write("General please designate Row: ");
                int cannonRow = Convert.ToInt32(Console.ReadLine());
                Console.Write("General please designate Column: ");
                int cannonColumn = Convert.ToInt32(Console.ReadLine());
                
                gameBoard.checkLocation(cannonColumn, cannonRow);
              
                Console.WriteLine("you choose {0} and {1} as the number", cannonColumn, cannonRow);

            if (gameBoard.Cannons == 0)
            {
                Console.WriteLine("gameover you lose");
                    Console.Clear();
                    goto NewGame;
            }
            else if (gameBoard.EnemyLife == 0)
            {
                Console.WriteLine("gamveover you win");
                    Console.Clear();
                    goto NewGame;
            }
            else
            {
                    goto Restart;
            }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                goto Restart;
            }

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


    }
}
