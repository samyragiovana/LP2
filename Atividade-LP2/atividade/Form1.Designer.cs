﻿namespace atividade
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(192, 100);
            button1.Name = "button1";
            button1.Size = new Size(209, 36);
            button1.TabIndex = 0;
            button1.Text = "Calcula Area do Circulo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(192, 173);
            button2.Name = "button2";
            button2.Size = new Size(209, 34);
            button2.TabIndex = 1;
            button2.Text = "Calcula Area do Retangulo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(192, 252);
            button3.Name = "button3";
            button3.Size = new Size(209, 31);
            button3.TabIndex = 2;
            button3.Text = "Calcula Area do Triangulo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(235, 37);
            label1.Name = "label1";
            label1.Size = new Size(127, 18);
            label1.TabIndex = 3;
            label1.Text = "Calculo de Areas";
            label1.Click += label1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(249, 316);
            button4.Name = "button4";
            button4.Size = new Size(104, 29);
            button4.TabIndex = 4;
            button4.Text = "FECHAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 420);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "TABELA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button4;
    }
}