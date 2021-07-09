using System;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "FIRE! Find the Enemy";

            NewGame:

            //global variables
            var fireAttempts = 8;
            var enemyLife = 5;
            // var outCome;

            //Random random = new Random();
            //int xLocation = random.Next(0, 5);
            //int yLocation = random.Next(0, 10);

            BattleGrid grid = new BattleGrid();
            grid.drawGrid();

            

            
            // EnemyShip enemyShip = new EnemyShip();

        Restart:

            try
            {
                Console.Write("Please input a number for x-axis: ");
                int numberInputX = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Please input a number for y-axis: ");
                int numberInputY = Convert.ToInt32(Console.ReadLine());

                //Gamemaster function runs
              



                fireAttempts--;
                Console.WriteLine("you choose {0} and {1} as the number. Attacks left {2}, enemylife {3}", numberInputX, numberInputY, fireAttempts, enemyLife);

            if (fireAttempts == 0)
            {
                Console.WriteLine("gameover you lose");
                    goto NewGame;
            }
            else if (enemyLife == 0)
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


        //public static void checkForHitOrMiss(BattleGrid grid, EnemyShip enemyShip, int numberInputX, int numberInputY)
        //{
        //    if(enemyShip.ShipRow == numberInputY)
        //    {
        //        for(int i = 0, i < 5, i++)
        //        {

        //        }
        //    }
        //}
    }
}
