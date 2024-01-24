using System;

/// <summary>
/// VectorMath class.
/// </summary>
public static class VectorMath
{

    /// <summary>
    /// Magnitude Method. takes an array named vector 
    /// </summary>
    /// <param name="vector"></param>
    /// <returns></returns>
       public static double Magnitude(double[] vector)
    {
        if(vector.Length > 3 || vector.Length < 2)
            return -1;
    }
}