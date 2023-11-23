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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a11, a12, a13, a21, a22, a23, a31, a32, a33, b1, b2, b3, deta, det1, det2, det3, x1, x2, x3;
            try
            {
                if ((String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text)))
                {
                    MessageBox.Show("Cтрічка пуста", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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

                deta = ((a11 * a22 * a33) + (a12 * a23 * a31) + (a13 * a21 * a32)) - ((a13 * a22 * a31) - (a11 * a23 * a32) - (a21 * a21 * a33));
                det1 = ((b1 * a22 * a33) + (b2 * a23 * b3) + (b3 * b2 * a32)) - ((b3 * a22 * b3) - (b1 * a23 * a32) - (b2 * b2 * a33));
                det2 = ((a11 * b2 * a33) + (b1 * a23 * a31) + (b3 * a21 * b3)) - ((b3 * b2 * a31) - (a11 * a23 * b3) - (b1 * a21 * a33));
                det3 = ((a11 * a22 * b3) + (b2 * b2 * a31) + (b1 * a21 * a32)) - ((b1 * a22 * a31) - (a11 * b2 * a32) - (b2 * a21 * b3));

                x1 = det1 / deta;
                x2 = det2 / deta;
                x3 = det3 / deta;

                textBox13.Text = "Визначники x= " + "x1= " + Convert.ToString(x1) + "x2= " + Convert.ToString(x2) + "x3= " + Convert.ToString(x3);
            }
            catch
            {
                MessageBox.Show("Не коректно введено дані!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
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
    }
}
