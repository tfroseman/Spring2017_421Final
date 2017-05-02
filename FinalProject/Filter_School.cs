using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Filter_School : Filter
    {
        private Filter filter;
        private Filter nextFilter;
        //added for filtering, (Unsure if school is "String" or "School_enum")
        private String filer_School;

        //Constructor for setting school to filter on
        public Filter_School(String school)
        {
            this.filer_School = school;
        }
       public List<Course> matchesFilter(List<Course> courses)
        {
            List<Course> filtercourses = new List<Course>();
           foreach(Course c in courses)
            {
                if(c.getSchool() == this.filer_School)
                {
                    filtercourses.Add(c);
                }
            }
            return filtercourses;
        }
    }
}
