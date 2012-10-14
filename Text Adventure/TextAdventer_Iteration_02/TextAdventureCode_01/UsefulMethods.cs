﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;


namespace TextAdventureCode_01
{
    public class UsefulMethods
    {
        public List<NPC> npcList = new List<NPC>();
        public UsefulMethods() { }

        //write to xml file
        public XDocument npcDataSetUp()//set up info for xml file.....
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

        public void saveNpcData(string fileName)//save data to xml file. 
        {
            XDocument doc = npcDataSetUp();
            doc.Save(fileName);
        }

        public void addNpcToList(XDocument doc)//add data from NPC.xml to NPC list
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

        public void displayNpcs() //display NPcs in list to console
        {
            Console.WriteLine("loading xml file......\n");
            Console.ReadKey();

            foreach (Character c in npcList) // Debug statement to check NPC's are being created properly
            {
                Console.WriteLine("name: " + c.name + "\nstrength: " + c.strength + "\nWeapon Skill " + c.weaponSkill + "\nattack: " + c.attack + "\nspeed: " + c.speed + "\nhealth: " + c.health + "\nlevel: " + c.level);
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }

        public void getRandomNPC() //return random npc from list
        {
            string name;
            int strength, weaponSkill, attack, speed, health, level;

            int listLength = npcList.Count;
            Random rand = new Random();
            int randNum = rand.Next(0, listLength);

            name = npcList.ElementAt(randNum).name;
            strength = npcList.ElementAt(randNum).strength;
            weaponSkill = npcList.ElementAt(randNum).weaponSkill;
            attack = npcList.ElementAt(randNum).attack;
            speed = npcList.ElementAt(randNum).speed;
            health = npcList.ElementAt(randNum).health;
            level = npcList.ElementAt(randNum).level;

            Console.WriteLine("name: " + name + "\nstrength: " + strength + "\nWeapon Skill " + weaponSkill + "\nattack: " + attack + "\nspeed: " + speed + "\nhealth: " + health + "\nlevel: " + level);
            Console.ReadKey();
        }
    }
}