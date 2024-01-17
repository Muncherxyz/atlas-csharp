using System;

/// <summary>Abstract class called Base/// </summary>
public abstract class Base
{
    /// <summary>Public property name/// </summary>
    private string name { get; set; }
/// <summary>ToString override method/// </summary>
    public override string ToString() => $"{this.name} is a {this.GetType()}";
    
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
    int durability { get; set; }
    /// <summary> /// </summary>
    void Break();
}

public interface ICollectable
{
    bool isCollected { get; set; } 
    void Collect();
}

public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
    public bool isCollected {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public string name {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
    public void Interact() { throw new NotImplementedException(); }
    public void Break() { throw new NotImplementedException(); }
    public void Collect() { throw new NotImplementedException(); }
}