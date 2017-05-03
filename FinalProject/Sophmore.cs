using System;

namespace FinalProject
{
    class Sophmore : Student
    {
        public Sophmore(Student student) : base(student)
        {  
        }

        public override string yearName()
        {
            return "Sophmore";
        }
    }
}
