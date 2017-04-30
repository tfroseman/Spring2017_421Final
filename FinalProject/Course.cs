using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Course : ICourse
    {
        public String description { get; set; }
        public String title { get; set; }
        public String course_number { get; set; }
        public String school { get; set; }
        public string required { get; set; }
        public String instructor { get; set; }

        //Added for filtering open/closed
        public int seats = 40;
        public int attending { get; set; }
        public List<Student> Student_List = new List<Student>();

        public Course()
        {
            this.attending = 0;
            
           }

        public string getDesc()
        {
            return description;
        }

        public string getInstructor()
        {
            return instructor;
        }

        public string getNumber()
        {
            return course_number;
        }

        public List<string> getRequired()
        {
            throw new NotImplementedException();
        }

        public string getTitle()
        {
            return title;
        }
        public String getSchool()
        {
            return this.school;
        }
        public void add_Student(Student s)
        {
            this.Student_List.Add(s);
            attending++;

        }
        public void drop_Student(Student s)
        {
            for(int i = 0; i < this.Student_List.Count; i++)
            {
                if(s.getName() == Student_List[i].getName())
                {
                    Student_List.RemoveAt(i);
                }
            }
        }
        public int getSeats()
        {
            return this.seats;
        }
    }
}
