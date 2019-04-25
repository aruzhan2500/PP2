using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
        double a = 0, b = 0, c = 0;
        string znak = "+";
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox1.Text[0] == '-')
                {
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                }
                else textBox1.Text = '-' + textBox1.Text;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }
        
        private void button23_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            znak = (sender as Button).Text;
            switch (znak)
            {
                case "x^2": c = a * a;
                    break;
                case "x^3": c = a * a * a;
                    break;
                case "1/x": c = 1 / a;
                    break;
                case "√": c = Math.Sqrt(a);
                    break;
                case "%": c = a / 100;
                    break;
            }
            textBox1.Text = c.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            int bit = int.Parse(textBox1.Text);
            znak = (sender as Button).Text;
            switch (znak)
            {
                case ">2":
                    Code binary = new Code(2);
                    textBox1.Text = binary.Bits(bit);
                    break;
                case ">8":
                    Code octal = new Code(8);
                    textBox1.Text = octal.Bits(bit);
                    break;
                case ">16":
                    Hexadecimal hexadecimal = new Hexadecimal();
                    textBox1.Text = hexadecimal.Bits(bit);
                    break;
                case "x!":
                    int c = 1;
                    int i = 1;
                    while (i <= bit)
                    {
                        c *= i;
                        i++;
                    }
                    textBox1.Text = c.ToString();
                    break;
                case "fib":
                    Fibonacci fibonacci = new Fibonacci();
                    textBox1.Text = fibonacci.GetNumber(bit).ToString();
                    break;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text;
            ToDecimal toDecimal = new ToDecimal(16);
            textBox1.Text = toDecimal.GetDecimal(n).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            znak = (sender as Button).Text;
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            b = double.Parse(textBox1.Text);
            switch (znak)
            {
                case "+": c = a + b;
                    textBox1.Text = c.ToString();
                    break;
                case "-": c = a - b;
                    textBox1.Text = c.ToString();
                    break;
                case "x": c = a * b;
                    textBox1.Text = c.ToString();
                    break;
                case "÷": c = a / b;
                    textBox1.Text = c.ToString();
                    break;
                case "gcd":
                    GCD gcd = new GCD();
                    c = gcd.GetGCD(a, b);
                    textBox1.Text = c.ToString();
                    break;
                case "lcm":
                    LCM lcm = new LCM();
                    c = lcm.GetLCM(a, b);
                    textBox1.Text = c.ToString();
                    break;
                case "min":
                    Min min = new Min();
                    c = min.GetMin(a, b);
                    textBox1.Text = c.ToString();
                    break;
                case "x^y":
                    c = Math.Pow(a, b);
                    textBox1.Text = c.ToString();
                    break;
                case "copr":
                    gcd = new GCD();
                    textBox1.Text = gcd.Coprime(a, b);
                    break;
            }
        }
    }
}
