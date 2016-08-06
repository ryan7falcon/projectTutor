using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectTutor
{
    public class Tutor : Record
    {
        DBConnector dbc = new DBConnector();

        public int Id { set; get; }
        public string Name { set; get; }
        public string Subjects { set; get; }
        public int Level { set; get; }
        public double HourlyRate { set; get; }

        public Tutor(int id)
        {
            this.Id = id;
        }

        public Tutor(int id, string name, string subjects, int level, double rate)
        {
            this.Id = id;
            this.Name = name;
            this.Subjects = subjects;
            this.Level = level;
            this.HourlyRate = rate;
        }

        public static string getLevelName(int level)
        {
            switch (level)
            {
                case 0:
                    return "Beginner";
                case 1:
                    return "Intermediate";
                case 2:
                    return "Advanced";
                case 3:
                    return "Master";
                case 4:
                    return "God";
                default:
                    return "Unknown";
            }
        }

        //get the info from DB
        public void loadRecord()
        {
            List<string> l = dbc.get("Tutor", Id);

            Name = l[1];
            Subjects = l[2];
            Level = Int32.Parse(l[3]);
            HourlyRate = Double.Parse(l[4]);
        }

        //used when updating and inserting records in DB
        override public string[] getParameters()
        {
            string[] s = new string[5];

            s[0] = Id.ToString();
            s[1] = Name;
            s[2] = Subjects;
            s[3] = Level.ToString();
            s[4] = HourlyRate.ToString();

            return s;
        }

        //used when updating and inserting records in DB
        override public string[] getParameterNames()
        {
            string[] s = new string[5];

            //those are name of the fields in the database
            s[0] = "Id";
            s[1] = "name";
            s[2] = "subjects";
            s[3] = "level";
            s[3] = "hourlyRate";

            return s;
        }
    }
}
