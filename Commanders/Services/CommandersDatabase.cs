using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commanders.Services
{
    public class CommandersDatabase
    {
        private SQLiteConnection conn = new SQLiteConnection("Data Source=d:/Users/Sebastien/Documents/Visual Studio 2017/Projects/Commanders/Commanders/data/Commanders.db;Version=3;");
        public CommandersDatabase ()
        {

        }

        public void Connect()
        {
            conn.Open();
                SQLiteCommand sqlComm = new SQLiteCommand(@"SELECT Name FROM Commanders",conn);
                SQLiteDataReader r = sqlComm.ExecuteReader();
                while (r.Read())
                {
                    string FileNames = (string)r["Name"];

                    List<string> ImportedFiles = new List<string>();
                }
        }
        public void Close()
        {
            conn.Close();
        }

    }
}
