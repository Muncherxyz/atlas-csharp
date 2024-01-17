using System;

/// Abstract class named Base
public abstract class Base
{
    /// <summary>Name Property</summary>
    public string name = null ;

    /// <summary>
    /// ToString method overriden
    /// </summary>
    public override string ToString() => $"{this.name} is a {this.GetType()}";
        
}
/// <summary>IInteractive Interface</summary>
public interface IInteractive
{
    /// <summary>Interact Method</summary>
    void Interact();
}
/// <summary>IBreakable Interface</summary>
public interface IBreakable
{
    /// <summary>Durability Property</summary>
    int durability { get; set; }
    /// <summary>Break mMethod</summary>
    void Break();
}
/// <summary>ICollectable Interface</summary>
public interface ICollectable
{
    /// <summary>Collected Property</summary>
    bool isCollected { get; set; }
    /// <summary>Collect Method</summary>
    void Collect();
}

/// <summary>Door class that inherits from Base and IInteractive.</summary>
public class Door : Base, IInteractive
{
    /// <summary>Constructor to set name property</summary>
    public Door(string name = "Door") {
        this.name = name;
    }

    /// <summary>Interaction with door</summary>
    public void Interact() {
        Console.WriteLine( $"You try to open the {this.name}. It's locked." );
    }
    
}

/// <summary>Decoration class that inherits from Base, and 2 Interfaces.</summary>
class Decoration : Base, IInteractive, IBreakable
{
    ///<summary>Durability Property</summary>
    public int durability { get; set; }
    ///<summary>isQuestItem Property</summary>
    public bool isQuestItem;

    /// <summary>Constructor </summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false) {
        this.name = name;
        this.durability = durability > 0 ? durability : throw new Exception("Durability must be greater than 0") ;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>Interact() method</summary>
    public void Interact() {
        if(durability <= 0) {
            Console.WriteLine($"The {this.name} has been broken.");
        }
        else if (isQuestItem) {
            Console.WriteLine($"You look at the {this.name}. There's a key inside.");
        }
        else { 
            Console.WriteLine($"You look at the {this.name}. Not much to see here.") ;
        }
    }

    /// <summary>Break() method</summary>
    public void Break() {
        // decrement durability
        durability--;
        if(durability > 0) {
            Console.WriteLine($"You hit the {this.name}. It cracks.");
        }
        if (durability == 0) {
            Console.WriteLine($"You smash the {this.name}. What a mess.");
        } else if (durability < 0) {
            Console.WriteLine($"The {this.name} is already broken.");
        }
    }

}