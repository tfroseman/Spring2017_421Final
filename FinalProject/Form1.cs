using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace FinalProject
{
    public partial class Form1 : Form
    {
        System.Collections.Generic.List<Course> courseList;
        //CourseFactory courseFactory = new CourseFactory();
        //public String description { get; set; }
        //public String title { get; set; }
        //public String course_number { get; set; }
        //public String school { get; set; }
        //public string required { get; set; }
        //public String instructor { get; set; }

        ////Added for filtering open/closed
        //public int seats = 40;
        //public int attending { get; set; }
        //public List<Student> Student_List = new List<Student>();

        //Create courses
        Course course1 = new Course();
        Course course2 = new Course();
        Course course3 = new Course();
        Course course4 = new Course();
        Course course5 = new Course();
        Course course6 = new Course();
        Course course7 = new Course();
        Course course8 = new Course();

        //Create new Student
        Student student1 = new Freshman();
        Area_of_Study engineering = new major("Engineering");
      
        
        public Form1()
        {
            InitializeComponent();
            ClearDemoItems();
            student1.name = "John Smith";
            student1.gender = "Male";
            student1.school = "PennState";
            student1.DOB = "9/12/94";
            student1.completedCredits = 40;
            student1.major = engineering;

            this.printStudent(student1);



        }
        private void printStudent(Student s)
        {
            richTextBox1.Text = " ";
            richTextBox1.AppendText(s.getName() + "\n");

            richTextBox1.AppendText("Major : " + s.getMajor().getTitle() + "\n");
            richTextBox1.AppendText(s.gender + "\n");
            richTextBox1.AppendText(s.getSchool() + "\n");
            richTextBox1.AppendText(s.getDOB() + "\n");
            richTextBox1.AppendText("Credits: " + s.getCredits() + "\n");
            richTextBox1.AppendText(s.yearName() + "\n");
        }

        /// <summary>
        /// Clear all of the demo values
        /// </summary>
        /// 
        private void ClearDemoItems()
        {
            searchListingBox.Items.Clear();
            courseInfoBox.Clear();
            scheduleListBox.Items.Clear();
            waitListBox.Items.Clear();
        }


        private void searchButtonClick(object sender, EventArgs e)
        {
            // Search for a list of courses that match 
           // courseList = courseFactory.getClasses(courseIDTextBox.Text).ToList();

            //Insert each course title into the search list box
//            foreach(Course course in courseList )
//            {
//                searchListingBox.Items.Add(course.title);
//            }
        }

        /// <summary>
        /// Add the selected course to the student schedule
        /// </summary>
        private void addButton_Click(object sender, EventArgs e)
        {
            // If a course is selected from the search box add it
            // to the student schedule, If no course is selected do nothing

            // Send request to update course listing seat count -= 1
        }

        /// <summary>
        /// Remove the selected course from the student schedule
        /// </summary>
        private void removeButton_Click(object sender, EventArgs e)
        {
            // If a course is selected from the scheduled list. Remove from
            // the student schedule.

            // Send request to update course listing seat count += 1
        }

        private void selectedValueChanged(object sender, EventArgs e)
        {
            // If the selected item is changed update the description box
            courseInfoBox.Text = (courseList[searchListingBox.SelectedIndex] as Course).description;
        }

        public static implicit operator Delegate(Form1 v)
        {
            throw new NotImplementedException();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void courseInfoBox_TextChanged(object sender, EventArgs e)
        {

        }
        //Check if year level upgrade
        private void button1_Click(object sender, EventArgs e)
        {
            this.student1 = student1.getNextYear();
            this.printStudent(student1);
        }
    }
}
