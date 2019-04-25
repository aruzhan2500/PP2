using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moving_people_in_diff_directions_by_class
{
    public partial class Form1 : Form
    {
        Person person1 = new Person(150, 40, 10, 0);
        Person person2 = new Person(150, 20, -10, 0);
        Graphics gfx;

        public Form1()
        {
            InitializeComponent();
            gfx = CreateGraphics();
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Person person1 = new Person(20, 40, 10, 0);
            Person person2 = new Person(5, 20, -10, 0);
            gfx.FillRectangle(new SolidBrush(Color.Blue), 0, 0, 600, 150);
            gfx.FillRectangle(new SolidBrush(Color.Green), 0, 150, 600, 150);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();

            person1.DrawPerson(gfx);
            person1.Move();
            person1.Check(this.Width, this.Height);

            person2.DrawPerson(gfx);
            person2.Move();
            person2.Check(this.Width, this.Height);
        }
    }
}
