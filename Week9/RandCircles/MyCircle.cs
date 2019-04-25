using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandCircles
{
    class MyCircle
    {
        public int x, y, radius, dx, dy;
        public Color color;
        public MyCircle(int x, int y, int radius, Color color, int dx, int dy)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            this.color = color;
            this.dx = dx;
            this.dy = dy;
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
