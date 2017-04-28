using System;

namespace FinalProject.Student
{
    abstract class Student : Student_IF
    {
        private StudentSchedule schedule;
        private String name;
        private Gender gender;
        private School school;
        private String DOB;
        private int completedCredits;
        private MajorDecorater major;

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

        public MajorDecorater getMajor()
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

        public School getSchool()
        {
            return school;
        }

        abstract public Student getNextYear();
      
    }
}
