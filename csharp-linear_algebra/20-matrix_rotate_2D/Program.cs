using System;

public static class MatrixMath

{


   public static double[,] Rotate2D(double[,] matrix, double angle)
   {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != 2 || cols != 2 )
        {
            return new double[,] {{-1}};
        }

        double[,] res = new double[2,2], rotation = new double[2,2];
        
   } 
}