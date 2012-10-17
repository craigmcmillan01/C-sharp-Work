using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class House : Environment
{
    public virtual object numRooms { get; set; }
    public virtual IEnumerable<Room> Room { get; set; }

    public House() { }
    public House(Environment e)
    {
        setDefaultHouse(e);
    }
    
   public void setDefaultHouse(Environment e)
    {
       Random rand = new Random();
       int r = rand.Next(1, 4);
       this.numRooms = r;
       this.numMoney = e.numMoney / r;
       this.numNPC = e.numNPC / r;
       this.numWeapon = e.numWeapon / r;
    }

   public void cabin(UsefulMethods odd, Player player)
   {
       NPC n = new NPC();
       n = odd.getRandomNPC();
       Console.Write("you knock on the door and a man appears\n 'Ah hello there stranger please come in! it has been sometime since i have had a visitor\n"+
                        " Have a seat, my name is  "+ n.name + " please have a drink, i made it myself\n");
       Console.Write("1: Drink from cup \n2:politly refuse");
       int ans = Convert.ToInt32(Console.ReadLine());

       if (ans == 1)
           throw new NotImplementedException();
       if (ans == 2)
           throw new NotImplementedException();
       else
           Console.WriteLine("please enter a valid choice");
   }
}

