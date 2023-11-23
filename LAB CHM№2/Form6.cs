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
    public partial class Form6 : Form
    {
        public Form6()
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

        private void button2_Click(object sender, EventArgs e)
        {
            double a11, a12, a13, a21, a22, a23, a31, a32, a33, b1, b2, b3, al11, al12, al13, al21, al22, al23, al31, al32, al33, bet1, bet2, bet3;
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

            al11 = 0; al12 = - (a12/a11); al13 = - (a13/a11);
            al21 = - (a21/a22); al22 = 0;  al23 = - (a23/a22);
            al31 = - (a31/a33); al32 = - (a32/a33); al33 = 0;
            
            bet1 = b1/a11;
            bet2 = b2/a22;
            bet3 = b3/a33;

            double kn1, kn2, kn3, x01, x02, x03, pr1, pr2, pr3, x11, x12, x13, x21, x22, x23, x31, x32, x33, x41, x42, x43;
            kn1 = Math.Abs(al11 + al12 + al13);
            kn2 = Math.Abs(al21 + al22 + al23);
            kn3 = Math.Abs(al31 + al32 + al33);
            //1
            x01 = b1 + (al12 * b2) + (al13 * b3);
            x02 = b2 + (al21 * b1) + (al23 * b3);
            x03 = b3 + (al31 * b1) + (al32 * b2);

            pr1 = x01 - b1;
            pr2 = x02 - b2;
            pr3 = x03 - b3;
            //2
            x11 = x01 + (al12 * x02) + (al13 * x03);
            x12 = x02 + (al21 * x01) + (al23 * x03);
            x13 = x03 + (al31 * x01) + (al32 * x02);
            //3
            x21 = x01 + (al12 * x12) + (al13 * x13);
            x22 = x02 + (al21 * x11) + (al23 * x13);
            x23 = x03 + (al31 * x11) + (al32 * x12);
            //4
            x31 = x01 + (al12 * x22) + (al13 * x23);
            x32 = x02 + (al21 * x21) + (al23 * x23);
            x33 = x03 + (al31 * x21) + (al32 * x22);
            //5
            x41 = x01 + (al12 * x32) + (al13 * x33);
            x42 = x02 + (al21 * x31) + (al23 * x33);
            x43 = x03 + (al31 * x31) + (al32 * x32);

            textBox13.Text = "Матриця альфа: " + Convert.ToString(al11) + " " + Convert.ToString(al12) + " " + Convert.ToString(al13) + " " + Convert.ToString(al21) + " " + Convert.ToString(al22) + " " + Convert.ToString(al23) + " " + Convert.ToString(al31) + " " + Convert.ToString(al32) + " " + Convert.ToString(al33) + " " + "Вектор бета: " + "B1:" + " " + Convert.ToString(bet1) + " " + "B2:" + " " + Convert.ToString(bet2) + " " + "B3:" + " " + Convert.ToString(bet3) + " " + "Канонічні норми: " + " " + "1: " + " " + Convert.ToString(kn1) + " " + "2: " + " " + Convert.ToString(kn2) + " " + "3: " + " " + Convert.ToString(kn3) + " " + "Так як |x1 - x2| > 0,05 буде використовуватись 5 ітерацій для знаходження вектора х" + " " + "5 ітерація виконана з новими визначниками х" + " " + "Визначники x= " + " " + "x1= " + Convert.ToString(x41) + "x2= " + " " + Convert.ToString(x42) + "x3= " + " " + Convert.ToString(x43);
        }
    }
}
