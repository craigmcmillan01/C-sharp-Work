using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Street : Environment
{
    public virtual object numHouses { get; set; }
    public virtual IEnumerable<House> House { get; set; }
    //TODO set up association between street and houses, create list for storing houses. 

    public Street() { }
    //TODO add constructor for street

}

