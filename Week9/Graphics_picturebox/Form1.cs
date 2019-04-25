using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_picturebox
{
    public partial class Form1 : Form
    {
        Point prevPoint;
        Point currentPoint;
        Graphics graphics;
        Color color = Color.Red;
        public Form1()
        {
            InitializeComponent();
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            currentPoint = e.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath(FillMode.Winding);
            gp.AddLine(100, 100, 200, 200);
            gp.AddEllipse(100, 100, 200, 200);
            gp.AddRectangle(new Rectangle(100, 100, 200, 350));
            //graphics.DrawPath(new Pen(color), gp);
            graphics.FillPath(new Pen(color).Brush, gp);
            pictureBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prevPoint = e.Location;
        }
    }
}
