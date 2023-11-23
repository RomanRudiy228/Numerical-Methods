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

namespace LAB_CM_3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox12.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x0 = double.Parse(textBox1.Text);
            double x1 = double.Parse(textBox2.Text);
            double epsilon = double.Parse(textBox3.Text);

            double x, fx, fpx;
            int iteration = 0;

            do
            {
                fx = Function(x0);
                fpx = Derivative(x1);

                if (fpx == 0)
                {
                    MessageBox.Show("Похибка: похідна дорівнює нулю");
                    return;
                }

                x = ((x1 - fx) * (x1 - x0)) / (fx - Function(x1));
                x0 = x1;
                x1 = x;

                iteration++;

            } while (Math.Abs(x1 - x0) <= epsilon);

            MessageBox.Show("Корінь функції: " + x1.ToString() + Environment.NewLine +
                            "Кількість ітерацій: " + iteration.ToString());
        }

        private double Function(double x)
        {
            return Math.Sin(x) - 0.2 * x;
        }

        private double Derivative(double x)
        {
            return Math.Cos(x) - 0.2;
        }
    }
}