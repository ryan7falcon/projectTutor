using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectTutor
{
    public class Room : Record
    {
        DBConnector dbc = new DBConnector();

        public int Id { set; get; }
        public string Name { set; get; }
        public int Day { set; get; }
        public DateTime Time { set; get; }

        public Room(int id)
        {
            this.Id = id;
        }

        public Room(int id, string name, int day, DateTime time)
        {
            this.Id = id;
            this.Name = name;
            this.Day = day;
            this.Time = time;
        }

        //get the info from DB
        public void loadRecord()
        {
            List<string> l = dbc.get("Room", Id);

            Name = l[1];
            Day = Int32.Parse(l[2]);
            Time = DateTime.Parse(l[3]);
        }

        //used when updating and inserting records in DB
        override public string[] getParameters()
        {
            string[] s = new string[4];

            s[0] = Id.ToString();
            s[1] = Name;
            s[2] = Day.ToString();
            s[3] = Time.ToString();

            return s;
        }

        //used when updating and inserting records in DB
        override public string[] getParameterNames()
        {
            string[] s = new string[4];

            //those are name of the fields in the database
            s[0] = "Id";
            s[1] = "Name";
            s[2] = "Day";
            s[3] = "Time";

            return s;
        }
    }
}
