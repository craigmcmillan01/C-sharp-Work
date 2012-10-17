using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Mission
{
	public virtual IEnumerable<Environment> Environment { get; set; }

	public Mission() { }

	//TODO set up associaton for a mission containing multiple environments, create list for storing environments. 

	public virtual void selectMission()
	{
		throw new System.NotImplementedException();
		/*EXPLANATION
		 *this will be called from player class after player setup and will generate a random number between 0 and numberOfMissions.
		 *it will then randomly pick one of the missions that are outlined in one of the methods below. 
		 *i.e if (rand == 1) mission_1(); etc it will continue to do this until each mission had been played. 
		 *once all missions have been played present player with there "stats" or end screen.
		 */
	}

	public virtual void Mission_1(UsefulMethods odd, Player player)
	{
        Environment e1 = new Environment(odd);
        e1.play(e1, odd, player);
	}

	public virtual void Mission_2()
	{
		throw new System.NotImplementedException();
	}

	public virtual void Mission_3()
	{
		throw new System.NotImplementedException();
	}

}

