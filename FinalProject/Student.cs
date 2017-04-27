using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Student : Student_IF
    {
        private StudentSchedule schedule;
        private String name;
        private Gender gender;
        private School school;
        private String DOB;
        private int completedCredits;
        private MajorDecorater major;
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

        ///TODO logic for next state here
        public Student getNextYear()
        {
            
            return null;
        }
      
    }
}
