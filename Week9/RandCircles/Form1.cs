using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandCircles
{
    public partial class Form1 : Form
    {
        Graphics gfx;
        List<MyCircle> myCircles = new List<MyCircle>();
        public Form1()
        {
            InitializeComponent();
            gfx = CreateGraphics();
            timer1.Start();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            Color color = Color.FromArgb(rnd.Next(2000000000));
            myCircles.Add(new MyCircle(e.Location.X, e.Location.Y, 15, color, rnd.Next(-15, 15), rnd.Next(-15, 15)));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            foreach (MyCircle c in myCircles)
            {
                c.Move();
                c.Check(Width, Height);
                gfx.FillEllipse(new SolidBrush(c.color), c.GetRectangle());
            }
        }
    }
}
