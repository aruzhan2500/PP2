using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckWall
{
    class MyCircle
    {
        public int x, y, radius, dx, dy;

        public MyCircle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            this.dx = 10;
            this.dy = 10;
        }

        public Rectangle GetRectangle()
        {
            Rectangle rect = new Rectangle(x - radius, y - radius, 2 * radius, 2 * radius);
            return rect;
        }

        public void Move()
        {
            this.x += dx;
            this.y += dy;
        }

        public void Check(int w, int h)
        {
            if (this.x >= w - 2 * radius || this.x < 0)
            {
                dx = -dx;
            }
            if (this.y >= h - 2 * radius || this.y < 0)
            {
                dy = -dy;
            }
        }
    }
}
