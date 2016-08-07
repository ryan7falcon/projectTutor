using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectTutor
{
    public class Availability : Record
    {
        DBConnector dbc = new DBConnector();

        public int Id { set; get; }
        public int Day { set; get; }
        public DateTime Time { set; get; }
        public int TutorId { set; get; }

        public Availability(int id)
        {
            this.Id = id;
        }

        public Availability(int id, int day, DateTime time, int tutorId)
        {
            this.Id = id;
            this.Day = day;
            this.Time = time;
            this.TutorId = tutorId;
        }
        public static List<Availability> parseStringList(List<List<string>> strList)
        {
            List<Availability> avs = new List<Availability>();

            foreach (List<string> list in strList)
            {
                Availability av = new Availability(Int32.Parse(list[0]), Int32.Parse(list[1]), DateTime.Parse(list[2]), Int32.Parse(list[3]));
                avs.Add(av);
            }

            return avs;
        }

        public static List<Availability> getAll()
        {
           
            DBConnector dbc = new DBConnector();
            List<List<string>> avList = dbc.getList("Availability");
            return parseStringList(avList);
        }

        public static List<Availability> getForDayAndTime(string[] parameters)
        {
            DBConnector dbc = new DBConnector();
            string[] paramNames = new string[2];
            paramNames[0] = "Day";
            paramNames[1] = "Time";
            List<List<string>> avList = dbc.getListWhere("Availability", paramNames, parameters);
            return parseStringList(avList); ;
        }

        //get the info from DB
        public void loadRecord()
        {
            List<string> l = dbc.get("Availability", Id);

            Day = Int32.Parse(l[1]);
            Time = DateTime.Parse(l[2]);
            TutorId = Int32.Parse(l[3]);
         
        }

        //used when updating and inserting records in DB
        override public string[] getParameters()
        {
            string[] s = new string[9];

            s[0] = Id.ToString();
            s[1] = Day.ToString();
            s[2] = Time.ToString();
            s[3] = TutorId.ToString();

            return s;
        }

        //used when updating and inserting records in DB
        override public string[] getParameterNames()
        {
            string[] s = new string[9];

            //those are name of the fields in the database
            s[0] = "Id";
            s[1] = "Day";
            s[2] = "Time";
            s[3] = "TutorId";

            return s;
        }
    }
}
