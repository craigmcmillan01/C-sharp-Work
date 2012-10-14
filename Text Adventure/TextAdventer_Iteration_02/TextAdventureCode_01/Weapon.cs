using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Weapon : Item
{
    public virtual int damage { get; set; }

    public Weapon() { }
    public Weapon(string name, int condition, int weight, int skill, int damage, int cost, bool useable)
    : base(name, condition, weight, skill, useable, cost)
    {
        this.damage = damage;
    }
    
}

