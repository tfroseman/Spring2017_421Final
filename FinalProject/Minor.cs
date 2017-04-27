using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Minor : MajorDecorater
    {
        private String title;
        private Area_of_Study major;

        public Minor(Area_of_Study areaofstudy) : base(areaofstudy)
        {
            
        }
        public override Area_of_Study getmajor()
        {
            return major;
        }

        public new string getTitle()
        {
            return title;
        }

    }
}
