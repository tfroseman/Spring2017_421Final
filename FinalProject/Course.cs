using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Course : ICourse
    {
        public String description;
        public String title;
        public String course_number;
        //public School school;
        public List<String> required;
        public String instructor;

        public string getDesc()
        {
            return description;
        }

        public string getInstructor()
        {
            return instructor;
        }

        public string getNumber()
        {
            return course_number;
        }

        public List<string> getRequired()
        {
            throw new NotImplementedException();
        }

        public string getTitle()
        {
            return title;
        }
    }
}
