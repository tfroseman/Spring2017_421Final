using System;

namespace FinalProject
{
    abstract class Student : Student_IF
    {
        public StudentSchedule schedule;
        public String name;
        public String gender;
        public String school;
        public String DOB;
        public int completedCredits;
        public Area_of_Study major;

        public Student()
        {

        }

        public Student(Student student)
        {
            this.schedule = student.getSchedule();
            this.name = student.getName();
            this.gender = student.gender;
            this.school = student.getSchool();
            this.DOB = student.getDOB();
            this.completedCredits = student.getCredits();
            this.major = student.getMajor();
        }

        public int getCredits()
        {
            return completedCredits;
        }

        public string getDOB()
        {
            return DOB;
        }

        public Area_of_Study getMajor()
        {
            return major;
        }

        public string getName()
        {
            return name;
        }

        public StudentSchedule getSchedule()
        {
            return schedule;    
        }

        public String getSchool()
        {
            return school;
        }

        public virtual Student getNextYear()
        {
            if (completedCredits > 25)
            {
                return new Sophmore(this);
            }
            if (completedCredits >50)
            {
                return new Junior(this);
            }
            if (completedCredits > 75)
            {
                return new Senior(this);
            }
            return this;
        }

        public abstract String yearName();
      
    }
}
