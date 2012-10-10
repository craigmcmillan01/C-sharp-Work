using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace TextAdventureCode_01
{
	class Program
	{
	   static List<Character> npcList = new List<Character>();
		static void Main(string[] args)
		{
			//testing 10/10/12		   		

			//saveData("NPC.xml"); //save a list of defined NPC's
			XDocument npcPlayers = XDocument.Load("NPC.xml"); //Load NPC's in
			addNpcToList(npcPlayers);//add NPCs to list

			//w=display NPcs in list to console
			Console.WriteLine("writing to xml file......\n");
			Console.ReadKey();
			foreach (Character c in npcList)
			{
				Console.WriteLine("name: " + c.name + "\nstrength: " + c.strength + "\nWeapon Skill " + c.weaponSkill + "\nattack: " + c.attack + "\nspeed: " + c.speed + "\nhealth: "+ c.health + "\nlevel: " + c.level);
				Console.WriteLine("\n");
			}
			Console.ReadKey();

			//TODO weaponskill isnt being added properly its set at 0 when it shouldnt be, fix this....





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
		}
		

		//write to xml file
		static XDocument GetNpcData()//set up info for xml file.....
		{
			//EXPLANATION this code was just to set up an outline for xml doc 
			XDocument doc = new XDocument(
					   new XDeclaration("1.0", "utf-8", "yes"),
					   new XComment("this is a list of all NPC's in the game"),
						new XElement("starbuzzData",
					   new XElement("NPC",
						   new XElement("name", "Craig"),
						   new XElement("strength", 1),
						   new XElement("weaponSkill", 1),
						   new XElement("attack", 1),
						   new XElement("speed", 3),
						   new XElement("health", 10),
						   new XElement("level", 1),
						   new XElement("isHostile", false)),
						new XElement("NPC",
						   new XElement("name", "Craig"),
						   new XElement("strength", 1),
						   new XElement("weaponSkill", 1),
						   new XElement("attack", 1),
						   new XElement("speed", 3),
						   new XElement("health", 10),
						   new XElement("level", 1),
						   new XElement("isHostile", false)))
					   );
			return doc;
		}

		static void saveData(string fileName)//save data to xml file. 
		{
			XDocument doc = GetNpcData();
			doc.Save(fileName);
		}

		static void addNpcToList(XDocument doc)//add data from NPC.xml to NPC list
		{
		   string name; 
		   int strength, weaponSkill, attack, speed, health, level;
		   bool isHostile;

		   var data = from item in doc.Descendants("NPC")
					  select new
					  {
						  name = item.Element("name").Value,
						  strength = item.Element("strength").Value,
						  weaponSkill = item.Element("weaponSkill").Value,
						  attack = item.Element("attack").Value,
						  speed = item.Element("speed").Value,
						  health = item.Element("health").Value,
						  level = item.Element("level").Value,
						  isHostile = item.Element("isHostile").Value

					  };
		   foreach (var p in data)
		   {
			   name = p.name;
			   strength = Convert.ToInt32(p.strength);
			   weaponSkill = Convert.ToInt32(p.weaponSkill);
			   attack = Convert.ToInt32(p.attack);
			   speed = Convert.ToInt32(p.speed);
			   health = Convert.ToInt32(p.health);
			   level = Convert.ToInt32(p.level);
			   isHostile = Convert.ToBoolean(p.isHostile);
			   NPC n = new NPC(name, strength, weaponSkill, attack, speed, health, level, isHostile);
			   npcList.Add(n);
		   }
		}
	}
}
