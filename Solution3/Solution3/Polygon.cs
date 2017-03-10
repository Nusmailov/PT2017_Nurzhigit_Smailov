using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution3
{
    public class Polygon
    {
        public List<Point> body;
        public Polygon()
        {
            body = new List<Point>();
            body.Add(new Point(10, 10));
            for (int i = 0; i < 5; i++)
            {
                body[i].x = i;
                body[i].y = i;
            }
        }
        public int x, y;
        public override string ToString()
        {
            return x + " " + y;
        }
    }
}
