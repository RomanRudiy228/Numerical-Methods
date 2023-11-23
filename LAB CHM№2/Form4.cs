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

namespace LAB_CHM_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
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
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a11, a12, a13, a21, a22, a23, a31, a32, a33, b1, b2, b3, u12, u13, u23, l11, l21, l22, l31, l32, l33, y1, y2, y3, x1, x2, x3;
            a11 = Convert.ToDouble(textBox1.Text);
            a12 = Convert.ToDouble(textBox2.Text);
            a13 = Convert.ToDouble(textBox3.Text);
            a21 = Convert.ToDouble(textBox4.Text);
            a22 = Convert.ToDouble(textBox5.Text);
            a23 = Convert.ToDouble(textBox6.Text);
            a31 = Convert.ToDouble(textBox7.Text);
            a32 = Convert.ToDouble(textBox8.Text);
            a33 = Convert.ToDouble(textBox9.Text);
            b1 = Convert.ToDouble(textBox10.Text);
            b2 = Convert.ToDouble(textBox11.Text);
            b3 = Convert.ToDouble(textBox12.Text);

            l11 = a11;
            l21 = a21;
            l31= a31;
            u12 = a12 / l11;
            u13 = a13 / l11;
            l22 = a22 - (l21 * u12);
            u23 = (1/l22) * (a23 - (l21 * u13));
            l32 = a32 - (l31 * u12);
            l33 = a33 - ((l31 * u13) + (l32 * u23));

            y1 = b1 / l11;
            y2 = (b2 - (l21 * y1)) / l22;
            y3 = (b3 - (l31 * y1) - (l32 * y2)) / l33;

            x3 = y3;
            x2 = y2 - (u23 * x3);
            x1 = y1 - ((u12 * x2) + (u13 * x3));
            textBox13.Text = "Визначники x= " + "x1= " + Convert.ToString(x1) + "x2= " + Convert.ToString(x2) + "x3= " + Convert.ToString(x3);
        }
    }
}
