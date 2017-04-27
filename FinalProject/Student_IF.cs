using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
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
