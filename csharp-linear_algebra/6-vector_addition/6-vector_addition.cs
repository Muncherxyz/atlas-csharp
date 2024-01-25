using System;

/// <summary>
/// VectorMath class.
/// </summary>
public static class VectorMath
{

/// <summary>
/// Addition method. The method takes 2 vectors as parameters and adds them together.
/// </summary>
    public static double[] Add(double[] vector1, double vector2)
    {
        if(vector1.Length != vector2.Length || vector1.Length > 3 || vector1Length < 2)
            return new double[] {-1};

        double[] sum = new double{-1};
        for(int i = 0; i < vector1.Length; i++)
            sum[i] = vector1[i] + vector2[i];
        return sum;
    }
}