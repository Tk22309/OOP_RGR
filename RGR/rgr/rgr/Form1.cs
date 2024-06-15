namespace rgr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateMatrixButton_Click(object sender, EventArgs e)
        {
            int size;
            if (int.TryParse(parameterMatrix.Text, out size) && size > 0)
            {
                GenerateMatrix1(matrix1, size);
                GenerateMatrix2(matrix2, size);
                GenerateMatrix1(matrix3, size);
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректний розмір матриці.");
            }
        }

        private void GenerateMatrix1(DataGridView dataGridView, int size)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            for (int i = 0; i < size; i++)
            {
                dataGridView.Columns.Add("", "");
            }

            for (int i = 0; i < size; i++)
            {
                dataGridView.Rows.Add();
                for (int j = 0; j < size; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = 0;
                }
            }
        }

        private void GenerateMatrix2(DataGridView dataGridView, int size)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            dataGridView.Columns.Add("", "");

            for (int i = 0; i < size; i++)
            {
                dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[0].Value = 0;
            }
        }
        private void GenerateMatrix(DataGridView dataGridView, int size)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            // Add columns
            for (int i = 0; i < size; i++)
            {
                dataGridView.Columns.Add("", "");
            }

            // Add rows and initialize cells with 0
            for (int i = 0; i < size; i++)
            {
                dataGridView.Rows.Add();
                for (int j = 0; j < size; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = 0;
                }
            }
        }

        private void SortMatrix(DataGridView dataGridView)
        {
            List<int> values = new List<int>();

            // Collect all values from the DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        values.Add(Convert.ToInt32(cell.Value));
                    }
                }
            }

            // Sort values in ascending order
            values.Sort();

            // Fill DataGridView with sorted values
            int index = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = values[index];
                    index++;
                }
            }
        }
        private void sortMatrix_Click(object sender, EventArgs e)
        {
            SortMatrix(matrix1);
            SortMatrix(matrix2);
            SortMatrix(matrix3);
        }



        private void button2_Click(object sender, EventArgs e)
        {

            if (ValidateMatrix(matrix1) && ValidateMatrix(matrix2))
            {
                MultiplyMatrices(matrix1, matrix2, listBox_Mnoj);
            }
            else
            {
                MessageBox.Show("Матриці мають бути заповнені тільки цифрами без пустих значень.");
            }
        }
        private void MultiplyMatrices(DataGridView matrix1, DataGridView matrix2, ListBox resultListBox)
        {
            int rowsMatrix1 = matrix1.Rows.Count;
            int colsMatrix1 = matrix1.Columns.Count;
            int rowsMatrix2 = matrix2.Rows.Count;
            int colsMatrix2 = matrix2.Columns.Count;

            if (colsMatrix1 != rowsMatrix2)
            {
                MessageBox.Show("Матриці не можуть бути перемножені через невідповідність розмірів.");
                return;
            }

            int[,] resultMatrix = new int[rowsMatrix1, colsMatrix2];

            for (int i = 0; i < rowsMatrix1; i++)
            {
                for (int j = 0; j < colsMatrix2; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < colsMatrix1; k++)
                    {
                        sum += Convert.ToInt32(matrix1.Rows[i].Cells[k].Value) * Convert.ToInt32(matrix2.Rows[k].Cells[0].Value);
                    }
                    resultMatrix[i, j] = sum;
                }
            }

            resultListBox.Items.Clear();
            for (int i = 0; i < rowsMatrix1; i++)
            {
                string row = "";
                for (int j = 0; j < colsMatrix2; j++)
                {
                    row += resultMatrix[i, j] + " ";
                }
                resultListBox.Items.Add(row.Trim());
            }
        }

        private bool ValidateMatrix(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null || !int.TryParse(cell.Value.ToString(), out _))
                    {
                        return false;
                    }
                }
            }
            return true;
        }









        private void Del_Matrix_Click(object sender, EventArgs e)
        {
            ClearMatrix(matrix1);
            ClearMatrix(matrix2);
            ClearMatrix(matrix3);

        }
        private void ClearMatrix(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
        }

        private void BTN_Sum_Click(object sender, EventArgs e)
        {
            if (ValidateMatrix(matrix1) && ValidateMatrix(matrix3))
            {
                SumMatrices(matrix1, matrix3, listBox_Sum);
            }
            else
            {
                MessageBox.Show("Матриці мають бути заповнені тільки цифрами без пустих значень.");
            }

        }

        private void SumMatrices(DataGridView matrix1, DataGridView matrix3, ListBox resultListBox)
        {
            int rowsMatrix1 = matrix1.Rows.Count;
            int colsMatrix1 = matrix1.Columns.Count;
            int rowsMatrix3 = matrix3.Rows.Count;
            int colsMatrix3 = matrix3.Columns.Count;

            if (rowsMatrix1 != rowsMatrix3 || colsMatrix1 != colsMatrix3)
            {
                MessageBox.Show("Матриці повинні бути однакового розміру для додавання.");
                return;
            }

            int[,] resultMatrix = new int[rowsMatrix1, colsMatrix1];

            for (int i = 0; i < rowsMatrix1; i++)
            {
                for (int j = 0; j < colsMatrix1; j++)
                {
                    resultMatrix[i, j] = Convert.ToInt32(matrix1.Rows[i].Cells[j].Value) + Convert.ToInt32(matrix3.Rows[i].Cells[j].Value);
                }
            }

            listBox_Sum.Items.Clear();
            for (int i = 0; i < rowsMatrix1; i++)
            {
                string row = "";
                for (int j = 0; j < colsMatrix1; j++)
                {
                    row += resultMatrix[i, j] + " ";
                }
                listBox_Sum.Items.Add(row.Trim());
            }
        }

        private void BTN_Vusnuchnuk_Click(object sender, EventArgs e)
        {
            if (ValidateMatrix(matrix1))
            {
                TransposeMatrix(matrix1, listBox_Vusnuchnuk);
            }
            else
            {
                MessageBox.Show("Матриця має бути заповнена тільки цифрами без пустих значень.");
            }
        }

        private void TransposeMatrix(DataGridView matrix, ListBox resultListBox)
        {
            int rows = matrix.Rows.Count;
            int cols = matrix.Columns.Count;
            int[,] transposedMatrix = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transposedMatrix[j, i] = Convert.ToInt32(matrix.Rows[i].Cells[j].Value);
                }
            }

            resultListBox.Items.Clear();
            for (int i = 0; i < cols; i++)
            {
                string row = "";
                for (int j = 0; j < rows; j++)
                {
                    row += transposedMatrix[i, j] + " ";
                }
                resultListBox.Items.Add(row.Trim());
            }
        }

        private void BTN_Transponovanoi_Click(object sender, EventArgs e)
        {
            if (ValidateMatrix(matrix1))
            {
                double determinant = CalculateDeterminant(matrix1);
                listBox_Transponovanoi.Items.Clear();
                listBox_Transponovanoi.Items.Add($"Визначник матриці: {determinant}");
            }
            else
            {
                MessageBox.Show("Матриця має бути заповнена тільки цифрами без пустих значень.");
            }
        }
        private double CalculateDeterminant(DataGridView matrix)
        {
            int size = matrix.Rows.Count;
            int[,] arr = new int[size, size];

            // Initialize arr with matrix values
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr[i, j] = Convert.ToInt32(matrix.Rows[i].Cells[j].Value);
                }
            }

            return CalculateDeterminantRecursive(arr, size);
        }

        private double CalculateDeterminantRecursive(int[,] matrix, int size)
        {
            if (size == 1)
            {
                return matrix[0, 0]; // Base case for 1x1 matrix
            }
            else if (size == 2)
            {
                // Base case for 2x2 matrix
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            }
            else
            {
                double determinant = 0;
                int sign = 1;

                // Calculate determinant using cofactor expansion along the first row
                for (int i = 0; i < size; i++)
                {
                    int[,] subMatrix = CreateSubMatrix(matrix, size, i);
                    determinant += sign * matrix[0, i] * CalculateDeterminantRecursive(subMatrix, size - 1);
                    sign = -sign;
                }

                return determinant;
            }
        }

        private int[,] CreateSubMatrix(int[,] matrix, int size, int excludeColumn)
        {
            int[,] subMatrix = new int[size - 1, size - 1];
            int k = 0, l = 0;

            for (int i = 1; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == excludeColumn)
                    {
                        continue;
                    }
                    subMatrix[k, l++] = matrix[i, j];
                }
                k++;
                l = 0;
            }

            return subMatrix;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (ValidateMatrix(matrix1) && ValidateMatrix(matrix3))
            {
                SubtractMatrices(matrix1, matrix3, listBox_Sum);
            }
            else
            {
                MessageBox.Show("Матриці мають бути заповнені тільки цифрами без пустих значень.");
            }
        }


        private void SubtractMatrices(DataGridView matrix1, DataGridView matrix3, ListBox resultListBox)
        {
            int rowsMatrix1 = matrix1.Rows.Count;
            int colsMatrix1 = matrix1.Columns.Count;
            int rowsMatrix3 = matrix3.Rows.Count;
            int colsMatrix3 = matrix3.Columns.Count;

            if (rowsMatrix1 != rowsMatrix3 || colsMatrix1 != colsMatrix3)
            {
                MessageBox.Show("Матриці повинні бути однакового розміру для віднімання.");
                return;
            }

            int[,] resultMatrix = new int[rowsMatrix1, colsMatrix1];

            for (int i = 0; i < rowsMatrix1; i++)
            {
                for (int j = 0; j < colsMatrix1; j++)
                {
                    resultMatrix[i, j] = Convert.ToInt32(matrix1.Rows[i].Cells[j].Value) - Convert.ToInt32(matrix3.Rows[i].Cells[j].Value);
                }
            }

            resultListBox.Items.Clear();
            for (int i = 0; i < rowsMatrix1; i++)
            {
                string row = "";
                for (int j = 0; j < colsMatrix1; j++)
                {
                    row += resultMatrix[i, j] + " ";
                }
                resultListBox.Items.Add(row.Trim());
            }
        }
    }
}
