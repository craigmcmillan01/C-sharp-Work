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

public class House : Street
{
	public virtual object numRooms
	{
		get;
		set;
	}

	public virtual IEnumerable<Room> Room
	{
		get;
		set;
	}

	public House()
	{
	}

}

