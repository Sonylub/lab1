namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') // цифры разрешить
                return;
            if (e.KeyChar == (char)Keys.Back) // клавишу BackSpace разрешить
                return;
            e.KeyChar = '\0'; // остальные символы не отображать
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(TextBox1.Text
            out number));
            int tens = number / 10;
            int ones = number % 10;





            try
            {
                
            }

            catch(Exception ex)
            {
                MessageBox.Show("Ты лох");
            }
        }
    }
}
