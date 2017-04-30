using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Filter_Closed : Filter
    {

        private Filter filter;
        private Filter nextFilter;


        //Returns closed courses in a list
       public List<Course> matchesFilter(List<Course> courses)
        {
            List<Course> closed_Courses = new List<Course>();

            foreach(Course c in courses)
            {
                if(c.attending == c.getSeats())
                {
                    closed_Courses.Add(c);
                }
            }
            return closed_Courses;
        }
    }
}
