using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FinalProject
{
    class Database
    {
        public static string DBFile => System.Environment.CurrentDirectory + "\\..\\..\\..\\database.sqlite; Version=3; Read Only=True;";

        public static SQLiteConnection SimpleDbConnection()
        {
            return new SQLiteConnection("Data Source=" + DBFile);
        }
    }
}
