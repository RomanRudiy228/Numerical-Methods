using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ЛАБ_4_ЧМ
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = double.Parse(textBox1.Text);
            double x1 = double.Parse(textBox2.Text);
            double x2 = double.Parse(textBox4.Text);
            double x3 = double.Parse(textBox5.Text);
            double x4 = double.Parse(textBox6.Text);
            double[] x = { x0, x1, x2, x3, x4};
            double xt = double.Parse(textBox3.Text);

            double y0 = double.Parse(textBox11.Text);
            double y1 = double.Parse(textBox10.Text);
            double y2 = double.Parse(textBox9.Text);
            double y3 = double.Parse(textBox8.Text);
            double y4 = double.Parse(textBox7.Text);
            double[] y = { y0, y1, y2, y3, y4 };

            double[,] d = new double[x.Length, x.Length]; 
            for (int i = 0; i < x.Length; i++)
            {
                d[i, 0] = y[i];
            }
            for (int j = 1; j < x.Length; j++)
            {
                for (int i = 0; i < x.Length - j; i++)
                {
                    d[i, j] = (d[i + 1, j - 1] - d[i, j - 1]) / (x[i + j] - x[i]);
                }
            }
            double[] c = new double[x.Length]; for (int j = 0; j < x.Length; j++)
            {
                c[j] = d[0, j];
            }
            double y_new = c[0];
            double q = (xt - x[0]); for (int i = 1; i < x.Length; i++)
            {
                y_new += c[i] * q;
                q *= (xt - x[i]);
            }
            MessageBox.Show(Convert.ToString("y = " + y_new));
        }
    }
}
