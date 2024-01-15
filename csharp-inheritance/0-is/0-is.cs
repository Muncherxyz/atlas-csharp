using System;

class Obj 
{
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType() == typeof(int))
        {
            return True
        }
        else
        {
            return False
        }
    }
}