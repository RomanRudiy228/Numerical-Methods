namespace LAB_CM_3
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
            label3=new Label();
            button1=new Button();
            button3=new Button();
            button2=new Button();
            textBox12=new TextBox();
            label1=new Label();
            textBox1=new TextBox();
            textBox2=new TextBox();
            textBox3=new TextBox();
            label2=new Label();
            label4=new Label();
            label5=new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location=new Point(392, 187);
            label3.Name="label3";
            label3.Size=new Size(342, 64);
            label3.TabIndex=54;
            label3.Text="Метод половинного поділу\r\n              (дихотомії)";
            // 
            // button1
            // 
            button1.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location=new Point(652, 386);
            button1.Name="button1";
            button1.Size=new Size(131, 49);
            button1.TabIndex=52;
            button1.Text="Назад";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // button3
            // 
            button3.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location=new Point(255, 313);
            button3.Name="button3";
            button3.Size=new Size(82, 56);
            button3.TabIndex=37;
            button3.Text="С";
            button3.UseVisualStyleBackColor=true;
            button3.Click+=button3_Click;
            // 
            // button2
            // 
            button2.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location=new Point(12, 313);
            button2.Name="button2";
            button2.Size=new Size(152, 56);
            button2.TabIndex=36;
            button2.Text="Обчислити";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // textBox12
            // 
            textBox12.Location=new Point(38, 76);
            textBox12.Multiline=true;
            textBox12.Name="textBox12";
            textBox12.Size=new Size(246, 39);
            textBox12.TabIndex=49;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(86, 15);
            label1.Name="label1";
            label1.Size=new Size(163, 32);
            label1.TabIndex=50;
            label1.Text="Вид функції:";
            // 
            // textBox1
            // 
            textBox1.Location=new Point(105, 153);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(75, 31);
            textBox1.TabIndex=55;
            // 
            // textBox2
            // 
            textBox2.Location=new Point(105, 190);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(75, 31);
            textBox2.TabIndex=56;
            // 
            // textBox3
            // 
            textBox3.Location=new Point(105, 229);
            textBox3.Name="textBox3";
            textBox3.Size=new Size(75, 31);
            textBox3.TabIndex=57;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(56, 159);
            label2.Name="label2";
            label2.Size=new Size(43, 25);
            label2.TabIndex=58;
            label2.Text="a = ";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(56, 194);
            label4.Name="label4";
            label4.Size=new Size(45, 25);
            label4.TabIndex=59;
            label4.Text="b = ";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(56, 232);
            label5.Name="label5";
            label5.Size=new Size(43, 25);
            label5.TabIndex=60;
            label5.Text="E = ";
            // 
            // Form2
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox12);
            Controls.Add(button3);
            Controls.Add(button2);
            Name="Form2";
            Text="Метод половинного поділу(дихотомії)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button button1;
        private Button button3;
        private Button button2;
        private TextBox textBox12;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label4;
        private Label label5;
    }
}