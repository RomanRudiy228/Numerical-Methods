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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a11, a12, a13, a21, a22, a23, a31, a32, a33, b1, b2, b3, x1, x2, x3, deta,
            A11, A12, A13, A21, A22, A23, A31, A32, A33, M11, M12, M13, M21, M22, M23, M31, M32, M33;
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

                M11 = (a22 * a33) - (a32 * a23);
                A11 = M11 * (-1);

                M12 = (a21 * a33) - (a31 * a23);
                A12 = M12 * (-1);

                M13 = (a21 * a32) - (a31 * a22);
                A13 = M13 * (-1);

                M21 = (a12 * a33) - (a32 * a13);
                A21 = M21 * (-1);

                M22 = (a11 * a33) - (a31 * a13);
                A22 = M22 * (-1);

                M23 = (a11 * a32) - (a31 * a12);
                A23 = M23 * (-1);

                M31 = (a12 * a23) - (a22 * a13);
                A31 = M31 * (-1);

                M32 = (a11 * a23) - (a21 * a13);
                A32 = M32 * (-1);

                M33 = (a11 * a22) - (a21 * a12);
                A33 = M33 * (-1);

                double T11, T12, T13, T21, T22, T23, T31, T32, T33;

                T11 = A11 / deta; T12 = A21 / deta; T13 = A31 / deta;
                T21 = A12 / deta; T22 = A22 / deta; T23 = A23 / deta;
                T31 = A13 / deta; T32 = A32 / deta; T33 = A33 / deta;

                x1 = (T11 * b1) + (T12 * b2) + (T13 * b3);
                x2 = (T21 * b1) + (T22 * b2) + (T23 * b3);
                x3 = (T31 * b1) + (T32 * b2) + (T33 * b3);

                textBox13.Text = "Матриця алгебраїчних доповнень: " + Convert.ToString(A11) + " " + Convert.ToString(A12) + " " + Convert.ToString(A13) + " " + Convert.ToString(A21) + " " + Convert.ToString(A22) + " " + Convert.ToString(A23) + " " + Convert.ToString(A31) + " " + Convert.ToString(A32) + " " + Convert.ToString(A33) + "Обернена матриця: " + Convert.ToString(T11) + " " + Convert.ToString(T12) + " " + Convert.ToString(T13) + " " + Convert.ToString(T21) + " " + Convert.ToString(T22) + " " + Convert.ToString(T23) + " " + Convert.ToString(T31) + " " + Convert.ToString(T32) + " " + Convert.ToString(T33) + " " + "Визначники x= " + "x1= " + Convert.ToString(x1) + "x2= " + Convert.ToString(x2) + "x3= " + Convert.ToString(x3);
            }
            catch
            {
                MessageBox.Show("Не коректно введено дані!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
