using Grpc.Net.Client;
using MatrixMultiplicationService;
using System.Diagnostics;

namespace App_console_multiple_matrix
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Matrix matrix1 = new Matrix();
            Matrix matrix2 = new Matrix();

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Яким способом ви хочете ввести матрицю? \n \t0 - З файлів *.txt \n \t1 - Згенерувати випадково \n ");

            string inputMethod = Console.ReadLine();

            try
            {
                switch (inputMethod)
                {
                    case "0":
                        Console.WriteLine("Виберіть повний шлях до файлу для матриці 1:");

                        matrix1 = Matrix.InputFromFile(matrix1);
                        Console.WriteLine("Виберіть повний шлях до файлу для матриці 2:");

                        matrix2 = Matrix.InputFromFile(matrix2);
                        Matrix.PrintMatrix(matrix1, matrix2);
                        break;
                    case "1":
                        Console.WriteLine("Введіть розмір матриці 1: \n\t\tm: ");
                        int m = int.Parse(Console.ReadLine());
                        Console.WriteLine("\t\tn: ");
                        int n = int.Parse(Console.ReadLine());
                        matrix1.setSize(matrix1, m, n);
                        matrix1.matrix = matrix1.GenerateRandomMatrix(m, n);

                        Console.WriteLine("Введіть розмір матриці 2:\n\t\tm:");
                        m = int.Parse(Console.ReadLine());
                        Console.WriteLine("\t\tn:");
                        n = int.Parse(Console.ReadLine());
                        matrix2.setSize(matrix2, m, n);
                        matrix2.matrix = matrix2.GenerateRandomMatrix(m, n);

                        Matrix.PrintMatrix(matrix1, matrix2);
                        break;
                    default:
                        Console.WriteLine("Вибачте, але такого варіанту немає!");
                        Main(args);
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Виникла проблема спробуйте ще раз!");
                Main(args);
                throw;
            }
            
            var channel = GrpcChannel.ForAddress("https://localhost:7042", new GrpcChannelOptions
            {
                MaxReceiveMessageSize = 5 * 1024 * 1024 // 5 MB
            });
            var client = new MatrixService.MatrixServiceClient(channel);
            var matrixA = ConvertToServiceMatrix(matrix1);
            var matrixB = ConvertToServiceMatrix(matrix2);

            var request = new MultiplicationRequest { MatrixA = matrixA, MatrixB = matrixB };
            var response = await client.MultiplyAsync(request);
            if (response.Result.Rows.Count <= 15)
            {
                Console.WriteLine("_____________________________Результат:_____________________________\n\n");
                foreach (var row in response.Result.Rows)
                {
                    Console.WriteLine(string.Join("  ", row.Values));
                }
                createResultFile(response);
            }
            else
            {
                Console.WriteLine("\nРезультатна матриця занадто велика для виведення на екран");
                createResultFile(response);
            }

            Console.ReadKey();
        }

        private static MatrixMultiplicationService.Matrix ConvertToServiceMatrix(App_console_multiple_matrix.Matrix matrix)
        {
            var serviceMatrix = new MatrixMultiplicationService.Matrix();

            for (int i = 0; i < matrix.matrix.GetLength(0); i++) // Assuming matrix.matrix is double[,]
            {
                var serviceRow = new MatrixMultiplicationService.Row();
                for (int j = 0; j < matrix.matrix.GetLength(1); j++)
                {
                    serviceRow.Values.Add(matrix.matrix[i, j]);
                }
                serviceMatrix.Rows.Add(serviceRow);
            }
            return serviceMatrix;
        }
        public static void createResultFile(MultiplicationResponse response)
        {
            // Запит шляху для збереження файлу
            Console.WriteLine("\n \t\t Результатна матриця буде записана в файл result.txt\n \nВведіть шлях для збереження файлу");
            string path = Console.ReadLine();

            // Додаємо назву файлу до шляху
            path = Path.Combine(path, "result.txt");

            // Перевірка існування директорії, створення якщо немає
            string directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            try
            {
                // Запис у файл
                using (StreamWriter file = new StreamWriter(path))
                {
                    foreach (var row in response.Result.Rows)
                    {
                        file.WriteLine(string.Join("  ", row.Values));
                    }
                }

                Console.WriteLine("Файл успішно збережено!");

                // Відкриття файлу в Notepad
                Process.Start("notepad.exe", path);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Сталася помилка: " + ex.Message);
            }
        }
    }
}
