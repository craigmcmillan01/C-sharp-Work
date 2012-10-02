using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial_2_Questions
{
    public class Government
    {
        private static Government uniqueInstance;
        private Government() { }

        public static Government getInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Government();
            }
            return uniqueInstance;
        }
    }
}
