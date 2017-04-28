using System;

namespace FinalProject.Student
{
    class Senior : Student
    {
        private StudentSchedule schedule;
        private String name;
        private Gender gender;
        private School school;
        private String DOB;
        private int completedCredits;
        private MajorDecorater major;

        public Senior(Student student) : base(student)
        {
        }

        public override Student getNextYear()
        {
            throw new NotImplementedException();
        }
    }
}
