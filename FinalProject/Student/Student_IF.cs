using System;

namespace FinalProject.Student
{
    interface Student_IF
    {

       StudentSchedule getSchedule();
        String getName();
        //Gender getGender();
        String getDOB();
        Area_of_Study getMajor();
        //School getSchool();
        int getCredits();

    }
}
