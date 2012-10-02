using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer_example
{
    public interface Observable
    {
        void registerObservers(Student s);
        void removeObservers(Student s);
        void notiffyObservers();
    }
}
