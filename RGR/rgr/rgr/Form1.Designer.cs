namespace rgr
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            parameterMatrix = new TextBox();
            createMatrixButton = new Button();
            matrix1 = new DataGridView();
            matrix2 = new DataGridView();
            BTN_Sum = new Button();
            BTN_Mnoj = new Button();
            BTN_Transponovanoi = new Button();
            BTN_Vusnuchnuk = new Button();
            sortMatrix = new Button();
            matrix3 = new DataGridView();
            listBox_Mnoj = new ListBox();
            listBox_Vusnuchnuk = new ListBox();
            listBox_Transponovanoi = new ListBox();
            Del_Matrix = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            listBox_Sum = new ListBox();
            minus = new Button();
            ((System.ComponentModel.ISupportInitialize)matrix1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)matrix2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)matrix3).BeginInit();
            SuspendLayout();
            // 
            // parameterMatrix
            // 
            parameterMatrix.Location = new Point(12, 97);
            parameterMatrix.Name = "parameterMatrix";
            parameterMatrix.Size = new Size(100, 23);
            parameterMatrix.TabIndex = 0;
            // 
            // createMatrixButton
            // 
            createMatrixButton.Location = new Point(118, 97);
            createMatrixButton.Name = "createMatrixButton";
            createMatrixButton.Size = new Size(150, 23);
            createMatrixButton.TabIndex = 1;
            createMatrixButton.Text = "Створити матрицю";
            createMatrixButton.UseVisualStyleBackColor = true;
            createMatrixButton.Click += CreateMatrixButton_Click;
            // 
            // matrix1
            // 
            matrix1.AllowUserToAddRows = false;
            matrix1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            matrix1.Location = new Point(12, 224);
            matrix1.Name = "matrix1";
            matrix1.RowHeadersWidth = 51;
            matrix1.RowTemplate.Height = 24;
            matrix1.Size = new Size(256, 240);
            matrix1.TabIndex = 2;
            // 
            // matrix2
            // 
            matrix2.AllowUserToAddRows = false;
            matrix2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            matrix2.Location = new Point(575, 167);
            matrix2.Name = "matrix2";
            matrix2.RowHeadersWidth = 51;
            matrix2.RowTemplate.Height = 24;
            matrix2.Size = new Size(209, 240);
            matrix2.TabIndex = 3;
            // 
            // BTN_Sum
            // 
            BTN_Sum.Location = new Point(301, 43);
            BTN_Sum.Name = "BTN_Sum";
            BTN_Sum.Size = new Size(240, 56);
            BTN_Sum.TabIndex = 4;
            BTN_Sum.Text = "додавання двох матриць matrix1 та matrix3";
            BTN_Sum.UseVisualStyleBackColor = true;
            BTN_Sum.Click += BTN_Sum_Click;
            // 
            // BTN_Mnoj
            // 
            BTN_Mnoj.Location = new Point(575, 97);
            BTN_Mnoj.Name = "BTN_Mnoj";
            BTN_Mnoj.Size = new Size(209, 56);
            BTN_Mnoj.TabIndex = 5;
            BTN_Mnoj.Text = "множення матриці matrix1 на matrix2";
            BTN_Mnoj.UseVisualStyleBackColor = true;
            BTN_Mnoj.Click += button2_Click;
            // 
            // BTN_Transponovanoi
            // 
            BTN_Transponovanoi.Location = new Point(1112, 97);
            BTN_Transponovanoi.Name = "BTN_Transponovanoi";
            BTN_Transponovanoi.Size = new Size(185, 56);
            BTN_Transponovanoi.TabIndex = 6;
            BTN_Transponovanoi.Text = "знаходження транспонованої матриці matrix1";
            BTN_Transponovanoi.UseVisualStyleBackColor = true;
            BTN_Transponovanoi.Click += BTN_Transponovanoi_Click;
            // 
            // BTN_Vusnuchnuk
            // 
            BTN_Vusnuchnuk.Location = new Point(851, 97);
            BTN_Vusnuchnuk.Name = "BTN_Vusnuchnuk";
            BTN_Vusnuchnuk.Size = new Size(185, 56);
            BTN_Vusnuchnuk.TabIndex = 7;
            BTN_Vusnuchnuk.Text = "обчислення визначника матриці matrix1";
            BTN_Vusnuchnuk.UseVisualStyleBackColor = true;
            BTN_Vusnuchnuk.Click += BTN_Vusnuchnuk_Click;
            // 
            // sortMatrix
            // 
            sortMatrix.Location = new Point(118, 167);
            sortMatrix.Name = "sortMatrix";
            sortMatrix.Size = new Size(150, 40);
            sortMatrix.TabIndex = 8;
            sortMatrix.Text = "Відсортувати по зростанню";
            sortMatrix.UseVisualStyleBackColor = true;
            sortMatrix.Click += sortMatrix_Click;
            // 
            // matrix3
            // 
            matrix3.AllowUserToAddRows = false;
            matrix3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            matrix3.Location = new Point(301, 167);
            matrix3.Name = "matrix3";
            matrix3.RowHeadersWidth = 51;
            matrix3.RowTemplate.Height = 24;
            matrix3.Size = new Size(240, 240);
            matrix3.TabIndex = 2;
            // 
            // listBox_Mnoj
            // 
            listBox_Mnoj.FormattingEnabled = true;
            listBox_Mnoj.ItemHeight = 15;
            listBox_Mnoj.Location = new Point(575, 447);
            listBox_Mnoj.Name = "listBox_Mnoj";
            listBox_Mnoj.Size = new Size(209, 154);
            listBox_Mnoj.TabIndex = 10;
            // 
            // listBox_Vusnuchnuk
            // 
            listBox_Vusnuchnuk.FormattingEnabled = true;
            listBox_Vusnuchnuk.ItemHeight = 15;
            listBox_Vusnuchnuk.Location = new Point(851, 205);
            listBox_Vusnuchnuk.Name = "listBox_Vusnuchnuk";
            listBox_Vusnuchnuk.Size = new Size(185, 259);
            listBox_Vusnuchnuk.TabIndex = 12;
            // 
            // listBox_Transponovanoi
            // 
            listBox_Transponovanoi.FormattingEnabled = true;
            listBox_Transponovanoi.ItemHeight = 15;
            listBox_Transponovanoi.Location = new Point(1112, 205);
            listBox_Transponovanoi.Name = "listBox_Transponovanoi";
            listBox_Transponovanoi.Size = new Size(185, 259);
            listBox_Transponovanoi.TabIndex = 13;
            // 
            // Del_Matrix
            // 
            Del_Matrix.Location = new Point(118, 126);
            Del_Matrix.Name = "Del_Matrix";
            Del_Matrix.Size = new Size(150, 35);
            Del_Matrix.TabIndex = 14;
            Del_Matrix.Text = "Видалити матриці";
            Del_Matrix.UseVisualStyleBackColor = true;
            Del_Matrix.Click += Del_Matrix_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 58);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 15;
            label1.Text = "Створення матриці";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 25);
            label2.Name = "label2";
            label2.Size = new Size(161, 15);
            label2.TabIndex = 16;
            label2.Text = "1) додавання двох матриць; ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(575, 58);
            label3.Name = "label3";
            label3.Size = new Size(209, 15);
            label3.TabIndex = 17;
            label3.Text = "2) множення однієї матриці на іншу;";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(851, 58);
            label4.Name = "label4";
            label4.Size = new Size(239, 15);
            label4.TabIndex = 18;
            label4.Text = " 3) знаходження транспонованої матриці; ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1112, 58);
            label5.Name = "label5";
            label5.Size = new Size(204, 15);
            label5.TabIndex = 19;
            label5.Text = "4) обчислення визначника матриці.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(879, 180);
            label6.Name = "label6";
            label6.Size = new Size(126, 15);
            label6.TabIndex = 20;
            label6.Text = "Результат обчислень:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1140, 180);
            label7.Name = "label7";
            label7.Size = new Size(126, 15);
            label7.TabIndex = 21;
            label7.Text = "Результат обчислень:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(355, 420);
            label8.Name = "label8";
            label8.Size = new Size(126, 15);
            label8.TabIndex = 22;
            label8.Text = "Результат обчислень:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(608, 420);
            label9.Name = "label9";
            label9.Size = new Size(126, 15);
            label9.TabIndex = 23;
            label9.Text = "Результат обчислень:";
            // 
            // listBox_Sum
            // 
            listBox_Sum.FormattingEnabled = true;
            listBox_Sum.ItemHeight = 15;
            listBox_Sum.Location = new Point(301, 447);
            listBox_Sum.Name = "listBox_Sum";
            listBox_Sum.Size = new Size(240, 154);
            listBox_Sum.TabIndex = 11;
            // 
            // minus
            // 
            minus.Location = new Point(301, 105);
            minus.Name = "minus";
            minus.Size = new Size(240, 56);
            minus.TabIndex = 24;
            minus.Text = "віднімання двох матриць matrix1 та matrix3";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(1368, 613);
            Controls.Add(minus);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Del_Matrix);
            Controls.Add(listBox_Transponovanoi);
            Controls.Add(listBox_Vusnuchnuk);
            Controls.Add(listBox_Sum);
            Controls.Add(listBox_Mnoj);
            Controls.Add(matrix3);
            Controls.Add(sortMatrix);
            Controls.Add(BTN_Vusnuchnuk);
            Controls.Add(BTN_Transponovanoi);
            Controls.Add(BTN_Mnoj);
            Controls.Add(BTN_Sum);
            Controls.Add(matrix2);
            Controls.Add(matrix1);
            Controls.Add(createMatrixButton);
            Controls.Add(parameterMatrix);
            Name = "Form1";
            Text = "Matrix Calculater";
            ((System.ComponentModel.ISupportInitialize)matrix1).EndInit();
            ((System.ComponentModel.ISupportInitialize)matrix2).EndInit();
            ((System.ComponentModel.ISupportInitialize)matrix3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.TextBox parameterMatrix;
        private System.Windows.Forms.Button createMatrixButton;
        private System.Windows.Forms.DataGridView matrix1;
        private System.Windows.Forms.DataGridView matrix2;
        private Button BTN_Sum;
        private Button BTN_Mnoj;
        private Button BTN_Transponovanoi;
        private Button BTN_Vusnuchnuk;
        private Button sortMatrix;
        private DataGridView matrix3;
        private ListBox listBox_Mnoj;
        private ListBox listBox_Vusnuchnuk;
        private ListBox listBox_Transponovanoi;
        private Button Del_Matrix;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ListBox listBox_Sum;
        private Button minus;
    }
}