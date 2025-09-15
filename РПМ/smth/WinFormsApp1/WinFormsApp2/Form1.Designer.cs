namespace WinFormsApp2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(216, 112);
            label1.Name = "label1";
            label1.Size = new Size(156, 156);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.MouseEnter += label1_MouseEnter;
            label1.MouseLeave += label1_MouseLeave;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(479, 112);
            label2.Name = "label2";
            label2.Size = new Size(156, 156);
            label2.TabIndex = 1;
            label2.Text = "label2";
            label2.MouseEnter += label1_MouseEnter;
            label2.MouseLeave += label1_MouseLeave;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(216, 289);
            label3.Name = "label3";
            label3.Size = new Size(156, 156);
            label3.TabIndex = 2;
            label3.Text = "label3";
            label3.MouseEnter += label1_MouseEnter;
            label3.MouseLeave += label1_MouseLeave;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(475, 289);
            label4.Name = "label4";
            label4.Size = new Size(156, 156);
            label4.TabIndex = 3;
            label4.Text = "label4";
            label4.MouseEnter += label1_MouseEnter;
            label4.MouseLeave += label1_MouseLeave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 529);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 4;
            label5.Text = "label5";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 616);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
