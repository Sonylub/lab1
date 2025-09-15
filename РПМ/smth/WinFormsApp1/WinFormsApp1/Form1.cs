namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Pink;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                return;
            {
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'A') && e.KeyChar <= 'Z');
            return;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'À' && e.KeyChar <= 'ÿ')
                return;
        }
    }
