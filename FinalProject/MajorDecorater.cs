using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
   abstract public class MajorDecorater : Area_of_Study
    {
        private String title;
        private Area_of_Study major;

        public MajorDecorater(Area_of_Study areaofstudy)
        {
            this.major = areaofstudy;
        }

        public string getTitle()
        {
            return title;
        }
        abstract public Area_of_Study getmajor();
      
    }
}
