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

        //print dates below each day of the week
        private void PopulateDates()
        {           
            lblDay1.Text = getDate(week, 1).ToShortDateString();
            lblDay2.Text = getDate(week, 2).ToShortDateString();
            lblDay3.Text = getDate(week, 3).ToShortDateString();
            lblDay4.Text = getDate(week, 4).ToShortDateString();
            lblDay5.Text = getDate(week, 5).ToShortDateString();
        }

        //get a date given the week and day of the week
        private DateTime getDate(int week, int day)
        {
           return today.AddDays(day- (int)today.DayOfWeek + 7*week);
        }
     

        //get a Customer object using info from DB
        private Reservation getReservationFromDB(int index)
        {
            List<string> l = dbc.get("Reservation", index);
            return new Reservation(Int32.Parse(l[0]), Int32.Parse(l[1]), DateTime.Parse(l[2]), Int32.Parse(l[3]), Int32.Parse(l[4]));
        }

        //check if a student with given Id exists and display their name
        private void btnConfirmStuId_Click(object sender, EventArgs e)
        {           
            checkStudent();            
        }

        //check if student with the given id exists and reflect it in text of the label lblStuIdConfirmed
        private void checkStudent()
        {
            bool stuExist = dbc.checkIfExist("Student", Int32.Parse(nStuId.Text));

            if (stuExist)
            {               
                stu = getStudentFromDB(Int32.Parse(nStuId.Text));
                lblStuIdConfirmed.Text = stu.Name;
            }
            else
            {
                lblStuIdConfirmed.Text = "Student " + nStuId.Text + " not found";
            }
        }

        //get a Student obj given an Id by looking up in the database
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
            //get the student
            checkStudent();
            if (stu == null)
            {
                MessageBox.Show("Choose a valid student Id first");
            }
            else
            {
                //open make reservation form

                if (makeRegForm != null)
                {
                    makeRegForm.Close();
                }

                List<Tutor> tuts = new List<Tutor>();
                List<Room> rooms = new List<Room>();

                //TODO: change getList to something that gets relevant info for the chosen date and time
                //check availability table for the date and time

                //check room table for the date and time

                //check reservation table for the date, time, tutor and room

                //discard availability records and room records according to reservations

                //if there is something left, proceed

                //get all tutors
                tuts = Tutor.getAll();

                //get all rooms
                rooms = Room.getAll();

                makeRegForm = new MakeReservationForm(date, timeSlot, stu, tuts, rooms);
                makeRegForm.FormClosed += MakeRegForm_FormClosed;
                makeRegForm.Show();
                
               
            }
        }

        private void MakeRegForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            makeRegForm = null;
        }

       

        //enable and disable buttons depending on availability
        private void enableButtons()
        {
           //TODO: enable all buttons
        }

        private void disableButtons()
        {
            //TODO: disable buttons that have no matching tutor and room available for their time
        }

        //update dates and buttons to reflect another week
        private void updateCalendar()
        {
            PopulateDates();
            enableButtons();
            disableButtons();
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

        private void b1_5_Click(object sender, EventArgs e)
        {
            processBtn(1, 5);
        }

        private void b1_6_Click(object sender, EventArgs e)
        {
            processBtn(1, 6);
        }

        private void b1_7_Click(object sender, EventArgs e)
        {
            processBtn(1, 7);
        }

        private void b1_8_Click(object sender, EventArgs e)
        {
            processBtn(1, 8);
        }

        private void b1_9_Click(object sender, EventArgs e)
        {
            processBtn(1, 9);
        }

        private void b1_10_Click(object sender, EventArgs e)
        {
            processBtn(1, 10);
        }

        private void b2_1_Click(object sender, EventArgs e)
        {
            processBtn(2, 1);
        }

        private void b2_2_Click(object sender, EventArgs e)
        {
            processBtn(2, 2);
        }

        private void b2_3_Click(object sender, EventArgs e)
        {
            processBtn(2, 3);
        }

        private void b2_4_Click(object sender, EventArgs e)
        {
            processBtn(2, 4);
        }

        private void b2_5_Click(object sender, EventArgs e)
        {
            processBtn(2, 5);
        }

        private void b2_6_Click(object sender, EventArgs e)
        {
            processBtn(2, 6);
        }

        private void b2_7_Click(object sender, EventArgs e)
        {
            processBtn(2, 7);
        }

        private void b2_8_Click(object sender, EventArgs e)
        {
            processBtn(2, 8);
        }

        private void b2_9_Click(object sender, EventArgs e)
        {
            processBtn(2, 9);
        }

        private void b2_10_Click(object sender, EventArgs e)
        {
            processBtn(2, 10);
        }

        private void b3_1_Click(object sender, EventArgs e)
        {
            processBtn(3, 1);
        }

        private void b3_2_Click(object sender, EventArgs e)
        {
            processBtn(3, 2);
        }

        private void b3_3_Click(object sender, EventArgs e)
        {
            processBtn(3, 3);
        }

        private void b3_4_Click(object sender, EventArgs e)
        {
            processBtn(3, 4);
        }

        private void b3_5_Click(object sender, EventArgs e)
        {
            processBtn(3, 5);
        }

        private void b3_6_Click(object sender, EventArgs e)
        {
            processBtn(3, 6);
        }

        private void b3_7_Click(object sender, EventArgs e)
        {
            processBtn(3, 7);
        }

        private void b3_8_Click(object sender, EventArgs e)
        {
            processBtn(3, 8);
        }

        private void b3_9_Click(object sender, EventArgs e)
        {
            processBtn(3, 9);
        }

        private void b3_10_Click(object sender, EventArgs e)
        {
            processBtn(3, 10);
        }

        private void b4_1_Click(object sender, EventArgs e)
        {
            processBtn(4, 1);
        }

        private void b4_2_Click(object sender, EventArgs e)
        {
            processBtn(4, 2);
        }

        private void b4_3_Click(object sender, EventArgs e)
        {
            processBtn(4, 3);
        }

        private void b4_4_Click(object sender, EventArgs e)
        {
            processBtn(4, 4);
        }

        private void b4_5_Click(object sender, EventArgs e)
        {
            processBtn(4, 5);
        }

        private void b4_6_Click(object sender, EventArgs e)
        {
            processBtn(4, 6);
        }

        private void b4_7_Click(object sender, EventArgs e)
        {
            processBtn(4, 7);
        }

        private void b4_8_Click(object sender, EventArgs e)
        {
            processBtn(4, 8);
        }

        private void b4_9_Click(object sender, EventArgs e)
        {
            processBtn(4, 9);
        }

        private void b4_10_Click(object sender, EventArgs e)
        {
            processBtn(4, 10);
        }

        private void b5_1_Click(object sender, EventArgs e)
        {
            processBtn(5, 1);
        }

        private void b5_2_Click(object sender, EventArgs e)
        {
            processBtn(5, 2);
        }

        private void b5_3_Click(object sender, EventArgs e)
        {
            processBtn(5, 3);
        }

        private void b5_4_Click(object sender, EventArgs e)
        {
            processBtn(5, 4);
        }

        private void b5_5_Click(object sender, EventArgs e)
        {
            processBtn(5, 5);
        }

        private void b5_6_Click(object sender, EventArgs e)
        {
            processBtn(5, 6);
        }

        private void b5_7_Click(object sender, EventArgs e)
        {
            processBtn(5, 7);
        }

        private void b5_8_Click(object sender, EventArgs e)
        {
            processBtn(5, 8);
        }

        private void b5_9_Click(object sender, EventArgs e)
        {
            processBtn(5, 9);
        }

        private void b5_10_Click(object sender, EventArgs e)
        {
            processBtn(5, 10);
        }
    }
}
