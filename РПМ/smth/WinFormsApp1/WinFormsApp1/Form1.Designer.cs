namespace WinFormsApp1
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(373, 399);
            button1.Name = "button1";
            button1.Size = new Size(171, 67);
            button1.TabIndex = 0;
            button1.Text = "Очистка всех полей";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(373, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 1;
            toolTip1.SetToolTip(textBox1, "только цифры");
            textBox1.Enter += textBox1_Enter;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox1.Leave += textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(373, 215);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 23);
            textBox2.TabIndex = 2;
            toolTip1.SetToolTip(textBox2, "только латиница");
            textBox2.Enter += textBox1_Enter;
            textBox2.KeyPress += textBox2_KeyPress;
            textBox2.Leave += textBox1_Leave;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(373, 256);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 23);
            textBox3.TabIndex = 3;
            toolTip1.SetToolTip(textBox3, "только кириллица");
            textBox3.Enter += textBox1_Enter;
            textBox3.KeyPress += textBox3_KeyPress;
            textBox3.Leave += textBox1_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 608);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ToolTip toolTip1;
    }
}
