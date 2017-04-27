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

namespace FinalProject
{
    public partial class Form1 : Form
    {
        System.Collections.Generic.List<Course> courseList;
        CourseFactory courseFactory = new CourseFactory();


        public Form1()
        {
            InitializeComponent();
            ClearDemoItems();
        }
        /// <summary>
        /// Clear all of the demo values
        /// </summary>
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
            courseList = courseFactory.getClasses(courseIDTextBox.Text).ToList();

            //Insert each course title into the search list box
            foreach(Course course in courseList )
            {
                searchListingBox.Items.Add(course.title);
            }
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
    }
}
