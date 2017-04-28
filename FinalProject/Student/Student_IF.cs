using System;

namespace FinalProject.Student
{
    interface Student_IF
    {

       StudentSchedule getSchedule();
        String getName();
        //Gender getGender();
        String getDOB();
        MajorDecorater getMajor();
        //School getSchool();
        int getCredits();

    }
}
