using System;

/// <summary>
/// Public class Player created
/// </summary>
public class Player
{
    /// <summary>
    /// Three propeties added that cant be changed directly from the main file
    /// </summary>
    protected string name;
    protected float maxHp;
    protected float hp;

    /// <summary>
    /// O_o 
    /// </summary>
    public delegate void CalculateHealth(float amount);
    /// <summary>
    /// Constructor that hardcodes maxHp to 100 if its less than 0
    /// </summary>
    public Player(string name="Player", float maxHp=100f)
    {
        this.name = name;
        if(maxHp <= 0){
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.maxHp = maxHp;
        this.hp = this.maxHp;
    }
    /// Prints health similar to that of a typical HP bar
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
    }
    /// <summary>
    /// Damage Method. if damage is negative prints takes 0 damage
    /// </summary>
    public void TakeDamage(float damage)
    {
        if(damage < 0)
        {
        
            Console.WriteLine("{0} takes {1} damage!", name, damage);
            damage = 0;
        }
    }
/// <summary>
/// Heal method. if heal is negative prints heals 0 hp
/// </summary>
    public void HealDamage(float heal)
    {
        if(heal < 0)
        {
            
            Console.WriteLine("{0} heals {1} HP!", name);
            heal = 0;
        }
    }
}