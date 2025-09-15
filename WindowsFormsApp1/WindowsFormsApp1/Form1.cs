using System; // Базовые классы .NET
using System.Collections.Generic; // Для List<Student>
using System.IO; // Для работы с файлами
using System.Linq; // Для Average
using System.Text.RegularExpressions; // Для регулярных выражений
using System.Windows.Forms; // Для Windows Forms

namespace Lab10 // Пространство имен приложения
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>(); // Список студентов

        public Form1()
        {
            InitializeComponent(); // Инициализация компонентов формы
        }

        // Добавление студента
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return; // Проверка ввода
            students.Add(new Student(txtName.Text.Trim(), (double)nudWeight.Value, (double)nudHeight.Value)); // Добавляем студента
            UpdateUI(); // Обновляем интерфейс
        }

        // Удаление студента
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex == -1) // Если студент не выбран
            {
                MessageBox.Show("Выберите студента!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            students.RemoveAll(s => s.Name == lstStudents.SelectedItem.ToString()); // Удаляем студента
            UpdateUI(); // Обновляем интерфейс
        }

        // Редактирование студента
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex == -1 || !ValidateInput()) // Проверка выбора и ввода
            {
                MessageBox.Show("Выберите студента и заполните поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            students[lstStudents.SelectedIndex] = new Student(txtName.Text.Trim(), (double)nudWeight.Value, (double)nudHeight.Value); // Обновляем данные
            UpdateUI(); // Обновляем интерфейс
        }

        // Сброс данных
        private void btnReset_Click(object sender, EventArgs e)
        {
            students.Clear(); // Очищаем список
            UpdateUI(); // Обновляем интерфейс
        }

        // Сохранение данных в файл
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return; // Если файл не выбран
            try
            {
                File.WriteAllLines(saveFileDialog1.FileName, students.Select(s => s.ToString())); // Записываем данные
                MessageBox.Show("Данные сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Загрузка данных из файла
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return; // Если файл не выбран
            try
            {
                students.Clear(); // Очищаем текущий список
                var regex = new Regex(@"ФИО: (?<Name>.*); Вес: (?<Weight>.*); Рост: (?<Height>.*)");
                foreach (string line in File.ReadAllLines(openFileDialog1.FileName))
                {
                    var match = regex.Match(line);
                    if (match.Success)
                        students.Add(new Student(match.Groups["Name"].Value.Trim(), double.Parse(match.Groups["Weight"].Value), double.Parse(match.Groups["Height"].Value)));
                }
                UpdateUI(); // Обновляем интерфейс
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обновление полей ввода при выборе текста в RichTextBox
        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength == 0) return; // Если текст не выделен
            var regex = new Regex(@"ФИО: (?<Name>.*); Вес: (?<Weight>.*); Рост: (?<Height>.*)");
            var match = regex.Match(richTextBox1.SelectedText.Trim());
            if (match.Success)
            {
                txtName.Text = match.Groups["Name"].Value.Trim(); // Заполняем имя
                nudWeight.Value = decimal.Parse(match.Groups["Weight"].Value); // Заполняем вес
                nudHeight.Value = decimal.Parse(match.Groups["Height"].Value); // Заполняем рост
                lstStudents.SelectedItem = match.Groups["Name"].Value.Trim(); // Выбираем в ListBox
            }
            else
                ClearInputs(); // Очищаем поля, если формат некорректен
        }

        // Обновление RichTextBox при выборе студента в ListBox
        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear(); // Очищаем RichTextBox
            if (lstStudents.SelectedIndex == -1) // Если студент не выбран
            {
                UpdateRichTextBox(); // Показываем всех студентов
                return;
            }
            var student = students[lstStudents.SelectedIndex]; // Получаем выбранного студента
            richTextBox1.AppendText($"ФИО: {student.Name}\nВес: {student.Weight:F2} кг\nРост: {student.Height:F2} см\n"); // Выводим данные
        }

        // Валидация ввода имени (только русские буквы и пробелы)
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !Regex.IsMatch(e.KeyChar.ToString(), @"[а-яА-Я\s]"))
                e.Handled = true; // Блокируем недопустимые символы
        }

        // Проверка корректности ввода
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || nudWeight.Value <= 0 || nudHeight.Value <= 0)
            {
                MessageBox.Show("Заполните все поля корректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Ввод некорректен
            }
            return true; // Ввод корректен
        }

        // Обновление интерфейса (ListBox и RichTextBox)
        private void UpdateUI()
        {
            lstStudents.Items.Clear(); // Очищаем ListBox
            lstStudents.Items.AddRange(students.Select(s => s.Name).ToArray()); // Заполняем именами
            UpdateRichTextBox(); // Обновляем RichTextBox
            ClearInputs(); // Очищаем поля ввода
        }

        // Обновление RichTextBox
        private void UpdateRichTextBox()
        {
            richTextBox1.Clear(); // Очищаем RichTextBox
            foreach (var s in students)
                richTextBox1.AppendText($"{s.ToString()}\n"); // Выводим данные студентов
            if (students.Any()) // Если есть студенты
                richTextBox1.AppendText($"\nСредний вес: {students.Average(s => s.Weight):F2} кг\nСредний рост: {students.Average(s => s.Height):F2} см"); // Выводим статистику
        }

        // Очистка полей ввода
        private void ClearInputs()
        {
            txtName.Clear(); // Очищаем поле имени
            nudWeight.Value = nudWeight.Minimum; // Сбрасываем вес
            nudHeight.Value = nudHeight.Minimum; // Сбрасываем рост
        }

        // Запрос сохранения при закрытии формы
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (students.Any() && MessageBox.Show("Сохранить данные?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                btnSave_Click(sender, e); // Сохраняем данные, если выбрано "Да"
            else if (e.CloseReason == CloseReason.UserClosing && students.Any() && MessageBox.Show("Сохранить данные?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true; // Отменяем закрытие, если выбрано "Отмена"
        }

        // Пустой обработчик события
        private void groupBoxInput_Enter(object sender, EventArgs e) { } // Не используется
    }
}