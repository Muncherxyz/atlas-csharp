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

/// <summary> Interactive Interface///</summary>
public interface IInteractive
{
    /// <summary> Interact Method ///</summary>
    void Interact();
}

/// <summary> Breakable Interface ///</summary>
public interface IBreakable
{
    int durability { get; set;}
    /// <summary> /// </summary>
    void Break();
}

public interface ICollectable
{
    bool IsCollected { get; set;}
    void Collect();
}

public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability {
        get => throw new NotImplementedException();
        get => throw new NotImplementedException();
    }
    public bool isCollected {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public string name {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
}