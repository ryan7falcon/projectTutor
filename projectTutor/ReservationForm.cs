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
        MakeReservationForm makeRegForm;
        SqlConnection con;
        DBConnector dbc;
        Reservation res;
        int week = 0;
        DateTime today = DateTime.Now;
        Student stu;

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
                stu = getStudentFromDB(Int32.Parse(nStuId.Text));
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

        //on time slot button click open a make registration form with the picked time, day and student
        //this form will allow to pick a tutor and a room and finish the reservation 
        private void processBtn(int day, int timeSlot)
        {
            //get the date and time
            DateTime date = getDate(week, day);
            string time = GetStartTime(timeSlot);
            //get the student
            checkStudent();
            if (stu == null)
            {
                MessageBox.Show("Choose a valid student Id first");
            }
            else
            {
                //open make reservation form

                if (makeRegForm == null)
                {
                    makeRegForm = new MakeReservationForm(date, time, stu);
                    makeRegForm.FormClosed += MakeRegForm_FormClosed;
                    makeRegForm.Show();
                }
                else
                {
                    makeRegForm.Activate();
                }
            }
        }

        private void MakeRegForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            makeRegForm = null;
        }

        //get a string for the timeslot from an int
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

        //enable and disable buttons depending on availability
        private void enableButtons()
        {

        }

        //update dates and buttons to reflect another week
        private void updateCalendar()
        {
            PopulateDates();
            enableButtons();
        }

        //go to next week
        private void btnNext_Click(object sender, EventArgs e)
        {
            week++;
            updateCalendar();
        }

        //go to previous week
        private void btnPrev_Click(object sender, EventArgs e)
        {
            week--;
            updateCalendar();
        }

        //on time slots button click (day, timeslot)
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
