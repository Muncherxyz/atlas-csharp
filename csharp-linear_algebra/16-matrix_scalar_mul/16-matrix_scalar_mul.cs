using System;
/// <summary>
/// MatrixMath class.
/// </summary>
static public class MatrixMath
{
    /// <summary>
    /// MultiplyScalar Method. Takes a matrix and a scalar as parameters.
    /// </summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if(matrix.GetLength(0) < 2|| matrix.GetLength(0) > 3 || matrix.GetLength(1) < 2 || matrix.GetLength(1) > 3)
            return new double[,] {{-1}};

        double[,] prod = new double[matrix.GetLength(0), matrix.GetLength(1)];

        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                prod[i, j] = matrix[i, j] * scalar;
        return prod;
    }
}