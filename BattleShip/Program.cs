using System;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "FIRE! Find the Enemy";

            //    //global variables
            //    var fireAttempts =  8;
            //    var enemyLife = 5;
            //    var outCome;

            //    //grid
            //    string[,] Row = [10, 10];

            //    //enemy head
            //    Random random = new Random();
            //    int headY = random.Next(1, 10);
            //    int headX = random.Next(1, 5);

            //    //body
            //    int bodyY1 = headY;
            //    int bodyX1 = headX + 1;

            //    int bodyY2 = headY;
            //    int bodyX2 = bodyX1 + 1;

            //    int bodyY3 = headY;
            //    int bodyX3 = bodyX2 + 1;

            //    int bodyY4 = headY;
            //    int bodyX4 = bodyX3 + 1;



            //Restart:


            //    //error handling
            //    try
            //    {
            //    Console.Write("Please input a number: ");
            //    int numberInputX = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Please input a number: ");
            //    int numberInputY = Convert.ToInt32(Console.ReadLine());
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }

            //    //conditionals hit or miss
            //    if(numberInputX == headX && numberInputY == headY)
            //    {
            //        enemyLife--;
            //        outCome = "hit";
            //    } else
            //    {
            //        outCome = "miss";
            //    }
            //    fireAttempts--;

            //    //conditionals gameover
            //    if(fireAttempts == 0)
            //    {
            //        Console.WriteLine("gameover you lose");
            //    } 

            //    if(enemyLife == 0)
            //    {
            //        Console.WriteLine("gamveover you win");
            //    }


            //    Console.Clear();
            //    Console.WriteLine("you choose {0} and {1} as the number, it was a {2}", numberInputX, numberInputY, outCome);

            //    goto Restart;


            BattleGrid grid = new BattleGrid();
            EnemyShip enemyShip = new EnemyShip();
            Console.WriteLine(enemyShip.ShipRow);
            Console.WriteLine(enemyShip.ShipHead);
            Console.WriteLine(enemyShip.ShipBody1);
            Console.WriteLine(enemyShip.ShipBody2);
            Console.WriteLine(enemyShip.ShipBody3);
            Console.WriteLine(enemyShip.ShipBody4);

        }
    }
}
