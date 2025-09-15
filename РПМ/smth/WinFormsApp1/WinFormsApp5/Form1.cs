namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                linkLabel1.Text = $"Частное {(double)a / (double)b}/n";
                linkLabel1.Text = $"Целая часть от частного {a / b}/n";
                linkLabel1.Text = $"Остаток от деления {a / b}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите данные правильно");
            }

            catch(DivideByZeroException) {
                MessageBox.Show("Делить на ноль незя");
            }

            catch (OverflowException)
            {
                MessageBox.Show("Ты попуск");
            }

        }
    }
}
