﻿using System;

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
    private string status;

    /// <summary>
    /// Eventhandler of Type CurrentHPArgs
    /// </summary>
    public EventHandler<CurrentHPArgs> HPCheck;
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
        this.status = string.Format("{0} is ready to go!", name);
        HPCheck += CheckStatus;
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
        if(damage <= 0f)
            damage = 0f;
            Console.WriteLine("{0} takes {1} damage!", name, damage);
            damage = this.hp - damage;
            ValidateHP(damage);
    
    }
/// <summary>
/// Heal method. if heal is negative prints heals 0 hp
/// </summary>
    public void HealDamage(float heal)
    {
        if(heal <= 0f)
            heal = 0f;
            Console.WriteLine("{0} heals {1} HP!", name, heal);
            heal += this.hp;
            ValidateHP(heal);
        
    }
    /// <summary>
    /// HP setter. Sets the new value of the Players HP.
    /// </summary>
    public void ValidateHP(float newHp)
    {
        if(newHp < 0)
            this.hp = 0;
        else if(newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;
        this.HPCheck(this, new CurrentHPArgs(this.hp));
    }
    /// <summary>
    /// Modifier method that calculates hit effectiveness
    /// </summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if(modifier == Modifier.Weak)
            return baseValue * .5f;
        else if(modifier == Modifier.Strong)
            return baseValue * 1.5f;
        else    
            return baseValue;
    }
    /// <summary>
    /// CheckStatus method. Tells you the current condition of the entity w/ a string that matches
    /// </summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        float currentCondition = e.currentHp/maxHp;
        if (currentCondition == 1)
            status = String.Format("{0} is in perfect health!", name);
        else if (currentCondition >=0.5f)
            status = String.Format("{0} is doing well!", name);
        else if (currentCondition >=0.25f)
            status = String.Format("{0} isnt doing too great...", name);
        else if (currentCondition >0f)
            status = String.Format("{0} needs help!", name);
        else
            status = String.Format("{0} is knocked out!", name);
    }



}

/// <summary>
/// damage modifiers
/// </summary>
public enum Modifier
{
    Weak,
    Base,
    Strong
}

/// <summary>
/// o_O
/// </summary>

public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
///  CurrentHPargs class that inherits from EventArgs
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// property for the current amount of HP, cannot be modified
    /// </summary>
    public float currentHp { get; }
    /// <summary>
    /// sets newHp value as currentHp
    /// </summary>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}
