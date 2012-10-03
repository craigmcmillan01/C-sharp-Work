using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Character
{
	public virtual string name { get; set; }
	public virtual int strength { get; set; }
	public virtual int weaponSkill { get; set; }
	public virtual int attack { get; set; }
	public virtual int speed { get; set; }
	public virtual int health { get; set; }
	public virtual int level { get; set; }
	public virtual IEnumerable<Item> Item { get; set; }

	public Character(){	}
	//TODO set up constructor for characters that takes in relevant properties

	public abstract void addItem(Item i); //EXPLANATION add an item to characters inventory(itemList)
	public abstract void useItem(Item i); //EXPLANATION use an item in the inventory
	public abstract void useWeapon(Weapon w); //EXPLANATION use a weapon in inventory to attack other character
	public abstract void showInventory(); //EXPLANATION show items in characters inventory

	//TODO set up associaition for adding items to a character and item list

}

