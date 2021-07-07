using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class BattleGrid
    {
         public string[] row0 = { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" };
        public string[] row1= { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" };
        public string[] row2= { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" };
        public string[] row3= { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" };
        public string[] row4= { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" };
        public string[] row5= { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" };
        public string[] row6= { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" };
        public string[] row7= { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" };
        public string[] row8= { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" };
        public string[] row9= { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" };

        public BattleGrid()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("  0 1 2 3 4 5 6 7 8 9 ");
            Console.WriteLine("0 {0} {1} {2} {3} {4} {5} {6} {7} {8} {0}", row0);
            Console.WriteLine("1 {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", row1);
            Console.WriteLine("2 {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", row2);
            Console.WriteLine("3 {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", row3);
            Console.WriteLine("4 {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", row4);
            Console.WriteLine("5 {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", row5);
            Console.WriteLine("6 {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", row6);
            Console.WriteLine("7 {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", row7);
            Console.WriteLine("8 {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", row8);
            Console.WriteLine("9 {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", row9);
            Console.WriteLine("=======================");
        }
    }
}
