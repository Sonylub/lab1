namespace WinFormsApp1
{
    partial class SettingsForm
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
            colorPreview = new Panel();
            colorButton = new Button();
            shapeComboBox = new ComboBox();
            speedLabel = new Label();
            speedTrackBar = new TrackBar();
            okButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)speedTrackBar).BeginInit();
            SuspendLayout();
            // 
            // colorPreview
            // 
            colorPreview.BorderStyle = BorderStyle.FixedSingle;
            colorPreview.Location = new Point(20, 20);
            colorPreview.Name = "colorPreview";
            colorPreview.Size = new Size(50, 50);
            colorPreview.TabIndex = 0;
            // 
            // colorButton
            // 
            colorButton.Location = new Point(80, 20);
            colorButton.Name = "colorButton";
            colorButton.Size = new Size(150, 30);
            colorButton.TabIndex = 1;
            colorButton.Text = "Выбрать цвет";
            colorButton.UseVisualStyleBackColor = true;
            colorButton.Click += ColorButton_Click;
            // 
            // shapeComboBox
            // 
            shapeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            shapeComboBox.Items.AddRange(new object[] { "Circle", "Square", "Triangle" });
            shapeComboBox.Location = new Point(80, 60);
            shapeComboBox.Name = "shapeComboBox";
            shapeComboBox.Size = new Size(150, 23);
            shapeComboBox.TabIndex = 2;
            // 
            // speedLabel
            // 
            speedLabel.Location = new Point(80, 100);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new Size(150, 20);
            speedLabel.TabIndex = 3;
            speedLabel.Text = "Скорость: 5";
            // 
            // speedTrackBar
            // 
            speedTrackBar.Location = new Point(80, 120);
            speedTrackBar.Maximum = 20;
            speedTrackBar.Minimum = 1;
            speedTrackBar.Name = "speedTrackBar";
            speedTrackBar.Size = new Size(150, 45);
            speedTrackBar.TabIndex = 4;
            speedTrackBar.TickFrequency = 1;
            speedTrackBar.Value = 5;
            speedTrackBar.Scroll += SpeedTrackBar_Scroll;
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(80, 180);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 30);
            okButton.TabIndex = 5;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += OkButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(160, 180);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 30);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 300);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(speedTrackBar);
            Controls.Add(speedLabel);
            Controls.Add(shapeComboBox);
            Controls.Add(colorButton);
            Controls.Add(colorPreview);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)speedTrackBar).EndInit();
            ResumeLayout(false);
        }

        private Panel colorPreview;
        private Button colorButton;
        private ComboBox shapeComboBox;
        private Label speedLabel;
        private TrackBar speedTrackBar;
        private Button okButton;
        private Button cancelButton;
    }
}