using Grpc.Core;
using System.Threading.Tasks;
using MatrixMultiplicationService;

namespace GrpcServer.Services
{
    public class MatrixServiceImpl : MatrixService.MatrixServiceBase
    {
        public override Task<MultiplicationResponse> Multiply(MultiplicationRequest request, ServerCallContext context)
        {
            // Отримання матриць з запиту
            var matrixA = request.MatrixA;
            var matrixB = request.MatrixB;

            // Перевірка, чи можливе множення
            if (matrixA.Rows.Count == 0 || matrixB.Rows.Count == 0 || matrixA.Rows[0].Values.Count != matrixB.Rows.Count)
            {
                throw new RpcException(new Status(StatusCode.InvalidArgument, "Матриці не можна перемножити: невідповідні розміри."));
            }

            // Виконання множення матриць
            var resultMatrix = MultiplyMatrices(matrixA, matrixB);

            // Формування відповіді
            var response = new MultiplicationResponse { Result = resultMatrix };
            return Task.FromResult(response);
        }

        private Matrix MultiplyMatrices(Matrix matrixA, Matrix matrixB)
        {
            int rowsA = matrixA.Rows.Count;
            int colsA = matrixA.Rows[0].Values.Count;
            int colsB = matrixB.Rows[0].Values.Count;

            // Ініціалізація результатуючої матриці
            var resultMatrix = new Matrix();

            // Множення матриць
            for (int i = 0; i < rowsA; i++)
            {
                var resultRow = new Row();
                for (int j = 0; j < colsB; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        sum += matrixA.Rows[i].Values[k] * matrixB.Rows[k].Values[j];
                    }
                    resultRow.Values.Add(sum);
                }
                resultMatrix.Rows.Add(resultRow);
            }

            return resultMatrix;
        }
    }
}
