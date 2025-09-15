namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the designer.
        /// </summary>
        private void InitializeComponent()
        {
            // Инициализация компонентов
            this.txtSize1 = new TextBox();
            this.txtSize2 = new TextBox();
            this.btnGenerate1 = new Button();
            this.btnGenerate2 = new Button();
            this.rbArray1 = new RadioButton();
            this.rbArray2 = new RadioButton();
            this.lblArray1 = new Label();
            this.lblArray2 = new Label();
            this.dgvArray1 = new DataGridView();
            this.dgvArray2 = new DataGridView();
            this.dgvResult = new DataGridView();
            this.lblResult = new Label();
            this.btnIncrement = new Button();
            this.btnDecrement = new Button();
            this.btnAdd = new Button();
            this.btnSubtract = new Button();
            this.btnCountSignChanges = new Button();

            // Настройка TextBox для первого массива
            this.txtSize1.Location = new System.Drawing.Point(20, 20);
            this.txtSize1.Size = new System.Drawing.Size(100, 20);
            this.txtSize1.Text = "5";

            // Настройка TextBox для второго массива
            this.txtSize2.Location = new System.Drawing.Point(140, 20);
            this.txtSize2.Size = new System.Drawing.Size(100, 20);
            this.txtSize2.Text = "5";

            // Настройка Button для генерации первого массива
            this.btnGenerate1.Location = new System.Drawing.Point(20, 50);
            this.btnGenerate1.Size = new System.Drawing.Size(100, 30);
            this.btnGenerate1.Text = "Сгенерировать 1";
            this.btnGenerate1.Click += new EventHandler(this.btnGenerate1_Click);

            // Настройка Button для генерации второго массива
            this.btnGenerate2.Location = new System.Drawing.Point(140, 50);
            this.btnGenerate2.Size = new System.Drawing.Size(100, 30);
            this.btnGenerate2.Text = "Сгенерировать 2";
            this.btnGenerate2.Click += new EventHandler(this.btnGenerate2_Click);

            // Настройка RadioButton для выбора первого массива
            this.rbArray1.Location = new System.Drawing.Point(260, 20);
            this.rbArray1.Size = new System.Drawing.Size(100, 20);
            this.rbArray1.Text = "Массив 1";
            this.rbArray1.Checked = true;
            this.rbArray1.CheckedChanged += new EventHandler(this.rbArray1_CheckedChanged);

            // Настройка RadioButton для выбора второго массива
            this.rbArray2.Location = new System.Drawing.Point(260, 50);
            this.rbArray2.Size = new System.Drawing.Size(100, 20);
            this.rbArray2.Text = "Массив 2";
            this.rbArray2.CheckedChanged += new EventHandler(this.rbArray2_CheckedChanged);

            // Настройка Label для первого массива
            this.lblArray1.Location = new System.Drawing.Point(20, 90);
            this.lblArray1.Size = new System.Drawing.Size(400, 20);
            this.lblArray1.Text = "Массив 1: ";

            // Настройка Label для второго массива
            this.lblArray2.Location = new System.Drawing.Point(20, 170);
            this.lblArray2.Size = new System.Drawing.Size(400, 20);
            this.lblArray2.Text = "Массив 2: ";

            // Настройка DataGridView для первого массива
            this.dgvArray1.Location = new System.Drawing.Point(20, 110);
            this.dgvArray1.Size = new System.Drawing.Size(400, 50);
            this.dgvArray1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Настройка DataGridView для второго массива
            this.dgvArray2.Location = new System.Drawing.Point(20, 190);
            this.dgvArray2.Size = new System.Drawing.Size(400, 50);
            this.dgvArray2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Настройка DataGridView для результата
            this.dgvResult.Location = new System.Drawing.Point(20, 270);
            this.dgvResult.Size = new System.Drawing.Size(400, 50);
            this.dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Настройка Label для результата
            this.lblResult.Location = new System.Drawing.Point(20, 250);
            this.lblResult.Size = new System.Drawing.Size(400, 20);
            this.lblResult.Text = "Результат: ";

            // Настройка Button для инкремента
            this.btnIncrement.Location = new System.Drawing.Point(20, 330);
            this.btnIncrement.Size = new System.Drawing.Size(80, 30);
            this.btnIncrement.Text = "Инкремент";
            this.btnIncrement.Click += new EventHandler(this.btnIncrement_Click);

            // Настройка Button для декремента
            this.btnDecrement.Location = new System.Drawing.Point(110, 330);
            this.btnDecrement.Size = new System.Drawing.Size(80, 30);
            this.btnDecrement.Text = "Декремент";
            this.btnDecrement.Click += new EventHandler(this.btnDecrement_Click);

            // Настройка Button для сложения
            this.btnAdd.Location = new System.Drawing.Point(200, 330);
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.Text = "Сложить";
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);

            // Настройка Button для вычитания
            this.btnSubtract.Location = new System.Drawing.Point(290, 330);
            this.btnSubtract.Size = new System.Drawing.Size(80, 30);
            this.btnSubtract.Text = "Вычесть";
            this.btnSubtract.Click += new EventHandler(this.btnSubtract_Click);

            // Настройка Button для подсчета смен знаков
            this.btnCountSignChanges.Location = new System.Drawing.Point(380, 330);
            this.btnCountSignChanges.Size = new System.Drawing.Size(80, 30);
            this.btnCountSignChanges.Text = "Смены знака";
            this.btnCountSignChanges.Click += new EventHandler(this.btnCountSignChanges_Click);

            // Добавление компонентов на форму
            this.Controls.Add(this.txtSize1);
            this.Controls.Add(this.txtSize2);
            this.Controls.Add(this.btnGenerate1);
            this.Controls.Add(this.btnGenerate2);
            this.Controls.Add(this.rbArray1);
            this.Controls.Add(this.rbArray2);
            this.Controls.Add(this.lblArray1);
            this.Controls.Add(this.lblArray2);
            this.Controls.Add(this.dgvArray1);
            this.Controls.Add(this.dgvArray2);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnIncrement);
            this.Controls.Add(this.btnDecrement);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnCountSignChanges);

            // Настройка формы
            this.Text = "Работа с массивами";
            this.Size = new System.Drawing.Size(480, 400);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        #endregion

        private TextBox txtSize1;
        private TextBox txtSize2;
        private Button btnGenerate1;
        private Button btnGenerate2;
        private RadioButton rbArray1;
        private RadioButton rbArray2;
        private Label lblArray1;
        private Label lblArray2;
        private DataGridView dgvArray1;
        private DataGridView dgvArray2;
        private DataGridView dgvResult;
        private Label lblResult;
        private Button btnIncrement;
        private Button btnDecrement;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnCountSignChanges;
    }
}