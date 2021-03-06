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

public abstract class Character
{
	public virtual string name
	{
		get;
		set;
	}

	public virtual int strength
	{
		get;
		set;
	}

	public virtual int weaponSkill
	{
		get;
		set;
	}

	public virtual int attack
	{
		get;
		set;
	}

	public virtual int speed
	{
		get;
		set;
	}

	public virtual int health
	{
		get;
		set;
	}

	public virtual int level
	{
		get;
		set;
	}

	public virtual IEnumerable<Item> Item
	{
		get;
		set;
	}

	public Character()
	{
	}

	public abstract void addWeapon();

	public abstract void useWeapon();

	public abstract void showInventory();

}

