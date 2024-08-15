namespace Delosi.Services
{
    public class MatrixService : IMatrixService
    {
        public int[][] RotateMatrix(int[][] matrix)
        {
            int n = matrix.Length;
            int[][] rotatedMatrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                rotatedMatrix[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    rotatedMatrix[i][j] = matrix[j][n - i - 1];
                }
            }

            return rotatedMatrix;
        }
    }
}
