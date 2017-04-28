using System;

namespace FinalProject.Student
{
    class Junior : Student
    {
        private StudentSchedule schedule;
        private String name;
        //private Gender gender;
        //private School school;
        private String DOB;
        private int completedCredits;
        private MajorDecorater major;

        public Junior(Student student) : base(student)
        {
        }

        public override Student getNextYear()
        {
            if(completedCredits > 75)
            {
                return new Senior(this);
            }
            else
            {
                return this;
            }
        }
    }
}
