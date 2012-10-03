using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class House : Environment
{
    public virtual object numRooms { get; set; }
    public virtual IEnumerable<Room> Room { get; set; }

    public House() { }
    //TODO set up house constructors

    //TODO create association between house and rooms and adding rooms to a roomList
}

