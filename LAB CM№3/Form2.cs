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
    public partial class Form2 : Form
    {
        public Form2()
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
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double epsilon = double.Parse(textBox3.Text);

            if (Function(a) * Function(b) >= 0)
            {
                MessageBox.Show("На заданому інтервалі не виконується умова теореми про існування кореня");
                return;
            }

            double c = 0;
            int iteration = 0;

            do
            {
                c = (a + b) / 2;
                iteration++;

                if (Function(a) * Function(c) < 0)
                {
                    b = c;
                }
                else
                {
                    a = c;
                }

            } while (Math.Abs(Function(c)) > epsilon);

            MessageBox.Show("Корінь функції: " + c.ToString() + Environment.NewLine +
                            "Кількість ітерацій: " + iteration.ToString());
        }

        private double Function(double x)
        {
            return Math.Sin(x) - 0.2 * x;
        }
    }
}