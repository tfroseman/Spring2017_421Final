﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    interface Filter
    {
        List<Course> matchesFilter( List <Course> courses);
    }
}
