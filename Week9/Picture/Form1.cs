using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture
{
    public partial class Form1 : Form
    {
        Graphics gfx;
        public Form1()
        {
            InitializeComponent();
            gfx = CreateGraphics();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
            gfx.FillRectangle(brush, 0, 0, this.Width, this.Height);
            gfx.DrawRectangle(new Pen(Color.Black, 20), 0, 0, this.Width - 20, this.Height - 40);

            DrawCircles();
            gfx.FillPolygon(new SolidBrush(Color.Red), GetTriangle(new Point(10, 10), new Point(100, 100)));
            gfx.FillPolygon(new SolidBrush(Color.Red), GetInverseTriangle(new Point(10, 10), new Point(100, 100)));


            gfx.FillPolygon(new SolidBrush(Color.Red), GetTriangle(new Point(120, 20), new Point(210, 110)));
            gfx.FillPolygon(new SolidBrush(Color.Red), GetInverseTriangle(new Point(120, 20), new Point(210, 110)));
        }
        private void DrawCircles()
        {
            int d = 40;
            gfx.FillEllipse(new SolidBrush(Color.White), new Rectangle(80, 80, d, d));
            gfx.FillEllipse(new SolidBrush(Color.White), new Rectangle(200, 160, d, d));
            gfx.FillEllipse(new SolidBrush(Color.White), new Rectangle(80, 300, d, d));
            gfx.FillEllipse(new SolidBrush(Color.White), new Rectangle(160, 330, d, d));
            gfx.FillEllipse(new SolidBrush(Color.White), new Rectangle(80, 80, d, d));
        }
        private Point[] GetTriangle(Point p1, Point p2)
        {
            Point[] points =
            {
                new Point(p1.X , p2.Y),
                new Point((p1.X + p2.X)/2, p1.Y),
                p2
            };
            return points;
        }
        private Point[] GetInverseTriangle(Point p2, Point p1)
        {
            int sm = 30;
            Point[] points = {
                                new Point(p1.X, p2.Y + sm),
                                new Point((p1.X + p2.X)/2, p1.Y + sm),
                                new Point(p2.X, p2.Y + sm)};
            return points;
        }
    }
}
