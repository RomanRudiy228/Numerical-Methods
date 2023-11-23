namespace LAB_5_CHM_2_
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
            label2=new Label();
            button2=new Button();
            button1=new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location=new Point(43, 41);
            label2.Name="label2";
            label2.Size=new Size(689, 32);
            label2.TabIndex=15;
            label2.Text="Методи розв'язування простих диференційних рівнянь ";
            // 
            // button2
            // 
            button2.Location=new Point(250, 196);
            button2.Name="button2";
            button2.Size=new Size(230, 64);
            button2.TabIndex=14;
            button2.Text="Перейти до методів";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // button1
            // 
            button1.Font=new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location=new Point(614, 370);
            button1.Name="button1";
            button1.Size=new Size(144, 39);
            button1.TabIndex=13;
            button1.Text="Вихід";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name="Form1";
            Text="Прості диференційні рівняння";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button2;
        private Button button1;
    }
}