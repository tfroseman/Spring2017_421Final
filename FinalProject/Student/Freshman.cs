using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Student
{
    class Freshman: Student
    {
        public StudentSchedule schedule =null;
        public String name = null;
        public String gender;
        public School school;
        public String DOB;
        public int completedCredits;
        public Area_of_Study major;

        public override Student getNextYear()
        {
            if (completedCredits >= 25)
            {
                return new Sophmore(this);
                
            }
            else
            {
                return this;
            }
        }

        public override string yearName()
        {
            return "Freshman";
        }
    }
}
