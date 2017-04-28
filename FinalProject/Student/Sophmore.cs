using System;

namespace FinalProject.Student
{
    class Sophmore : Student
    {
        private StudentSchedule schedule;
        private String name;
        //private Gender gender;
        //private School school;
        private String DOB;
        private int completedCredits;
        private MajorDecorater major;

        public Sophmore(Student student) : base(student)
        {
        }

        public override Student getNextYear()
        {
            if (completedCredits >= 50)
            {
                return new Junior(this);
            }
            else
            {
                return this;
            }
        }
    }
}
