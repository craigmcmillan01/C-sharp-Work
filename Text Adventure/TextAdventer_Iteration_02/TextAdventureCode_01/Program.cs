using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace TextAdventureCode_01
{
	class Program
	{
	   //static List<NPC> npcList = new List<NPC>();
		static void Main(string[] args)
		{
            //==================Set up NPC's==================================================
            UsefulMethods odd = new UsefulMethods();
			XDocument npcPlayers = XDocument.Load("NPC.xml"); //Load NPC's in
            odd.addNpcToList(npcPlayers);
            //================================================================================
            //=================Set up Player==================================================
            Console.WriteLine("please select a name for your player:");
            string name = Console.ReadLine();
            Player player = new Player(name);
            printPlayerStats(player);
            //=================================================================================
            //================Set up weapons===================================================
            //odd.saveWeaponData("Weapons.xml");
            XDocument weaponDoc = XDocument.Load("weapons.xml");
            odd.addWeaponToList(weaponDoc);
            odd.displayWeapons();
            //================Debug statements for NPC's=======================================
            //odd.displayNpcs();
            //Console.Clear();
            //Console.WriteLine("Random NPC from list");
            //odd.getRandomNPC();  
   		    //===================================================================================
		}		
        static void printPlayerStats(Player player)
        {
            Console.WriteLine("\nyour stats are: \n" + "name: " + player.name + "\nstrength: " + player.strength + "\nWeapon Skill " + player.weaponSkill + "\nattack: " + player.attack + "\nspeed: " + player.speed + "\nhealth: " + player.health + "\nlevel: " + player.level);
            Console.ReadLine();
        }
	}
}


//TODO write program logic explanation of what needs to happen

/*EXPLANATION
 * This is where the program logic will go......
 * 
 * All the NPC's, weapons, missions, environments etc should be created appropriatly from the correct text files. 
 * 
 * Here it should display a welcome screen with an explanation of what the game will be about and what will happen etc..
 * 
 * the player should then be allowed to choose a name for Their character and a difficulty level, (Easy, medium, hard)
 * 
 * the select mission method should be run and this should run through all possible missions. (might need to look into if we need to pass a player object to the mission class).
 * 
 * once all missions have been completed the game should end. 
 * 
 * Give player option to restart. 
 * 
 */