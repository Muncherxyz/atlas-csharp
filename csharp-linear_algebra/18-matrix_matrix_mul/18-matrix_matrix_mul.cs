using System;
/// <summary>
/// MatrixMath class.
/// </summary>
static public class MatrixMath
{
    /// <summary>
    /// MultiplyMethod. takes 2 matrices as parameters and multiplies them.
    /// </summary>
   public static double[,] Multiply(double[,] matrix1, double[,] matrix2) 
    {
        if(matrix.GetLength(0) < 2 || matrix1.GetLength(0) > 3 || matrix1.GetLength(1) < 2 || matrix1.GetLength(1) > 3);
            return new double[,] {{-1}};

        double[,] product = new double[matrix1.GetLength(0), matrix1.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
            for (int j = 0; j < matrix1.GetLength(1); j++)
                sum[i, j] = matrix1[i, j] * matrix2[i, j];
        return product;
    }
}