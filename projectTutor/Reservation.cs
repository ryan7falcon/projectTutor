using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectTutor
{
    public class Reservation : Record
    {

        //get a string for the timeslot from an int
        public static string GetStartTime(int timeslot)
        {
            string time;
            switch (timeslot)
            {
                case 1:
                    time = "09:00:00";
                    break;
                case 2:
                    time = "10:00:00";
                    break;
                case 3:
                    time = "11:00:00";
                    break;
                case 4:
                    time = "12:00:00";
                    break;
                case 5:
                    time = "13:00:00";
                    break;
                case 6:
                    time = "14:00:00";
                    break;
                case 7:
                    time = "15:00:00";
                    break;
                case 8:
                    time = "16:00:00";
                    break;
                case 9:
                    time = "17:00:00";
                    break;
                case 10:
                    time = "18:00:00";
                    break;
                default:
                    time = "09:00:00";
                    break;
            }

            return time;
        }

        DBConnector dbc = new DBConnector();

        public int Id { set; get; }
        public int StudentId { set; get; }
        public DateTime TimeSlot { set; get; }
        public int TutorId { set; get; }
        public int RoomId { set; get; }
        
        public Reservation(int id)
        {
            this.Id = id;
        }

        public Reservation(int id, int studId, DateTime time, int tutor, int room)
        {
            this.Id = id;
            this.StudentId = studId;
            this.TimeSlot = time;
            this.TutorId = tutor;
            this.RoomId = room;
        }

        //convert a string list to reservation list
        public static List<Reservation> parseStringList(List<List<string>> strList)
        {
            List<Reservation> res = new List<Reservation>();

            foreach (List<string> list in strList)
            {
                Reservation r = new Reservation(Int32.Parse(list[0]), Int32.Parse(list[1]), DateTime.Parse(list[2]), Int32.Parse(list[3]), Int32.Parse(list[4]));
                res.Add(r);
            }
            return res;
        }

        //get all records from the database
        public static List<Reservation> getAll()
        {
           
            DBConnector dbc = new DBConnector();
            List<List<string>> resList = dbc.getList("Reservation");         
            return parseStringList(resList);
        }

        public static List<Reservation> getForDayAndTime(string[] parameters)
        {
            DBConnector dbc = new DBConnector();
            string[] paramNames = new string[1];
            paramNames[0] = "TimeSlot";
            List<List<string>> list = dbc.getListWhere("Reservation", paramNames, parameters);
            return parseStringList(list); ;
        }

        //get the info from DB
        public void loadRecord()
        {
            List<string> l = dbc.get("Reservation", Id);

            TimeSlot = DateTime.Parse(l[1]);
            TutorId = Int32.Parse(l[2]);
            RoomId = Int32.Parse(l[3]);
        }

        //used when updating and inserting records in DB
        override public string[] getParameters()
        {
            string[] s = new string[5];

            s[0] = Id.ToString();
            s[1] = StudentId.ToString();
            s[2] = TimeSlot.ToString();
            s[3] = TutorId.ToString();
            s[4] = RoomId.ToString();

            return s;
        }

        //used when updating and inserting records in DB
        override public string[] getParameterNames()
        {
            string[] s = new string[5];

            //those are name of the fields in the database
            s[0] = "Id";
            s[1] = "StudentId";
            s[2] = "TimeSlot";
            s[3] = "TutorId";
            s[4] = "RoomId";

            return s;
        }
    }
}
