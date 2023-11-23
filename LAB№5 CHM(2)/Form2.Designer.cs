namespace LAB_5_CHM_2_
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button7=new Button();
            button6=new Button();
            button5=new Button();
            button4=new Button();
            button3=new Button();
            button2=new Button();
            textBox4=new TextBox();
            label6=new Label();
            textBox3=new TextBox();
            textBox2=new TextBox();
            textBox1=new TextBox();
            label5=new Label();
            label4=new Label();
            label3=new Label();
            label2=new Label();
            pictureBox1=new PictureBox();
            label1=new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location=new Point(227, 313);
            button7.Name="button7";
            button7.Size=new Size(176, 73);
            button7.TabIndex=73;
            button7.Text="Рунге-Кутта";
            button7.UseVisualStyleBackColor=true;
            button7.Click+=button7_Click;
            // 
            // button6
            // 
            button6.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location=new Point(45, 313);
            button6.Name="button6";
            button6.Size=new Size(176, 73);
            button6.TabIndex=72;
            button6.Text="Метод Ейлера-Коші";
            button6.UseVisualStyleBackColor=true;
            button6.Click+=button6_Click;
            // 
            // button5
            // 
            button5.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location=new Point(227, 234);
            button5.Name="button5";
            button5.Size=new Size(176, 73);
            button5.TabIndex=71;
            button5.Text="Модифікований метод Ейлера";
            button5.UseVisualStyleBackColor=true;
            button5.Click+=button5_Click;
            // 
            // button4
            // 
            button4.Font=new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location=new Point(45, 234);
            button4.Name="button4";
            button4.Size=new Size(176, 73);
            button4.TabIndex=70;
            button4.Text="Метод Ейлера";
            button4.UseVisualStyleBackColor=true;
            button4.Click+=button4_Click;
            // 
            // button3
            // 
            button3.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location=new Point(607, 365);
            button3.Name="button3";
            button3.Size=new Size(169, 55);
            button3.TabIndex=69;
            button3.Text="Вихід";
            button3.UseVisualStyleBackColor=true;
            button3.Click+=button3_Click;
            // 
            // button2
            // 
            button2.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location=new Point(328, 166);
            button2.Name="button2";
            button2.Size=new Size(75, 39);
            button2.TabIndex=68;
            button2.Text="С";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // textBox4
            // 
            textBox4.Location=new Point(200, 178);
            textBox4.Name="textBox4";
            textBox4.Size=new Size(29, 31);
            textBox4.TabIndex=67;
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location=new Point(152, 178);
            label6.Name="label6";
            label6.Size=new Size(42, 29);
            label6.TabIndex=66;
            label6.Text="y0:";
            // 
            // textBox3
            // 
            textBox3.Location=new Point(100, 176);
            textBox3.Name="textBox3";
            textBox3.Size=new Size(29, 31);
            textBox3.TabIndex=65;
            // 
            // textBox2
            // 
            textBox2.Location=new Point(192, 127);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(29, 31);
            textBox2.TabIndex=64;
            // 
            // textBox1
            // 
            textBox1.Location=new Point(157, 127);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(29, 31);
            textBox1.TabIndex=63;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location=new Point(227, 124);
            label5.Name="label5";
            label5.Size=new Size(21, 32);
            label5.TabIndex=62;
            label5.Text="]";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location=new Point(130, 124);
            label4.Name="label4";
            label4.Size=new Size(21, 32);
            label4.TabIndex=61;
            label4.Text="[";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location=new Point(25, 176);
            label3.Name="label3";
            label3.Size=new Size(69, 29);
            label3.TabIndex=60;
            label3.Text="Крок:";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(25, 127);
            label2.Name="label2";
            label2.Size=new Size(108, 29);
            label2.TabIndex=59;
            label2.Text="Інтервал:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image=Properties.Resources.Знімок_екрана_2023_05_08_210206;
            pictureBox1.Location=new Point(25, 63);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(378, 43);
            pictureBox1.TabIndex=58;
            pictureBox1.TabStop=false;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(142, 31);
            label1.Name="label1";
            label1.Size=new Size(135, 29);
            label1.TabIndex=57;
            label1.Text="Вид функції";
            // 
            // Form2
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name="Form2";
            Text="Вибір розв'язання простих диференційних рівнянь ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
    }
}