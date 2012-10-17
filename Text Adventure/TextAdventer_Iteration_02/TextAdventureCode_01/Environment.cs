using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Environment
{
    public virtual int numNPC { get; set; }
    public virtual int numMoney { get; set; }
    public virtual int numWeapon { get; set; }
    public virtual IEnumerable<Street> Street { get; set; }

    public Environment() { }
    public Environment(UsefulMethods odd) { setDefualtEnvironment(odd); }
    public Environment(int numNpc, int numMoney, int numWeapon)
    {
        this.numNPC = numNpc;
        this.numMoney = numMoney;
        this.numWeapon = numWeapon;
    }

    public void setDefualtEnvironment(UsefulMethods odd)
    {
        int npclength = odd.npcList.Count;
        int weaponLength = odd.weaponList.Count;
        Random rand = new Random();
        //set random number of weapons and npc
        int randNum = rand.Next(0, 10);
        this.numNPC = randNum;
        randNum = rand.Next(0, 10);
        this.numWeapon = randNum;
        randNum = rand.Next(1, 1000);
        this.numMoney = randNum;
    }

    public void play(Environment e, UsefulMethods odd, Player player)
    {
        Random rand = new Random();
        int randNum = rand.Next(0, 0); // update for number of missions
        if (randNum == 0)
            environment_1(e, odd, player);
        
    }

    public void environment_1(Environment e, UsefulMethods odd, Player player)
    {
        House h1 = new House();
        Console.WriteLine(" You wake up in a wooded area, you are unsure of what happened or how you got there.");
        Console.WriteLine(" You look around and can see a small cabin off in the distance. how do you procced? ");
        Console.Write("1: Go to the cabin \n2: Walk in the opposite direction");
        int ans = Convert.ToInt32(Console.ReadLine());

        if (ans == 1)
            h1.cabin(odd, player);
        else if (ans == 2)
            throw new NotImplementedException();
        else
            Console.WriteLine("Please choose from an option above");
    }



}

