namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolStrip1 = new ToolStrip();
            settingsToolStripButton = new ToolStripButton();
            stopToolStripButton = new ToolStripButton();
            Timer = new System.Windows.Forms.Timer(components);
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { settingsToolStripButton, stopToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(504, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // settingsToolStripButton
            // 
            settingsToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            settingsToolStripButton.Name = "settingsToolStripButton";
            settingsToolStripButton.Size = new Size(71, 22);
            settingsToolStripButton.Text = "Настройки";
            settingsToolStripButton.Click += settingsToolStripButton_Click;
            // 
            // stopToolStripButton
            // 
            stopToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            stopToolStripButton.Name = "stopToolStripButton";
            stopToolStripButton.Size = new Size(38, 22);
            stopToolStripButton.Text = "Стоп";
            stopToolStripButton.Click += stopToolStripButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 602);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Движение Фигуры";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private ToolStrip toolStrip1;
        private ToolStripButton settingsToolStripButton;
        private ToolStripButton stopToolStripButton;
        private System.Windows.Forms.Timer Timer;
    }
}