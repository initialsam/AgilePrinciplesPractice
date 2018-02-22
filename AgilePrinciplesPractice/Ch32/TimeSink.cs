﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgilePrinciplesPractice.Ch32
{
    public interface TimeSink : Observer
    {
        void SetTime(int hours,
                     int minutes,
                     int seconds);
    }
}