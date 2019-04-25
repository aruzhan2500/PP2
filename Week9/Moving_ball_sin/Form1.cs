using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moving_ball_sin
{
    public partial class Form1 : Form
    {
        double x = 0, y;
        Graphics gfx;

        public Form1()
        {
            InitializeComponent();
            gfx = CreateGraphics();
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            x++;
            y = Math.Sin(x);
            gfx.FillEllipse(new SolidBrush(Color.Yellow), 20 * (float)x, 50 * (float)y + 100, 30, 30);
        }
    }
}
