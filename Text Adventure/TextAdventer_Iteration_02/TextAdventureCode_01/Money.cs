using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Money : Item
{
    public virtual int Amount { get; set; }

    public Money() { }
    //TODO set up constructor for money

    //EXPLANATION money is an object and can be used to purchase weapons or bribe NPC's for things.

}

