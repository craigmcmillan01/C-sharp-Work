﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer_example
{
    public interface Observer
    {
        void update(string theNews);
    }
}
