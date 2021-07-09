using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class BattleGrid
    {
        public int enemyLocationY;
        public int enemyOneX;
        public int enemyTwoX;
        public int enemyThreeX;
        public int enemyFourX;
        public int enemyFiveX;
        public int cannons = 8;
        public int enemyLife = 5;
        public string[,] gridSpace;

        public BattleGrid(string[,] gridTemp)
        {
            Random random = new Random();
            int xLocation = random.Next(0, 5);
            int yLocation = random.Next(0, 10);

            enemyLocationY = yLocation;
            enemyOneX = xLocation++;
            enemyTwoX = xLocation++;
            enemyThreeX = xLocation++;
            enemyFourX = xLocation++;
            enemyFiveX = xLocation++;

            gridSpace = gridTemp;
        }


        public void drawGrid()
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
        }

        public void checkLocation(int inputX, int inputY)
        {
            
            if(gridSpace[inputY, inputX] == "-")
            {
                hitCheck(inputX, inputY);
            } else
            {
                Console.Clear();
                this.drawGrid();
            }
        }

        public void hitCheck(int inputX, int inputY)
        {
            if(inputY == enemyLocationY && (inputX == enemyOneX || inputX == enemyTwoX || inputX == enemyThreeX || inputX == enemyFourX || inputX == enemyFiveX))
            {
                gridSpace[inputY, inputX] = "X";
                enemyLife--;
            } else
            {
                gridSpace[inputY, inputX] = "O";
            }

            cannons--;
            Console.WriteLine(this.enemyLocationY);
            Console.WriteLine(this.enemyFourX);
            Console.Clear();
            this.drawGrid();
        }
    }
}
