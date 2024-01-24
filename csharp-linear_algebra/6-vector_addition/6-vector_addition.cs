using System;

/// <summary>
/// VectorMath class.
/// </summary>
public static class VectorMath
{

/// <summary>
/// Addition method. The method takes 2 vectors as parameters and adds them together.
/// </summary>
    public static double Add(double[] vector1, double[] vector2)
    {
            double[] len = vector1.Length;

    if (len < 2 || len > 3 || len != vector2.Length)
        return new double[] {-1};

       double[] sum = new double[len];

       for (int i = 0; i < len; i++)
            sum[i] = vector1[i] + vector2[i];
        return sum; 
    }

}