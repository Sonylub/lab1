using System;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private Arr arr1, arr2;

        public Form1()
        {
            InitializeComponent();
            UpdateInterface();
        }

        private void btnGenerate1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtSize1.Text, out int size) || size <= 0)
                {
                    MessageBox.Show("������� ���������� ������ ��� ������� �������!");
                    return;
                }

                arr1 = new Arr(size);
                arr1.RndInput();
                PrintToDataGridView(arr1, dgvArray1);
                lblArray1.Text = "������ 1: " + arr1.ToString();
                UpdateInterface();
            }
            catch (MyException ex)
            {
                MessageBox.Show($"������: {ex.Message} ��������: {ex.Value}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"����� ������: {ex.Message}");
            }
        }

        private void btnGenerate2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtSize2.Text, out int size) || size <= 0)
                {
                    MessageBox.Show("������� ���������� ������ ��� ������� �������!");
                    return;
                }

                arr2 = new Arr(size);
                arr2.RndInput();
                PrintToDataGridView(arr2, dgvArray2);
                lblArray2.Text = "������ 2: " + arr2.ToString();
                UpdateInterface();
            }
            catch (MyException ex)
            {
                MessageBox.Show($"������: {ex.Message} ��������: {ex.Value}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"����� ������: {ex.Message}");
            }
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbArray1.Checked && arr1 != null)
                {
                    arr1++;
                    PrintToDataGridView(arr1, dgvArray1);
                    lblArray1.Text = "������ 1: " + arr1.ToString();
                }
                else if (rbArray2.Checked && arr2 != null)
                {
                    arr2++;
                    PrintToDataGridView(arr2, dgvArray2);
                    lblArray2.Text = "������ 2: " + arr2.ToString();
                }
                else
                {
                    MessageBox.Show("�������� ������ � ������������ ���!");
                }
            }
            catch (MyException ex)
            {
                MessageBox.Show($"������: {ex.Message} ��������: {ex.Value}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"����� ������: {ex.Message}");
            }
        }

        private void btnDecrement_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbArray1.Checked && arr1 != null)
                {
                    arr1--;
                    PrintToDataGridView(arr1, dgvArray1);
                    lblArray1.Text = "������ 1: " + arr1.ToString();
                }
                else if (rbArray2.Checked && arr2 != null)
                {
                    arr2--;
                    PrintToDataGridView(arr2, dgvArray2);
                    lblArray2.Text = "������ 2: " + arr2.ToString();
                }
                else
                {
                    MessageBox.Show("�������� ������ � ������������ ���!");
                }
            }
            catch (MyException ex)
            {
                MessageBox.Show($"������: {ex.Message} ��������: {ex.Value}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"����� ������: {ex.Message}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (arr1 == null || arr2 == null)
                {
                    MessageBox.Show("������������ ��� �������!");
                    return;
                }

                Arr result = arr1 + arr2;
                PrintToDataGridView(result, dgvResult);
                lblResult.Text = "���������: " + result.ToString();
            }
            catch (MyException ex)
            {
                MessageBox.Show($"������: {ex.Message} ��������: {ex.Value}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"����� ������: {ex.Message}");
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                if (arr1 == null || arr2 == null)
                {
                    MessageBox.Show("������������ ��� �������!");
                    return;
                }

                Arr result = arr1 - arr2;
                PrintToDataGridView(result, dgvResult);
                lblResult.Text = "���������: " + result.ToString();
            }
            catch (MyException ex)
            {
                MessageBox.Show($"������: {ex.Message} ��������: {ex.Value}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"����� ������: {ex.Message}");
            }
        }

        private void btnCountSignChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbArray1.Checked && arr1 != null)
                {
                    int signChanges = arr1.CountSignChanges();
                    lblResult.Text = $"���������� ���� ����� (������ 1): {signChanges}";
                }
                else if (rbArray2.Checked && arr2 != null)
                {
                    int signChanges = arr2.CountSignChanges();
                    lblResult.Text = $"���������� ���� ����� (������ 2): {signChanges}";
                }
                else
                {
                    MessageBox.Show("�������� ������ � ������������ ���!");
                }
            }
            catch (MyException ex)
            {
                MessageBox.Show($"������: {ex.Message} ��������: {ex.Value}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"����� ������: {ex.Message}");
            }
        }

        private void PrintToDataGridView(Arr arr, DataGridView dgv)
        {
            dgv.RowCount = 1;
            dgv.ColumnCount = arr.Size;
            for (int i = 0; i < arr.Size; i++)
                dgv.Rows[0].Cells[i].Value = arr[i];
        }

        private void UpdateInterface()
        {


            // ������ �������� �������, ���� ������ ������ � �� ������������
            bool arraySelected = (rbArray1.Checked && arr1 != null) || (rbArray2.Checked && arr2 != null);
            btnIncrement.Enabled = arraySelected;
            btnDecrement.Enabled = arraySelected;
            btnCountSignChanges.Enabled = arraySelected;

            // ������ ��� �������� � ����� ��������� �������, ���� ��� ������� �������������
            btnAdd.Enabled = arr1 != null && arr2 != null;
            btnSubtract.Enabled = arr1 != null && arr2 != null;
        }

        private void rbArray1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateInterface();
        }

        private void rbArray2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateInterface();
        }
    }
}