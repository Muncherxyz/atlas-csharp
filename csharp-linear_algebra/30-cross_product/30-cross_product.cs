﻿using System;


/// <summary>
/// VectorMath class.
/// </summary>
public static class VectorMath
{

/// <summary>
/// CrossProduct method. takes 2 vectors as parameters
/// </summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != 3 || vector2.Length != 3)
            return new double[] {-1, -1, -1};

        
        double[] res = new double[3];
        res[0] = vector1[1] * vector2[2] - vector1[2] * vector2[1];
        res[1] = vector1[2] * vector2[0] - vector1[0] * vector2[2];
        res[2] = vector1[0] * vector2[1] - vector1[1] * vector2[0];
        return res;
    }
}