using System;

namespace FinalProject.Student
{
    class Sophmore : Student
    {
        public StudentSchedule schedule;
        public String name;
        public String gender;
        public String school;
        public String DOB;
        public int completedCredits;
        public Area_of_Study major;


        public Sophmore(Student student) : base(student)
        {   this.schedule = student.getSchedule();
            this.name = student.getName();
            this.gender = student.gender;
            this.school = student.school;
            this.DOB = student.getDOB();
            this.completedCredits = student.getCredits();
            this.major = student.getMajor();
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
        public override string yearName()
        {
            return "Sophmore";
        }
    }
}
