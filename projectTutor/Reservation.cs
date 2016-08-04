using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectTutor
{
    class Reservation : Record
    {

        DBConnector dbc = new DBConnector();

        public int Id { set; get; }
        public DateTime TimeSlot { set; get; }
        public int TutorId { set; get; }
        public int RoomId { set; get; }
        
        public Reservation(int id)
        {
            this.Id = id;
        }

        public Reservation(int id, DateTime time, int tutor, int room)
        {
            this.Id = id;
            this.TimeSlot = time;
            this.TutorId = tutor;
            this.RoomId = room;
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
            string[] s = new string[9];

            s[0] = Id.ToString();
            s[1] = TimeSlot.ToString();
            s[2] = TutorId.ToString();
            s[3] = RoomId.ToString();

            return s;
        }

        //used when updating and inserting records in DB
        override public string[] getParameterNames()
        {
            string[] s = new string[9];

            //those are name of the fields in the database
            s[0] = "Id";
            s[1] = "TimeSlot";
            s[2] = "TutorId";
            s[3] = "RoomId";

            return s;
        }
    }
}
