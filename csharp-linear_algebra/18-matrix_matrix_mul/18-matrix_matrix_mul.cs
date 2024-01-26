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
        if(matrix1.GetLength(1) != matrix2.GetLength(0))
            return new double[,] {{-1}};

        double[,] product = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
            for (int j = 0; j < matrix1.GetLength(1); j++)
                for (int k = 0; k < matrix1.GetLength(1); k++)
                    prod[i, j] += matrix1[i, j] * matrix2[k, j];
        return product;
    }
}