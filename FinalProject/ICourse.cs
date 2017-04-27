using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    interface ICourse
    {
        String getDesc();
        String getTitle();
        String getNumber();
        //School getSchool();
        List<String> getRequired();
        String getInstructor();

    }
}
