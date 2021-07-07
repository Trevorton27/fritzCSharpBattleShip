using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class EnemyShipHead
    {
        public int ShipRow;
        public int ShipHead;
        public int ShipBody1;
        public int ShipBody2;
        public int ShipBody3;
        public int ShipBody4;

        public EnemyShipHead()
        {
            Random random = new Random();
            int xLocation = random.Next(0, 5);
            int yLocation = random.Next(0, 10);

            ShipRow = yLocation;
            ShipHead = xLocation++;
            ShipBody1 = xLocation++;
            ShipBody2 = xLocation++;
            ShipBody3 = xLocation++;
            ShipBody4 = xLocation++;
        }
    }
}
