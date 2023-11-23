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

namespace ЛАБ_4_ЧМ
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double x0 = double.Parse(textBox1.Text);
            double x1 = double.Parse(textBox2.Text);
            double x2 = double.Parse(textBox4.Text);
            double x3 = double.Parse(textBox5.Text);
            double x4 = double.Parse(textBox6.Text);
            double x = double.Parse(textBox3.Text);

            double y0 = double.Parse(textBox11.Text);
            double y1 = double.Parse(textBox10.Text);
            double y2 = double.Parse(textBox9.Text);
            double y3 = double.Parse(textBox8.Text);
            double y4 = double.Parse(textBox7.Text);

            double L;

            L = (((y0) * ((x-x1) * (x-x2) * (x-x3) * (x-x4))) / ((x0-x1) * (x0-x2) * (x0-x3) * (x0-x4))) + (((y1) * ((x-x0) * (x-x2) * (x-x3) * (x-x4))) / ((x1-x0) * (x1-x2) * (x1-x3) * (x1-x4))) + (((y2) * ((x-x0) * (x-x1) * (x-x3) * (x-x4))) / ((x2-x0) * (x2-x1) * (x2-x3) * (x2-x4))) + (((y3) * ((x-x0) * (x-x1) * (x-x2) * (x-x4))) / ((x3-x0) * (x3-x1) * (x3-x2) * (x3-x4))) + (((y4) * ((x-x0) * (x-x1) * (x-x2) * (x-x3))) / ((x4-x0) * (x4*x1) * (x4*x2) * (x4-x3)));

            MessageBox.Show("Рівняння має вигляд: " + L.ToString());
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
    }
}
