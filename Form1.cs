using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static double R = 1;
        static double r1 = 0.45;
        static double h1 = 0.33;
        static double r2 = 0.25;
        static double h2 = 2.57;
        static double r3 = 1.5;
        static double h3 = 0.8;
        static double h4 = 0.7;
        static double h5 = 0.35;
        static double h6 = 6.07;
        static double h7 = 1.22;
        double v1 = (3.14 * (R * R + r1 * r1 + R * r1) * h1) / 3;
        double v2 = 3.14 * R * R * h2;
        double v3 = (3.14 * (R * R + r2 * r2 + R * r2) * h3) / 3;
        double v4 = 3.14 * r2 * r2 * h4;
        double v5 = (3.14 * (r3 * r3 + r2 * r2 + r2 * r3) * h5) / 3;
        double v6 = 3.14 * r3 * r3 * h6;
        double v7 = (3.14 * r3 * r3 * h7) / 3;
        

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                double totalVolume = v1 + v2 + v3 + v4 + v5 + v6 + v7;
                double h = double.Parse(textBox1.Text.ToString().Replace(".", ","));
                textBox1.Clear();
                textBox1.Focus();
                double result = totalVolume - calCulateEmptyVolume(h);
                textBox1.Text = result.ToString();
            }
            catch (Exception ex) {
                textBox1.Text = "ERROR";
            }
        }

        private double calCulateEmptyVolume(double h)
        {
            double emptyValume = 0;
            if (h > h1)
            {
                emptyValume += v1;
                h = h - h1;
            }
            else
            {
               return (3.14 * (R * R + r1 * r1 + R * r1) * h) / 3;
            }

            if (h > h2)
            {
                emptyValume += v2;
                h = h - h2;
            }
            else
            {
                return emptyValume += 3.14 * R * R * h;
            }

            if (h > h3)
            {
                emptyValume += v3;
                h = h - h3;
            }
            else
            {
                return emptyValume += (3.14 * (R * R + r2 * r2 + R * r2) * h) / 3;
            }

            if (h > h4)
            {
                emptyValume += v4;
                h = h - h4;
            }
            else
            {
                return emptyValume += 3.14 * r2 * r2 * h;
            }

            if (h > h5)
            {
                emptyValume += v5;
                h = h - h5;
            }
            else
            {
                return emptyValume += (3.14 * (r3 * r3 + r2 * r2 + r2 * r3) * h) / 3;
            }

            if (h > h6)
            {
                emptyValume += v6;
                h = h - h6;
            }
            else
            {
                return emptyValume += 3.14 * r3 * r3 * h6;
            }

            if (h > h7)
            {
                emptyValume += v7;
                h = h - h7;
            }
            else
            {
                return emptyValume += (3.14 * r3 * r3 * h7) / 3;
            }

            return emptyValume;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
