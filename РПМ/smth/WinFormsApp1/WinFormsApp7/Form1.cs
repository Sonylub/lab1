using System.Drawing.Printing;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                return;
            if (e.KeyChar == (char)Keys.Back)
                return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int sum;
            int product;
            int devide;
            int minus;
            if (int.TryParse(textBox1.Text,out a) && int.TryParse(textBox2.Text, out b))
            {
                sum = a+b;
                product = b*a;
                devide = a/b;
                minus = a-b;
                label1.Text = $"{a} + {b} = {sum}\n" +
                              $"{a} - {b} = {minus}\n" +
                              $"{a} * {b} = {product}\n" +
                              $"{a} : {b} = {devide}";
            }
        }
    }
}
