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

namespace PaintApp
{
    enum Tool
    {
        Pencil, 
        Rubber,
        Fill
    }
    public partial class Form1 : Form
    {
        Tool currentTool;
        Point firstPoint;
        Point secondPoint;
        Graphics graphics;
        Bitmap bitmap;
        Pen pen;

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;
            pen = new Pen(Color.Black, 2);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentTool = Tool.Pencil;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentTool = Tool.Rubber;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentTool = Tool.Fill;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                secondPoint = e.Location;
                switch (currentTool)
                {
                    case Tool.Pencil:
                        graphics.DrawLine(pen, firstPoint, secondPoint);
                        firstPoint = secondPoint;
                        break;
                    case Tool.Rubber:
                        pen = new Pen(Color.White, 10);
                        graphics.DrawLine(pen, firstPoint, secondPoint);
                        firstPoint = secondPoint;
                        break;
                    case Tool.Fill:
                        break;
                }
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            if (currentTool == Tool.Fill)
            {
                //MapFill mapFill = new MapFill
            }
        }
    }
}