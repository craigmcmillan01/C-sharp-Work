﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Weapon
{
    public virtual int damage { get; set; }
    public virtual int condition { get; set; }
    public virtual int skill { get; set; }
    public virtual Humanoid Humanoid { get; set; }
    public virtual string name { get; set; }

    public Weapon() { }
    public Weapon(string name, int damage, int condition, int skill)
    {
        this.name = name;
        this.damage = damage;
        this.condition = condition;
        this.skill = skill;
    }

}
