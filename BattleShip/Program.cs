using System;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "FIRE! Find the Enemy";

        NewGame:

            string[,] gridTemp = createGrid();

            // var outCome;

            //Random random = new Random();
            //int xLocation = random.Next(0, 5);
            //int yLocation = random.Next(0, 10);

            //make grid with the same loop
            //add grid values to battlegrid for constructor


            BattleGrid grid = new BattleGrid(gridTemp);
            grid.drawGrid();
            

        Restart:

            try
            {
                
                Console.Write("Please input a number for y-axis: ");
                int numberInputY = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please input a number for x-axis: ");
                int numberInputX = Convert.ToInt32(Console.ReadLine());
                
                grid.checkLocation(numberInputX, numberInputY);
              
                Console.WriteLine("you choose {0} and {1} as the number. Attacks left {2}, enemylife {3}", numberInputX, numberInputY, grid.cannons, grid.enemyLife);

            if (grid.cannons == 0)
            {
                Console.WriteLine("gameover you lose");
                    goto NewGame;
            }
            else if (grid.enemyLife == 0)
            {
                Console.WriteLine("gamveover you win");
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

        public static string[,] createGrid()
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
