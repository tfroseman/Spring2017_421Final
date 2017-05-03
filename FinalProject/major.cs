using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class major : Area_of_Study
    {
        private String title;
        public major(String name)
        {
            this.title = name;
        }

        public string getTitle()
        {
            return title;
        }
    }
}
