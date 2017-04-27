using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace FinalProject
{
    public partial class Functions : Form
    {
        public Functions()
        {
            InitializeComponent();
        }

        private void build_Click(object sender, EventArgs e)
        {
            SQLiteConnection.CreateFile("MyDatabase.sqlite");
        }

        private void studentsbutton_Click(object sender, EventArgs e)
        {

        }

        private void classesbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
