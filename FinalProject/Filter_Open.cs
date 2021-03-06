﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Filter_Open : Filter
    {

        private Filter filter;
        private Filter nextFilter;

       public List<Course> matchesFilter(List<Course> courses)
        {
            List<Course> open_Courses = new List<Course>();

            foreach (Course c in courses)
            {
                if (c.attending < c.getSeats())
                {
                    open_Courses.Add(c);
                }
            }
            return open_Courses;
        }
    }
}
