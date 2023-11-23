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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }


        private void button3_Click_1(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            double x0, x1, x2, x3, x4, x5, x6, x7, x8, x9; double y0, y1, y2, y3, y4, y5, y6, y7, y8, y9;
            double a, b; 
            x0 = double.Parse(textBox1.Text);
            x1 = double.Parse(textBox2.Text); x2 = double.Parse(textBox3.Text);
            x3 = double.Parse(textBox4.Text); x4 = double.Parse(textBox5.Text);
            x5 = double.Parse(textBox6.Text); x6= double.Parse(textBox7.Text);
            x7 = double.Parse(textBox8.Text); x8 = double.Parse(textBox9.Text);
            x9 = double.Parse(textBox10.Text); y0 = double.Parse(textBox11.Text);
            y1 = double.Parse(textBox12.Text); y2 = double.Parse(textBox13.Text);
            y3 = double.Parse(textBox14.Text); y4 = double.Parse(textBox15.Text);
            y5 = double.Parse(textBox16.Text); y6 = double.Parse(textBox17.Text);
            y7 = double.Parse(textBox18.Text); y8 = double.Parse(textBox19.Text);
            y9 = double.Parse(textBox20.Text); double sumX = 0, sumY = 0, powX = 0, sumXY = 0;
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
             a = (x.Length * sumXY - sumX * sumY) / (x.Length * powX - Math.Pow(sumX, 2));            
             b = (sumY - a * sumX) / x.Length;
            MessageBox.Show (Convert.ToString("Y = " + Math.Round(a, 3) + " x + " + Math.Round(b, 3)));
        }
    }
}
