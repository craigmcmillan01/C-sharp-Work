using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NPC : Character
{
	public virtual bool isHostile { get; set; }

	public NPC(){ }
	//TODO set up constructor for creating an NPC 

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

