namespace LAB_1CHM_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m, k, n, a, b, c, dm, ap, f, vp;
            try
            {
                if ((String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text)))
                {
                    MessageBox.Show("Cтрічка пуста", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                m = Convert.ToDouble(textBox2.Text);
                n = Convert.ToDouble(textBox3.Text);
                k = Convert.ToDouble(textBox4.Text);
                a = Convert.ToDouble(textBox5.Text);
                b = Convert.ToDouble(textBox6.Text);
                c = Convert.ToDouble(textBox7.Text);

                dm = Math.Sqrt((m + a)/100);

                ap = (Math.Abs((1 + Math.Sqrt(n)) / (k * k)) * dm) + (Math.Abs( 2 * (m + (Math.Sqrt(n))) / (k * k * k)) * b) + (Math.Abs((m + 1) / (k * k * (2 * (Math.Sqrt(n))))) * c);
                
                f = ((m + Math.Sqrt(n)) / (k * k));

                vp = ap / f;

                textBox8.Text = "Абсолютна похибка дорівнює: " + Convert.ToString(ap) + "Значення функції дорівнює: " + Convert.ToString(f) + "Відносна похибка дорівнює: " + Convert.ToString(vp);
            }
            catch
            {
                MessageBox.Show("Не коректно введено дані!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',') &&
            (((TextBox)sender).Text.IndexOf(",") == -1) &&
            (((TextBox)sender).Text.Length != 0)))
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
                {
                    e.Handled = true;
                }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',') &&
            (((TextBox)sender).Text.IndexOf(",") == -1) &&
            (((TextBox)sender).Text.Length != 0)))
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
                {
                    e.Handled = true;
                }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',') &&
            (((TextBox)sender).Text.IndexOf(",") == -1) &&
            (((TextBox)sender).Text.Length != 0)))
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
                {
                    e.Handled = true;
                }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',') &&
            (((TextBox)sender).Text.IndexOf(",") == -1) &&
            (((TextBox)sender).Text.Length != 0)))
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
                {
                    e.Handled = true;
                }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',') &&
            (((TextBox)sender).Text.IndexOf(",") == -1) &&
            (((TextBox)sender).Text.Length != 0)))
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
                {
                    e.Handled = true;
                }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',') &&
            (((TextBox)sender).Text.IndexOf(",") == -1) &&
            (((TextBox)sender).Text.Length != 0)))
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
                {
                    e.Handled = true;
                }
        }
    }
}