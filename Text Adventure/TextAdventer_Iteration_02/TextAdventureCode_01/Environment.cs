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
    //TODO set up environment constructors

    //TODO set up association so that environment has many streets, create list for storing streets.

}

