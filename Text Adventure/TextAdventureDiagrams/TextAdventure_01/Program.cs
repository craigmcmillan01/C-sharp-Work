using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAdventure_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO set up humaniod and player class
            //TODO set up weapon and sword class

            Player craig = new Player("Craig", 12, 4, 4, 4, 6, 1);
            Bandit b1 = new Bandit("EvilMark", 14, 6, 4, 3, 6, 2);
            Sword s1 = new Sword("Super Sword",4, 3, 2);
            Sword s2 = new Sword("Excalibur", 1, 2, 3);
            Weapon w1 = new Weapon("dave",6, 100, 20);
            Sword banditSword = new Sword("MarksSword", 5, 8, 3);

            craig.addWeapon(s1);
            craig.addWeapon(s2);
            craig.addWeapon(w1);
            b1.addWeapon(banditSword);

            craig.useWeapon(s1);
            craig.useWeapon(s2);
            craig.useWeapon(w1);
            craig.showInventory();

            b1.useWeapon(banditSword);
            b1.showInventory();
        }
    }
}
