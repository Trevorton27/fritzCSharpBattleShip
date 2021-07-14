using System;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
            
        {   
                 static string[,] populateGrid()
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

            string[,] grid = populateGrid();
            Random random = new Random();
            int enemyRow = random.Next(0, 10);
            int enemyColumn = random.Next(0, 5);

             BattleField gameBoard = new BattleField(enemyRow, enemyColumn, grid);
 
            gameBoard.RunGame();

            }
    }
}
