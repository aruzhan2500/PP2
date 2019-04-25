using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving_people_in_diff_directions_by_class
{
    class Person
    {
        public int x, y, dx, dy;
        Pen pen = new Pen(Color.Black, 3);

        public Person(int x, int y, int dx, int dy)
        {
            this.x = x;
            this.y = y;
            this.dx = dx;
            this.dy = dy;
        }

        public void DrawPerson(Graphics gfx)
        {
            gfx.FillEllipse(new SolidBrush(Color.Red), x, y, 30, 30);
            gfx.DrawLine(pen, x + 15, y + 30, x + 15, y + 60);
            gfx.DrawLine(pen, x + 15, y + 50, x + 0, y + 75);
            gfx.DrawLine(pen, x + 15, y + 60, x + 30, y + 75);
            gfx.DrawLine(pen, x + 15, y + 40, x + 0, y + 50);
            gfx.DrawLine(pen, x + 15, y + 40, x + 30, y + 50);
        }

        public void Move()
        {
            this.x += dx;
            this.y += dy;
        }

        public void Check(int w, int h)
        {
            if (x >= w || x <= 0)
            {
                dx = -dx;
            }
            if (y >= h || y <= 0)
            {
                dx = -dx;
            }
        }
    }
}