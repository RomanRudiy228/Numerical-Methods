using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB_5_CHM_2_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double h = double.Parse(textBox3.Text);
            double y0 = double.Parse(textBox4.Text);

            double x0 = 1, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10;
            x1 = x0 + h;
            x2 = x0 + 2 * h;
            x3 = x0 + 3 * h;
            x4 = x0 + 4 * h;
            x5 = x0 + 5 * h;
            x6 = x0 + 6 * h;
            x7 = x0 + 7 * h;
            x8 = x0 + 8 * h;
            x9 = x0 + 9 * h;
            x10 = x0 + 10 * h;

            double y1, y2, y3, y4, y5, y6, y7, y8, y9, y10;
            y1 = y0 + (h * (Math.Pow(Math.Cos((1.5 * y0) + x0), 2) + 1.4));
            y2 = y1 + (h * (Math.Pow(Math.Cos((1.5 * y1) + x1), 2) + 1.4));
            y3 = y2 + (h * (Math.Pow(Math.Cos((1.5 * y2) + x2), 2) + 1.4));
            y4 = y3 + (h * (Math.Pow(Math.Cos((1.5 * y3) + x3), 2) + 1.4));
            y5 = y4 + (h * (Math.Pow(Math.Cos((1.5 * y4) + x4), 2) + 1.4));
            y6 = y5 + (h * (Math.Pow(Math.Cos((1.5 * y5) + x5), 2) + 1.4));
            y7 = y6 + (h * (Math.Pow(Math.Cos((1.5 * y6) + x6), 2) + 1.4));
            y8 = y7 + (h * (Math.Pow(Math.Cos((1.5 * y7) + x7), 2) + 1.4));
            y9 = y8 + (h * (Math.Pow(Math.Cos((1.5 * y8) + x8), 2) + 1.4));
            y10 = y9 + (h * (Math.Pow(Math.Cos((1.5 * y9) + x9), 2) + 1.4));

            MessageBox.Show("Розв'язок: " + " x= " + x1.ToString() + Environment.NewLine + x2.ToString() + Environment.NewLine + x3.ToString() + Environment.NewLine + x4.ToString() + Environment.NewLine + x5.ToString() +  Environment.NewLine + x6.ToString() + Environment.NewLine + x7.ToString() + Environment.NewLine + x8.ToString() + Environment.NewLine + x9.ToString() + Environment.NewLine + x10.ToString()
            + Environment.NewLine + " y= " + y1.ToString() + Environment.NewLine + y2.ToString() + Environment.NewLine + y3.ToString() + Environment.NewLine + y4.ToString() + Environment.NewLine + y5.ToString() + Environment.NewLine + y6.ToString() + Environment.NewLine + y7.ToString() + Environment.NewLine + y8.ToString() + Environment.NewLine + y9.ToString() + Environment.NewLine + y10.ToString());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double h = double.Parse(textBox3.Text);
            double y0 = double.Parse(textBox4.Text);

            double x0 = 1, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10;
            x1 = x0 + h;
            x2 = x0 + 2 * h;
            x3 = x0 + 3 * h;
            x4 = x0 + 4 * h;
            x5 = x0 + 5 * h;
            x6 = x0 + 6 * h;
            x7 = x0 + 7 * h;
            x8 = x0 + 8 * h;
            x9 = x0 + 9 * h;
            x10 = x0 + 10 * h;

            double y11, y1, y22, y2, y33, y3, y44, y4, y55, y5, y66, y6, y77, y7, y88, y8, y99, y9, y1010, y10;
            y11 = y0 + ((h / 2) * (Math.Pow(Math.Cos((1.5 * y0) + x0), 2) + 1.4));
            y1 = y0 + (h * (Math.Pow(Math.Cos((1.5 * y11) + (x0 + (h / 2))), 2) + 1.4));

            y22 = y1 + ((h / 2) * (Math.Pow(Math.Cos((1.5 * y1) + x1), 2) + 1.4));
            y2 = y1 + (h * (Math.Pow(Math.Cos((1.5 * y22) + (x1 + (h / 2))), 2) + 1.4));

            y33 = y2 + ((h / 2) * (Math.Pow(Math.Cos((1.5 * y2) + x2), 2) + 1.4));
            y3 = y2 + (h * (Math.Pow(Math.Cos((1.5 * y33) + (x2 + (h / 2))), 2) + 1.4));

            y44 = y3 + ((h / 2) * (Math.Pow(Math.Cos((1.5 * y3) + x3), 2) + 1.4));
            y4 = y3 + (h * (Math.Pow(Math.Cos((1.5 * y44) + (x3 + (h / 2))), 2) + 1.4));

            y55 = y4 + ((h / 2) * (Math.Pow(Math.Cos((1.5 * y4) + x4), 2) + 1.4));
            y5 = y4 + (h * (Math.Pow(Math.Cos((1.5 * y55) + (x4 + (h / 2))), 2) + 1.4));

            y66 = y5 + ((h / 2) * (Math.Pow(Math.Cos((1.5 * y5) + x5), 2) + 1.4));
            y6 = y5 + (h * (Math.Pow(Math.Cos((1.5 * y66) + (x5 + (h / 2))), 2) + 1.4));

            y77 = y6 + ((h / 2) * (Math.Pow(Math.Cos((1.5 * y6) + x6), 2) + 1.4));
            y7 = y6 + (h * (Math.Pow(Math.Cos((1.5 * y77) + (x6 + (h / 2))), 2) + 1.4));

            y88 = y7 + ((h / 2) * (Math.Pow(Math.Cos((1.5 * y7) + x7), 2) + 1.4));
            y8 = y7 + (h * (Math.Pow(Math.Cos((1.5 * y88) + (x7 + (h / 2))), 2) + 1.4));

            y99 = y8 + ((h / 2) * (Math.Pow(Math.Cos((1.5 * y8) + x8), 2) + 1.4));
            y9 = y8 + (h * (Math.Pow(Math.Cos((1.5 * y99) + (x8 + (h / 2))), 2) + 1.4));

            y1010 = y9 + ((h / 2) * (Math.Pow(Math.Cos((1.5 * y9) + x9), 2) + 1.4));
            y10 = y9 + (h * (Math.Pow(Math.Cos((1.5 * y1010) + (x9 + (h / 2))), 2) + 1.4));

            MessageBox.Show("Розв'язок: " + " x= " + x1.ToString() + Environment.NewLine + x2.ToString() + Environment.NewLine + x3.ToString() + Environment.NewLine + x4.ToString() + Environment.NewLine + x5.ToString() +  Environment.NewLine + x6.ToString() + Environment.NewLine + x7.ToString() + Environment.NewLine + x8.ToString() + Environment.NewLine + x9.ToString() + Environment.NewLine + x10.ToString()
             + Environment.NewLine + " y= " + y1.ToString() + Environment.NewLine + y2.ToString() + Environment.NewLine + y3.ToString() + Environment.NewLine + y4.ToString() + Environment.NewLine + y5.ToString() + Environment.NewLine + y6.ToString() + Environment.NewLine + y7.ToString() + Environment.NewLine + y8.ToString() + Environment.NewLine + y9.ToString() + Environment.NewLine + y10.ToString());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double h = double.Parse(textBox3.Text);
            double y0 = double.Parse(textBox4.Text);

            double x0 = 1, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10;
            x1 = x0 + h;
            x2 = x0 + 2 * h;
            x3 = x0 + 3 * h;
            x4 = x0 + 4 * h;
            x5 = x0 + 5 * h;
            x6 = x0 + 6 * h;
            x7 = x0 + 7 * h;
            x8 = x0 + 8 * h;
            x9 = x0 + 9 * h;
            x10 = x0 + 10 * h;

            double y11, y1, y22, y2, y33, y3, y44, y4, y55, y5, y66, y6, y77, y7, y88, y8, y99, y9, y1010, y10, f1, f2, f3, f4, f5, f6, f7, f8, f9, f10;
            y11 = y0 + (h * (Math.Pow(Math.Cos((1.5 * y0) + x0), 2) + 1.4));
            f1 = (Math.Pow(Math.Cos((1.5 * y11) + x1), 2) + 1.4);
            y1 = y0 + ((h / 2) * ((Math.Pow(Math.Cos((1.5 * y0) + x0), 2) + 1.4) + f1));

            y22 = y1 + ((h / 2) * (Math.Pow(Math.Cos((1.5 * y1) + x1), 2) + 1.4));
            f2 = (Math.Pow(Math.Cos((1.5 * y22) + x2), 2) + 1.4);
            y2 = y1 + ((h / 2) * ((Math.Pow(Math.Cos((1.5 * y1) + x1), 2) + 1.4) + f2));

            y33 = y2 + ((h / 2) * (Math.Pow(Math.Cos((1.5 * y2) + x2), 2) + 1.4));
            f3 = (Math.Pow(Math.Cos((1.5 * y33) + x3), 2) + 1.4);
            y3 = y2 + ((h / 2) * ((Math.Pow(Math.Cos((1.5 * y2) + x2), 2) + 1.4) + f3));

            y44 = y3 + ((h / 2) * (Math.Pow(Math.Cos((1.5 * y3) + x3), 2) + 1.4));
            f4 = (Math.Pow(Math.Cos((1.5 * y44) + x4), 2) + 1.4);
            y4 = y3 + ((h / 2) * ((Math.Pow(Math.Cos((1.5 * y3) + x3), 2) + 1.4) + f4));

            y55 = y4 + ((h / 2) * (Math.Pow(Math.Cos((1.5 * y4) + x4), 2) + 1.4));
            f5 = (Math.Pow(Math.Cos((1.5 * y55) + x5), 2) + 1.4);
            y5 = y4 + ((h / 2) * ((Math.Pow(Math.Cos((1.5 * y4) + x4), 2) + 1.4) + f5));

            y66 = y5 + ((h / 2) * (Math.Pow(Math.Cos((1.5 * y5) + x5), 2) + 1.4));
            f6 = (Math.Pow(Math.Cos((1.5 * y66) + x6), 2) + 1.4);
            y6 = y5 + ((h / 2) * ((Math.Pow(Math.Cos((1.5 * y5) + x5), 2) + 1.4) + f6));

            y77 = y6 + ((h / 2) * (Math.Pow(Math.Cos((1.5 * y6) + x6), 2) + 1.4));
            f7 = (Math.Pow(Math.Cos((1.5 * y77) + x7), 2) + 1.4);
            y7 = y6 + ((h / 2) * ((Math.Pow(Math.Cos((1.5 * y6) + x6), 2) + 1.4) + f7));

            y88 = y7 + ((h / 2) * (Math.Pow(Math.Cos((1.5 * y7) + x7), 2) + 1.4));
            f8 = (Math.Pow(Math.Cos((1.5 * y88) + x8), 2) + 1.4);
            y8 = y7 + ((h / 2) * ((Math.Pow(Math.Cos((1.5 * y7) + x7), 2) + 1.4) + f8));

            y99 = y8 + ((h / 2) * (Math.Pow(Math.Cos((1.5 * y8) + x8), 2) + 1.4));
            f9 = (Math.Pow(Math.Cos((1.5 * y99) + x9), 2) + 1.4);
            y9 = y8 + ((h / 2) * ((Math.Pow(Math.Cos((1.5 * y8) + x8), 2) + 1.4) + f9));

            y1010 = y9 + ((h / 2) * (Math.Pow(Math.Cos((1.5 * y9) + x9), 2) + 1.4));
            f10 = (Math.Pow(Math.Cos((1.5 * y1010) + x10), 2) + 1.4);
            y10 = y9 + ((h / 2) * ((Math.Pow(Math.Cos((1.5 * y9) + x9), 2) + 1.4) + f10));

            MessageBox.Show("Розв'язок: " + " x= " + x1.ToString() + Environment.NewLine + x2.ToString() + Environment.NewLine + x3.ToString() + Environment.NewLine + x4.ToString() + Environment.NewLine + x5.ToString() + Environment.NewLine + x6.ToString() + Environment.NewLine + x7.ToString() + Environment.NewLine + x8.ToString() + Environment.NewLine + x9.ToString() + Environment.NewLine + x10.ToString()
            + Environment.NewLine + " y= " + y1.ToString() + Environment.NewLine + y2.ToString() + Environment.NewLine + y3.ToString() + Environment.NewLine + y4.ToString() + Environment.NewLine + y5.ToString() + Environment.NewLine + y6.ToString() + Environment.NewLine + y7.ToString() + Environment.NewLine + y8.ToString() + Environment.NewLine + y9.ToString() + Environment.NewLine + y10.ToString());

        }

        private void button7_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double h = double.Parse(textBox3.Text);
            double y0 = double.Parse(textBox4.Text);

            double f(double x, double y)
            {
                return (Math.Pow(Math.Cos((1.5 * y) + x), 2) + 1.4);
            }

            int n = (int)((b - a) / h);
            double[] x = new double[n + 1]; double[] y = new double[n + 1];
            x[0] = a;
            y[0] = y0;

            for (int i = 0; i < n; i++)
            {
                double k1 = h * f(x[i], y[i]);
                double k2 = h * f(x[i] + h / 2, y[i] + k1 / 2);
                double k3 = h * f(x[i] + h / 2, y[i] + k2 / 2);
                double k4 = h * f(x[i] + h, y[i] + k3);
                x[i + 1] = x[i] + h; y[i + 1] = y[i] + (k1 + 2 * k2 + 2 * k3 + k4) / 6;
            }

            for (int i = 0; i <= n; i++)
            {
                MessageBox.Show("x" + i + " = " + x[i].ToString() + "\t" + "   y" + i + " = " + y[i].ToString());
            }
        }
    }
}
