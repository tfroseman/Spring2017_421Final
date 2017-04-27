using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Freshman: Student
    {
        private StudentSchedule schedule;
        private String name;
        //private Gender gender;
        //private School school;
        private String DOB;
        private int completedCredits;
        private MajorDecorater major;

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
    }
}
