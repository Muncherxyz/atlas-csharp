using System;

/// <summary>Abstract class called Base/// </summary>
public abstract class Base
{
    /// <summary>Public property name/// </summary>
    public string name;
/// <summary>ToString override method/// </summary>
    public override string ToString()
    {
        return string.Format("{0} is {1}", name, this.GetType().ToString());
    }
}