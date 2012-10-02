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

public class Bandit : Humanoid
{

     public Bandit(string name, int streangth, int weaponSkill, int attack, int speed, int health, int level) :base(name, streangth, weaponSkill, attack, speed, health, level) {}

    public override void addWeapon(Weapon w)
    {
        this.weaponList.Add(w);
    }

    public override void useWeapon(Weapon w)
    {
        if (w.damage > 3)
            Console.WriteLine(this.name + " Kills opponent with " + w.name);
        else
            Console.WriteLine(w.name + " is not powerful enough");

        Console.ReadKey();
    }

    public override void showInventory()
    {
        Console.WriteLine("\n" + this.name + "'s Inventory has");
        foreach (Weapon w in weaponList)
        {
            Console.WriteLine(w.name);
        }
        Console.ReadKey();
    }
}

