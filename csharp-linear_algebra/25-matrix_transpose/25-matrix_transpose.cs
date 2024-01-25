using System;


/// <summary>
/// MatrixMath class.
/// </summary>
public static class MatrixMath
{

/// <summary>
/// Transpose method. Transposes a matrix.
/// </summary>


    public static double[,] Transpose(double[,] matrix)
    {
        double[,] res= new double[matrix.GetLength(1), matrix.GetLength(0)];

        for(int i = 0; i < matrix.GetLength(0); i++)
            for(int j = 0; j < matrix.GetLength(1); j++)

            res[j, i] = matrix[i, j];
        return res;
    }
}