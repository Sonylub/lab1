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
                linkLabel1.Text = $"������� {(double)a / (double)b}/n";
                linkLabel1.Text = $"����� ����� �� �������� {a / b}/n";
                linkLabel1.Text = $"������� �� ������� {a / b}";
            }
            catch (FormatException)
            {
                MessageBox.Show("������� ������ ���������");
            }

            catch(DivideByZeroException) {
                MessageBox.Show("������ �� ���� ����");
            }

            catch (OverflowException)
            {
                MessageBox.Show("�� ������");
            }

        }
    }
}
