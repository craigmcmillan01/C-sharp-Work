using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Player : Character
{
	public Player()	{ }
	public Player(string name, int strength, int weaponskill, int attack, int speed, int health, int level) : base(name, strength, weaponskill, attack, speed, health, level) { }
    public Player(string name)
    {
        defaultPlayer(name);
    }

	public override void addItem(Item i)
	{
		throw new NotImplementedException();
	}

	public override void useItem(Item i)
	{
		throw new NotImplementedException();
	}

	public override void useWeapon(Weapon w)
	{
		throw new NotImplementedException();
	}

	public override void showInventory()
	{
		throw new NotImplementedException();
	}

    public void defaultPlayer(string name)
    {
        this.name = name;
        this.strength = 5;
        this.weaponSkill = 3;
        this.attack = 5;
        this.speed = 3;
        this.health = 100;
        this.level = 1;
    }
}

