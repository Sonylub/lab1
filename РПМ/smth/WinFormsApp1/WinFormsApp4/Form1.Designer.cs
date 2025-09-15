namespace WinFormsApp4
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(242, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 127);
            panel1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(128, 52);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(40, 23);
            numericUpDown2.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(18, 52);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(40, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 22);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Секунды";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 22);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Минуты";
            // 
            // button1
            // 
            button1.Location = new Point(283, 262);
            button1.Name = "button1";
            button1.Size = new Size(125, 48);
            button1.TabIndex = 1;
            button1.Text = "Старт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 41);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Секундомер";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label1;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
    }
}
