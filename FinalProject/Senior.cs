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
