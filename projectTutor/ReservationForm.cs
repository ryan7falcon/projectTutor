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
        int week = 0;
        DateTime today = DateTime.Now;

        public ReservationForm()
        {
            InitializeComponent();
            dbc = new DBConnector();
            lblToday.Text = today.ToShortDateString() + ", " + today.DayOfWeek;
            PopulateDates();
        }

        private void PopulateDates()
        {           
            lblDay1.Text = getDate(week, 1).ToShortDateString();
            lblDay2.Text = getDate(week, 2).ToShortDateString();
            lblDay3.Text = getDate(week, 3).ToShortDateString();
            lblDay4.Text = getDate(week, 4).ToShortDateString();
            lblDay5.Text = getDate(week, 5).ToShortDateString();
        }


        private DateTime getDate(int week, int day)
        {
           return today.AddDays(day- (int)today.DayOfWeek + 7*week);
        }
     

        //get a Customer object using info from DB
        private Reservation getReservationFromDB(int index)
        {
            List<string> l = dbc.get("Reservation", index);
            return new Reservation(Int32.Parse(l[0]), DateTime.Parse(l[1]), Int32.Parse(l[2]), Int32.Parse(l[3]));
        }

        private void btnConfirmStuId_Click(object sender, EventArgs e)
        {
            //check if student with the given id exists and reflect it in text of the label lblStuIdConfirmed
            checkStudent();

            //override buttons
           
           
        }

        private void checkStudent()
        {
            bool stuExist = dbc.checkIfExist("Student", Int32.Parse(nStuId.Text));

            if (stuExist)
            {
                lblStuIdConfirmed.Text = "Student " + nStuId.Text + " found";
            }
            else
            {
                lblStuIdConfirmed.Text = "Student " + nStuId.Text + " not found";
            }
        }


        private Student getStudentFromDB(int index)
        {
            List<string> l = dbc.get("Student", index);
            return new Student(Int32.Parse(l[0]), l[1], l[2], Int32.Parse(l[3]));
        }

        private void processBtn(int day, int timeSlot)
        {
            DateTime date = getDate(week, day);

        }

        private string GetStartTime(int timeslot)
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

        private void updateCalendar()
        {
            PopulateDates();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            week++;
            updateCalendar();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            week--;
            updateCalendar();
        }

        private void b1_1_Click(object sender, EventArgs e)
        {
            processBtn(1, 1);
        }

        private void b1_2_Click(object sender, EventArgs e)
        {
            processBtn(1, 2);
        }

        private void b1_3_Click(object sender, EventArgs e)
        {
            processBtn(1, 3);
        }

        private void b1_4_Click(object sender, EventArgs e)
        {
            processBtn(1, 4);
        }
    }
}
