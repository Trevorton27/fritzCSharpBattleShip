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

        public string[,] gridSpace = { 
        { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
        { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
        { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
        { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
        { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
        { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
        { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
        { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
        { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" },
        { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" }};

        public BattleGrid()
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

            //Console.WriteLine("0 {0} {1} {2} {3} {4} {5} {6} {7} {8} {0}", row0);
            //Console.WriteLine("1 {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", row1);
            //Console.WriteLine("2 {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", row2);
            //Console.WriteLine("3 {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", row3);
            //Console.WriteLine("4 {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", row4);
            //Console.WriteLine("5 {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", row5);
            //Console.WriteLine("6 {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", row6);
            //Console.WriteLine("7 {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", row7);
            //Console.WriteLine("8 {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", row8);
            //Console.WriteLine("9 {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", row9);

        }

        public void drawGrid()
        {
            
            Console.WriteLine("  0 1 2 3 4 5 6 7 8 9 ");
            Console.WriteLine(" =====================");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < 10; j++)
                {
                    Console.Write( "{0} ",gridSpace[i, j]);
                }
                Console.WriteLine("|{0} ", i);
            }
            Console.WriteLine(" =====================");
        }
    }
}
