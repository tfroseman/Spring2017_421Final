using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Course : ICourse
    {
        public String description { get; set; }
        public String title { get; set; }
        public String course_number { get; set; }
        public string school { get; set; }
        public string required { get; set; }
        public String instructor { get; set; }

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
