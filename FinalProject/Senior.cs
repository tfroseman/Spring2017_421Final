using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Senior : Student
    {
        private StudentSchedule schedule;
        private String name;
        private String gender;
        private String school;
        private String DOB;
        private int completedCredits;
        private Area_of_Study major;

        public Senior(Student student) : base(student)
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
            throw new NotImplementedException();
        }
        public override string yearName()
        {
            return "Senior";
        }
    }
}
