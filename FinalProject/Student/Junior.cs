using System;

namespace FinalProject.Student
{
    class Junior : Student
    {
        public StudentSchedule schedule;
        public String name;
        public String gender;
        public String school;
        public String DOB;
        public int completedCredits;
        public Area_of_Study major;


        public Junior(Student student) : base(student)
        {
            this.schedule = student.getSchedule();
            this.name = student.getName();
            this.gender = student.gender;
            this.school = student.school;
            this.DOB = student.getDOB();
            this.completedCredits = student.getCredits();
            this.major = student.getMajor();
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
        public override string yearName()
        {
            return "Junior";
        }
    }
}
