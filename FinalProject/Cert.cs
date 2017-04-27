using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Cert : MajorDecorater
    {

        private String title;
        private Area_of_Study major;

        public Cert(Area_of_Study areaofstudy) : base(areaofstudy)
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
