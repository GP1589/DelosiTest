namespace Delosi.Validators
{
    public class MatrixValidator
    {
        public static bool IsValidMatrix(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0)
                return false;

            int length = matrix.Length;
            foreach (var row in matrix)
            {
                if (row == null || row.Length != length)
                    return false;
            }
            return true;
        }
    }
}
