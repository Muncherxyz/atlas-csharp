using System;

public static class VectorMath
{

    /// <summary>
    /// DotProduct Method.
    /// </summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {

        if(vector1.Length != vector2.Length || vector1.Length > 3 || vector1.Length < 2)
            return -1;
        double prod = 0;
        for(int i = 0; i < vector1.Length; i++)
        
            prod += vector1[i] * vector2[i];
            return prod;
    }
}
