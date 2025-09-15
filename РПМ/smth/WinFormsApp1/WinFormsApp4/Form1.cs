namespace WinFormsApp4
{


    public partial class Form1 : Form
    {


        private int TotalTime;
        private bool IsRunning = false;


        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;

            if (IsRunning == false)
            {
               button1.Text = "Αλÿ";
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
                numericUpDown1.Visible = false;
                numericUpDown2.Visible = false;
            }

            else
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void Updatedlabel3()
        {
            int minutes = TotalTime / 60;
            int seconds = TotalTime % 60;
            label3.Text = minutes + ":" + seconds;
        }


    }
}
