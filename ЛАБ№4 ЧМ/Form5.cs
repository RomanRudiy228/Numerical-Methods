using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛАБ_4_ЧМ
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0, x1, x2, x3, x4, x5, x6, x7, x8, x9; double y0, y1, y2, y3, y4, y5, y6, y7, y8, y9;
            double a, b, c; x0 = Convert.ToDouble(textBox1.Text);
            x1 = Convert.ToDouble(textBox2.Text); x2 = Convert.ToDouble(textBox3.Text);
            x3 = Convert.ToDouble(textBox4.Text); x4 = Convert.ToDouble(textBox5.Text);
            x5 = Convert.ToDouble(textBox6.Text); x6 = Convert.ToDouble(textBox7.Text);
            x7 = Convert.ToDouble(textBox8.Text); x8 = Convert.ToDouble(textBox9.Text);
            x9 = Convert.ToDouble(textBox10.Text); y0 = Convert.ToDouble(textBox11.Text);
            y1 = Convert.ToDouble(textBox12.Text); y2 = Convert.ToDouble(textBox13.Text);
            y3 = Convert.ToDouble(textBox14.Text); y4 = Convert.ToDouble(textBox15.Text);
            y5 = Convert.ToDouble(textBox16.Text); y6 = Convert.ToDouble(textBox17.Text);
            y7 = Convert.ToDouble(textBox18.Text); y8 = Convert.ToDouble(textBox19.Text);
            y9 = Convert.ToDouble(textBox20.Text); double sumX = 0, sumY = 0, powX = 0, sumXY = 0, powX3 = 0, powX4 = 0, sumX2Y = 0;
            double[] x = { x0, x1, x2, x3, x4, x5, x6, x7, x8, x9 }; double[] y = { y0, y1, y2, y3, y4, y5, y6, y7, y8, y9 };
            for (int i = 0; i < x.Length; i++)
            {
                sumX += x[i];
            }
            for (int i = 0; i < y.Length; i++)
            {
                sumY += y[i];
            }
            for (int i = 0; i < x.Length; i++)
            {
                powX += Math.Pow(x[i], 2);
            }
            for (int i = 0; i < y.Length; i++)
            {
                sumXY += x[i] * y[i];
            }
            for (int i = 0; i < x.Length; i++)
            {
                powX3 += Math.Pow(x[i], 3);    //Сума кубів х
            }
                for (int i = 0; i < x.Length; i++)
                {
                    powX4 += Math.Pow(x[i], 4);    //Сума х^4
                }
                    for (int i = 0; i < y.Length; i++)
                    {
                        sumX2Y += Math.Pow(x[i], 2) * y[i];   //Сума х^2 * У
                    }
           double[,] matrix = new double[3, 3] { { powX4, powX3, powX }, { powX3, powX, sumX }, { powX, sumX, x.Length } };            
           double A, A1, A2, A3;
           A = powX4 * powX * x.Length + powX3 * sumX * powX + powX3 * sumX * powX - powX * powX * powX - powX3 * powX3 *            x.Length - sumX * sumX * powX4;
           A1 = sumX2Y * powX * x.Length + powX3 * sumX * sumY + sumXY * sumX * powX - powX * powX * sumY - sumXY * powX3 *            x.Length - sumX * sumX * sumX2Y;
           A2 = powX4 * sumXY * x.Length + sumX2Y * sumX * powX + powX3 * sumY * powX - powX * sumXY * powX - powX3 * sumX2Y *            x.Length - sumY * sumX * powX4;
           A3 = powX4 * powX * sumY + powX3 * sumXY * powX + powX3 * sumX * sumX2Y - sumX2Y * powX * powX - powX3 * powX3 *            sumY - sumX * sumXY * powX4;
           a = A1 / A;
           b = A2 / A; c = A3 / A;
            MessageBox.Show (Convert.ToString("Y = " + Math.Round(a, 3) + " x^2 + " + " " + Math.Round(b, 3) + " x + " + " " + Math.Round(c, 3)));
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
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox12.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
        }
    }
}
