using System;

/// Abstract class
public abstract class Base
{
    /// <summary>
    /// Name Property
    /// </summary>
    public string name = null ;

    /// <summary>
    /// ToString Method
    /// </summary>
    /// <returns></returns>
    public override string ToString() => $"{this.name} is a {this.GetType()}";

}

/// <summary>
/// IInteractive Interface
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Interact Method
    /// </summary>
    void Interact();
}

/// <summary>
/// IBreakable Method
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// Durability Property
    /// </summary>
    int durability { get; set; }
    /// Break Method ///
    void break();
}

public interface ICollectable
{
    /// <summary>
    /// Collected Property
    /// </summary>
    bool isCollected { get; set; }
    /// <summary>
    /// Collect Method
    /// </summary>
    void Collect();
}

/// <summary>
/// Door Class that inherits from Base and Interfaces
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Constructor for name property
    /// </summary>
    public Door(string name = "Door") {
        this.name = name;
    }

    /// <summary>
    /// Door interaction
    /// </summary>
    public void Interact() {
        Console.WriteLine( $"You try to open the {this.name}. It's locked." );
    }
}