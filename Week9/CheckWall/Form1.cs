using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckWall
{
    public partial class Form1 : Form
    {
        Graphics gfx;
        MyCircle circle, circle2;

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            circle.Check(this.Width, this.Height);
            circle.Move();
            circle2.Check(this.Width, this.Height);
            circle2.Move();
            gfx.FillEllipse(new SolidBrush(Color.Red), circle.GetRectangle());
            gfx.FillEllipse(new SolidBrush(Color.Green), circle2.GetRectangle());
        }

        public Form1()
        {
            InitializeComponent();
            gfx = CreateGraphics();
            circle = new MyCircle(250, 30, 50);
            circle2 = new MyCircle(10, 10, 20);
            timer1.Start();
        }

    }
}
