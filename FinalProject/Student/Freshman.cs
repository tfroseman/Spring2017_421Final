using System;

namespace FinalProject.Student
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
