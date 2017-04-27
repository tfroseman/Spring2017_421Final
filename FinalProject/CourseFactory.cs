using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace FinalProject
{
    class CourseFactory
    {
        SQLiteConnection database = Database.SimpleDbConnection();
       
        /// <summary>
        /// Return a fully inflated class object from the database
        /// </summary>
        /// <param name="ID">The Course ID number ex 421 for sweng 421 design patterns</param>
        /// <returns>An inflated course object</returns>
        public Course getClass(String ID)
        {
            database.Open();
            var course = database.Query<Course>("select title, description, number = @courseID, school, instructor, required FROM Course", new { courseID = ID });
            return course.First();
        }
    }
}
