using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Clothing : Item
{
	public virtual int armorRating { get; set; }

	public Clothing() { }
	//TODO setup clothing constructor

	public abstract void specialSkill(); //EXPLANATION This method will activate any special abilites that clothing has, i.e invisibility, super streangth
}

