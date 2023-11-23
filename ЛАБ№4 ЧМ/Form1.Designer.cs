namespace ЛАБ_4_ЧМ
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
            button1=new Button();
            button2=new Button();
            button3=new Button();
            button4=new Button();
            button5=new Button();
            label2=new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font=new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location=new Point(644, 399);
            button1.Name="button1";
            button1.Size=new Size(144, 39);
            button1.TabIndex=0;
            button1.Text="Вихід";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // button2
            // 
            button2.Location=new Point(113, 141);
            button2.Name="button2";
            button2.Size=new Size(230, 64);
            button2.TabIndex=1;
            button2.Text="Інтерполяція поліном Лагранжа";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // button3
            // 
            button3.Location=new Point(412, 141);
            button3.Name="button3";
            button3.Size=new Size(230, 64);
            button3.TabIndex=2;
            button3.Text="Інтерполяція формулами Ньютона";
            button3.UseVisualStyleBackColor=true;
            button3.Click+=button3_Click;
            // 
            // button4
            // 
            button4.Location=new Point(113, 235);
            button4.Name="button4";
            button4.Size=new Size(230, 64);
            button4.TabIndex=3;
            button4.Text="Лінійна апроксимація";
            button4.UseVisualStyleBackColor=true;
            button4.Click+=button4_Click;
            // 
            // button5
            // 
            button5.Location=new Point(412, 235);
            button5.Name="button5";
            button5.Size=new Size(230, 64);
            button5.TabIndex=4;
            button5.Text="Квадратична  апроксимація";
            button5.UseVisualStyleBackColor=true;
            button5.Click+=button5_Click;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location=new Point(25, 70);
            label2.Name="label2";
            label2.Size=new Size(745, 32);
            label2.TabIndex=6;
            label2.Text="Методи розв'язування інтерполяції та апроксимації функцій";
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name="Form1";
            Text="Інтерполювання та апроксимація функцій";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label2;
    }
}