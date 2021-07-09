using System;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "BATTLESHIP FIRE! Find the Enemy";
            
        NewGame:
            Console.Clear();

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
   
            }
            catch (Exception e)
            {

                Console.Clear();
                gameBoard.drawBoard();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.WriteLine("Please select a number between 0-9\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto Restart;
            }

            if (gameBoard.Cannons == 0 || gameBoard.EnemyLife == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Press Y key to play again");
                Console.ForegroundColor = ConsoleColor.White;
                if(Console.ReadKey().Key != ConsoleKey.Y)
                {
                    Console.WriteLine("Pressed {0}\nTill next time General!", Console.ReadKey().Key);                  
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
