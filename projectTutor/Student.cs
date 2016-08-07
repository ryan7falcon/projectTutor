using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectTutor
{
    public class Student : Record
    {
        DBConnector dbc = new DBConnector();

        public int Id { set; get; }
        public string Name { set; get; }
        public string Program { set; get; }
        public int StartYear { set; get; }

        public Student(int id)
        {
            this.Id = id;
        }

        public Student(int id, string name, string program, int start)
        {
            this.Id = id;
            this.Name = name;
            this.Program = program;
            this.StartYear = start;
        }

        public static List<Student> getAll()
        {
            List<Student> stu = new List<Student>();
            DBConnector dbc = new DBConnector();

            List<List<string>> stuList = dbc.getList("Student");
            foreach (List<string> list in stuList)
            {
                Student r = new Student(Int32.Parse(list[0]), list[1], list[2], Int32.Parse(list[3]));
                stu.Add(r);
            }

            return stu;
        }

        //get the info from DB
        public void loadRecord()
        {
            List<string> l = dbc.get("Student", Id);

            Name = l[1];
            Program = l[2];
            StartYear = Int32.Parse(l[3]);
        }

        //used when updating and inserting records in DB
        override public string[] getParameters()
        {
            string[] s = new string[4];

            s[0] = Id.ToString();
            s[1] = Name;
            s[2] = Program;
            s[3] = StartYear.ToString();

            Console.WriteLine(s);
            return s;
        }

        //used when updating and inserting records in DB
        override public string[] getParameterNames()
        {
            string[] s = new string[4];

            //those are name of the fields in the database
            s[0] = "Id";
            s[1] = "Name";
            s[2] = "Program";
            s[3] = "StartYear";

            return s;
        }
    }
}
