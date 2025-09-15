using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SettingsForm : Form
    {
        public Color SelectedColor { get; private set; }
        public float Speed { get; private set; }
        public string SelectedShape { get; private set; }

        public SettingsForm(Color currentColor, float currentSpeed, string currentShape)
        {
            InitializeComponent();
            SelectedColor = currentColor;
            Speed = currentSpeed;
            SelectedShape = currentShape;
            colorPreview.BackColor = currentColor;
            speedTrackBar.Value = (int)currentSpeed;
            speedLabel.Text = $"Скорость: {currentSpeed}";
            shapeComboBox.SelectedItem = currentShape;
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    SelectedColor = colorDialog.Color;
                    colorPreview.BackColor = SelectedColor;
                }
            }
        }

        private void SpeedTrackBar_Scroll(object sender, EventArgs e)
        {
            Speed = speedTrackBar.Value;
            speedLabel.Text = $"Скорость: {Speed}";
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Speed = speedTrackBar.Value;
            SelectedShape = shapeComboBox.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}