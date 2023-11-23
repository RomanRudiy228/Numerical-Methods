using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_CHM_2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a11, a12, a13, a21, a22, a23, a31, a32, a33, b1, b2, b3, a111, a112, a113, a121, a131, a122, a123, a132, a133, a232, a233,
                b11, b22, b33, x1, x2, x3;
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

            a111 = a11;
            a112 = a12;
            a113 = a13;
            a121 = 0;
            a131 = 0;
            a122 = a22 - (a12 * (a21/a11));
            a123 = a23 - (a13 * (a21/a11));
            a132 = a32 - (a12 * (a31/a11));
            a133 = a33 - (a13 * (a31/a11));
            a232 = 0;
            a233 = a133 - (a123 * (a132/a122));

            b11 = b1;
            b22 = b2 - (b1 * (a21/a11));
            b33 = b3 - (b1 * (a31/a11));

            x3 = b33/a233;
            x2 = (b22 - (a123 * x3)) / a22;
            x1 = (b11 - (a112 * x2) + (a113 * x3)) / a111;

            textBox13.Text = "Визначники x= " + "x1= " + Convert.ToString(x1) + "x2= " + Convert.ToString(x2) + "x3= " + Convert.ToString(x3);
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
    }
}
