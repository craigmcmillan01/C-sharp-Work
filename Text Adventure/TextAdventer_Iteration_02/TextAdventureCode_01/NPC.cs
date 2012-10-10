using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NPC : Character
{
	public virtual bool isHostile { get; set; }

	public NPC(){ }
	public NPC(string name, int strength, int weaponskill, int attack, int speed, int health, int level, bool isHostile) : base(name, strength, weaponskill, attack, speed, health, level)
	{
		this.isHostile = isHostile;
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
}

