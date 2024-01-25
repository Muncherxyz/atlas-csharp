using System;


public static class MatrixMath
{


    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
            return new double[,] {{-1}};
        if (!(direction == 'x' || direction == 'y'))
            return new double[,] {{-1}};
        double[,] shear;
        if (direction == 'y')
            shear = new double[,] {{1, factor}, {0, 1}};
        else
            shear = new double[,] {{1,0}, {factor, 1}};
        return 
    }
}