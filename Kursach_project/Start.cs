using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach_project
{
    public partial class Start : Form
    {
        Matrix matrix1 = new Matrix();
        Matrix matrix2 = new Matrix();

        public Start()
        {
            InitializeComponent();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            // Створюємо нове вікно InputForm
            InputForm inputForm = new InputForm();

            // Відображаємо нове вікно
            inputForm.Show();

            // Закриваємо поточне вікно
            Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string[] lines = System.IO.File.ReadAllLines(filePath);
                int rows = lines.Length;
                int columns = lines[0].Split(' ').Length; // Assuming space-separated values

                matrix1.setSize(matrix1, rows, columns);
                int[,] parsedMatrix = matrix1.ParseMatrix(lines);
                // Use parsedMatrix as needed
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string[] lines = System.IO.File.ReadAllLines(filePath);
                int rows = lines.Length;
                int columns = lines[0].Split(' ').Length; // Assuming space-separated values

                matrix1.setSize(matrix1, rows, columns);
                int[,] parsedMatrix = matrix2.ParseMatrix(lines);
                // Use parsedMatrix as needed
            }
        }

        private void random_btn_Click(object sender, EventArgs e)
        {
            int n = 10;
            matrix1.setSize(matrix1, n);
            matrix2.setSize(matrix2, n);
            matrix1.matrix = matrix1.GenerateRandomMatrix(n, n);
            matrix2.matrix = matrix2.GenerateRandomMatrix(n, n);
        }
    }
}
