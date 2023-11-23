namespace LAB_CHM_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1=new Label();
            button1=new Button();
            button2=new Button();
            button3=new Button();
            button4=new Button();
            button5=new Button();
            button6=new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(83, 21);
            label1.Name="label1";
            label1.Size=new Size(638, 45);
            label1.TabIndex=0;
            label1.Text="Методи знаходження розв'язків СЛАР:";
            // 
            // button1
            // 
            button1.Location=new Point(12, 153);
            button1.Name="button1";
            button1.Size=new Size(237, 66);
            button1.TabIndex=1;
            button1.Text="Метод Крамера";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // button2
            // 
            button2.Location=new Point(284, 153);
            button2.Name="button2";
            button2.Size=new Size(237, 66);
            button2.TabIndex=2;
            button2.Text="Метод Гауса";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // button3
            // 
            button3.Location=new Point(167, 255);
            button3.Name="button3";
            button3.Size=new Size(237, 66);
            button3.TabIndex=3;
            button3.Text="Метод LU-розкладу";
            button3.UseVisualStyleBackColor=true;
            button3.Click+=button3_Click;
            // 
            // button4
            // 
            button4.Location=new Point(431, 255);
            button4.Name="button4";
            button4.Size=new Size(237, 66);
            button4.TabIndex=4;
            button4.Text="Метод оберненої матриці";
            button4.UseVisualStyleBackColor=true;
            button4.Click+=button4_Click;
            // 
            // button5
            // 
            button5.Location=new Point(551, 153);
            button5.Name="button5";
            button5.Size=new Size(237, 66);
            button5.TabIndex=5;
            button5.Text="Метод простої ітерації";
            button5.UseVisualStyleBackColor=true;
            button5.Click+=button5_Click;
            // 
            // button6
            // 
            button6.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location=new Point(668, 398);
            button6.Name="button6";
            button6.Size=new Size(120, 40);
            button6.TabIndex=6;
            button6.Text="Вихід";
            button6.UseVisualStyleBackColor=true;
            button6.Click+=button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name="Form1";
            Text="Знаходження розв'язку СЛАР";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}