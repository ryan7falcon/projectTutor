using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectTutor
{
    public partial class ReservationForm : Form
    {
        SqlConnection con;
        DBConnector dbc;
        Reservation res;

        public ReservationForm()
        {
            InitializeComponent();
            dbc = new DBConnector();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            con = dbc.getConnection();

            //get the first index
            int first = dbc.getFirstId("Reservation");

            //get the first reservation
            res = getReservationFromDB(first);

        }


        //get a Customer object using info from DB
        private Reservation getReservationFromDB(int index)
        {
            List<string> l = dbc.get("Reservation", index);
            return new Reservation(Int32.Parse(l[0]), DateTime.Parse(l[1]), Int32.Parse(l[2]), Int32.Parse(l[3]));
        }

        private void btnConfirmStuId_Click(object sender, EventArgs e)
        {
            Student stu = getStudentFromDB(Int32.Parse(nStuId.Text)); 

           
        }

        private Student getStudentFromDB(int index)
        {
            List<string> l = dbc.get("Student", index);
            return new Student(Int32.Parse(l[0]), l[1], l[2], Int32.Parse(l[3]));
        }
    }
}
