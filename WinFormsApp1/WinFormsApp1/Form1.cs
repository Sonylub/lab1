using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private float x, y; // Координаты центра фигуры
        private float vx, vy; // Скорость по осям
        private int size = 20; // Размер фигуры (диаметр/сторона)
        private Color shapeColor = Color.Red;
        private string shapeType = "Circle"; // Тип фигуры: Circle, Square, Triangle
        private Random rand = new Random();
        private float speed = 5f; // Базовая скорость
        private bool isRunning = true; // Флаг для отслеживания состояния движения

        public Form1()
        {
            InitializeComponent();
            Timer.Interval = 16; // ~60 FPS
            Timer.Tick += Timer_Tick;
            Timer.Start();

            // Начальная позиция в центре
            x = ClientSize.Width / 2;
            y = ClientSize.Height / 2;

            // Случайное начальное направление
            float angle = (float)(rand.NextDouble() * 2 * Math.PI);
            vx = speed * (float)Math.Cos(angle);
            vy = speed * (float)Math.Sin(angle);

            this.DoubleBuffered = true;
            this.KeyDown += Form1_KeyDown;
            this.Resize += Form1_Resize;

            // Начальная установка текста кнопки
            stopToolStripButton.Text = "Стоп";
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Ограничиваем позицию при изменении размера формы
            x = Math.Max(size / 2, Math.Min(ClientSize.Width - size / 2, x));
            y = Math.Max(size / 2, Math.Min(ClientSize.Height - size / 2, y));
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close(); // Завершение программы по Esc
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!isRunning) return;

            // Обновляем позицию
            x += vx;
            y += vy;

            // Проверка столкновений с границами
            if (x - size / 2 < 0 || x + size / 2 > ClientSize.Width)
            {
                vx = -vx; // Отскок по X
                x = Math.Max(size / 2, Math.Min(ClientSize.Width - size / 2, x)); // Коррекция позиции
            }
            if (y - size / 2 < 0 || y + size / 2 > ClientSize.Height)
            {
                vy = -vy; // Отскок по Y
                y = Math.Max(size / 2, Math.Min(ClientSize.Height - size / 2, y)); // Коррекция позиции
            }

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (SolidBrush brush = new SolidBrush(shapeColor))
            {
                if (shapeType == "Circle")
                {
                    e.Graphics.FillEllipse(brush, x - size / 2, y - size / 2, size, size);
                }
                else if (shapeType == "Square")
                {
                    e.Graphics.FillRectangle(brush, x - size / 2, y - size / 2, size, size);
                }
                else if (shapeType == "Triangle")
                {
                    PointF[] points = new PointF[]
                    {
                        new PointF(x, y - size / 2), // Верх
                        new PointF(x - size / 2, y + size / 2), // Низ лево
                        new PointF(x + size / 2, y + size / 2) // Низ право
                    };
                    e.Graphics.FillPolygon(brush, points);
                }
            }
        }

        private void settingsToolStripButton_Click(object sender, EventArgs e)
        {
            using (SettingsForm settings = new SettingsForm(shapeColor, speed, shapeType))
            {
                if (settings.ShowDialog() == DialogResult.OK)
                {
                    shapeColor = settings.SelectedColor;
                    speed = settings.Speed;
                    shapeType = settings.SelectedShape;

                    // Обновляем скорость с учетом текущего направления
                    float currentSpeed = (float)Math.Sqrt(vx * vx + vy * vy);
                    if (currentSpeed > 0)
                    {
                        vx = vx / currentSpeed * speed;
                        vy = vy / currentSpeed * speed;
                    }
                    else
                    {
                        float angle = (float)(rand.NextDouble() * 2 * Math.PI);
                        vx = speed * (float)Math.Cos(angle);
                        vy = speed * (float)Math.Sin(angle);
                    }

                    Invalidate();
                }
            }
        }

        private void stopToolStripButton_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                Timer.Stop();
                isRunning = false;
                stopToolStripButton.Text = "Продолжить";
            }
            else
            {
                Timer.Start();
                isRunning = true;
                stopToolStripButton.Text = "Стоп";
            }
        }
    }
}