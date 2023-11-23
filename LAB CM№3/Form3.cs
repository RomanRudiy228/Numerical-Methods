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
    public partial class Form3 : Form
    {
        public Form3()
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
            textBox3.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x0 = double.Parse(textBox1.Text);
            double epsilon = double.Parse(textBox3.Text);

            double x = x0;
            int iteration = 0;
            double dx;
            do
            {
                double fx = Function(x);
                double fpx = Derivative(x);

                if (fpx == 0)
                {
                    MessageBox.Show("Похибка: похідна дорівнює нулю");
                    return;
                }

                dx = fx / fpx;
                x = x - dx;

                iteration++;

            } while (Math.Abs(dx) > epsilon);

            MessageBox.Show("Корінь функції: " + x.ToString() + Environment.NewLine +
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
