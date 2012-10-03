using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Item
{
	public virtual int condition { get; set; }
	public virtual int weight { get; set; }
	public virtual string name { get; set; }
	public virtual int skill { get; set; }
	public virtual bool useable { get; set; }
	public virtual int cost { get; set; }

	public Item(){ }
	//TODO set up constructor for creating items

}

