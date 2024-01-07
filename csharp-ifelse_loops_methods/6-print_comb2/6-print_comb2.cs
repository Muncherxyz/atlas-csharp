using System;

public class Digits
{
    public static void Main(string[] args)
    {
        for(int dig = 0; dig < 9; dig++)
        {
            for(int i = dig + 1; i < 10; i++)
            {
                Console.Write("{0}{1}{2}", dig, i, dig == 8 ? "\n" : ", ");
            }
            
        }
    }
}