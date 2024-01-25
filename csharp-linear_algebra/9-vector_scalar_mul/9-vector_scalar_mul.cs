using System;


/// <summary>
/// VectorMath class.
/// </summary>
public static class VectorMath
{

    /// <summary>
    /// Multiply Method. Takes a single vector and multplies it by a scalar.
    /// </summary>

    public static double[] Multiply(double[] vector, double scalar)
    {
        if(vector.Length > 3 || vector.Length < 2)
            return new double[] {-1};

        double[] prod = new double[vector.Length];
        for(int i = 0; i < vector.Length; i++)
            sum[i] = vector1[i] * scalar;
        return prod;
    }
}