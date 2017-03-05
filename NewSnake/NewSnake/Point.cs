using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSnake
{
    [Serializable]
        public class Point
        {
            public int x;
            public int y;

            public Point()
            {

            }
            public Point(int _x, int _y)
            {
                x = _x;
                y = _y;
            }
        }
    }


