using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

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
        List<Button> buttons;

        public ReservationForm()
        {
            InitializeComponent();
            dbc = new DBConnector();
            lblToday.Text = today.ToShortDateString() + ", " + today.DayOfWeek;

            //populate buttons list
            buttons = this.Controls.OfType<Button>().ToList();
            Button toExclude = buttons.Single(obj => obj.Name == "btnNext");
            buttons.Remove(toExclude);
            toExclude = buttons.Single(obj => obj.Name == "btnPrev");
            buttons.Remove(toExclude);
            toExclude = buttons.Single(obj => obj.Name == "btnDelete");
            buttons.Remove(toExclude);

            updateCalendar();

            updateList();

        }

        private void updateList()
        {
            lvResList.Items.Clear();

            List<Reservation> resList = Reservation.getAll();
            //get all the customers from the database
            List<List<string>> listOfLists = dbc.getList("Reservation");
            foreach (List<string> list in listOfLists)
            {
                //fill in one row in the listView
                Reservation res = new Reservation(Int32.Parse(list[0]), Int32.Parse(list[1]), DateTime.Parse(list[2]), Int32.Parse(list[3]), Int32.Parse(list[4]));
                ListViewItem item = new ListViewItem(new[] { res.Id.ToString(), res.StudentId.ToString(), res.TutorId.ToString(), res.RoomId.ToString(), res.TimeSlot.ToString() });
                lvResList.Items.Add(item);
            }

        }

        private class TwoLists{
            public List<Tutor> tuts { set; get; }
            public List<Room> rooms { set; get; }
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
           return today.AddDays(day - (int)today.DayOfWeek + 7*week);
        }
     

        //get a Customer object using info from DB
        private Reservation getReservationFromDB(int index)
        {
            List<string> l = dbc.get("Reservation", index);
            return new Reservation(Int32.Parse(l[0]), Int32.Parse(l[1]), DateTime.Parse(l[2]), Int32.Parse(l[3]), Int32.Parse(l[4]));
        }

        //check if a student with given Id exists and display their name
        private void nStuId_ValueChanged(object sender, EventArgs e)
        {
            checkStudent((int)nStuId.Value);
        }

        //check if student with the given id exists and reflect it in text of the label lblStuIdConfirmed
        private void checkStudent(int id)
        {
            bool stuExist = dbc.checkIfExist("Student",id);

            if (stuExist)
            {               
                stu = getStudentFromDB(id);
                lblStuIdConfirmed.Text = stu.Name;
            }
            else
            {
                lblStuIdConfirmed.Text = "Student " + id + " not found";
            }
        }

        //get a Student obj given an Id by looking up in the database
        private Student getStudentFromDB(int index)
        {
            List<string> l = dbc.get("Student", index);
            return new Student(Int32.Parse(l[0]), l[1], l[2], Int32.Parse(l[3]));
        }

        //returns true if there is a room and a tutor available for this date and time (date is calculated using the day and the week)
        private bool checkButton(int day, int timeSlot)
        {
            TwoLists arr = getTutorsAndRooms(day, timeSlot);
            if (arr.tuts == null || arr.rooms == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //returns a class that contains a list of tutors and a list of rooms available for this date and time (date is calculated using the day and the week)
        private TwoLists getTutorsAndRooms(int day, int timeSlot)
        {
            TwoLists arr = new TwoLists();

            //get the date and time
            DateTime date = getDate(week, day);
            //get the student
            checkStudent((int)nStuId.Value);
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

                string[] dayTime = new string[] { ((int)date.DayOfWeek).ToString(), Reservation.GetStartTime(timeSlot) };
                string[] dateArr = new string[] { date.ToShortDateString() + " " + Reservation.GetStartTime(timeSlot) };
                //check availability table for the date and time
                List<Availability> avs = Availability.getForDayAndTime(dayTime);

                if (avs.Count == 0)
                {
                    //MessageBox.Show("No available tutors for " + date.DayOfWeek + " " + dayTime[1]);
                    return arr;
                }
                //check room table for the date and time
                List<Room> rms = Room.getForDayAndTime(dayTime);

                if (rms.Count == 0)
                {
                    //MessageBox.Show("No available rooms for " + date.DayOfWeek + " " + dayTime[1]);
                    return arr;
                }

                //check reservation table for the date, time, tutor and room
                //discard availability records and room records according to reservations
                List<Reservation> ress = Reservation.getForDayAndTime(dateArr);

                if (ress.Count != 0)
                {
                    foreach (Reservation res in ress)
                    {
                        //remove tutor

                        Availability av = avs.Single(obj => obj.TutorId == res.TutorId);
                        avs.Remove(av);

                        //remove room
                        Room rm = rms.Single(obj => obj.Id == res.RoomId);
                        rms.Remove(rm);
                    }
                }

                //if there are noo tutors or rooms available, return
                if (avs.Count == 0 || rms.Count == 0)
                {
                    return arr;
                }
                else
                {
                    //get tutors from availability list
                    foreach (Availability av in avs)
                    {
                        Tutor t = new Tutor(av.TutorId);
                        t.loadRecord();
                        tuts.Add(t);
                    }

                    arr.tuts = tuts;
                    arr.rooms = rms;
                    return arr;
                }
            }
                return arr;

        }

        //on time slot button click open a make registration form with the picked time, day and student
        //this form will allow to pick a tutor and a room and finish the reservation 
        private void processBtn(int day, int timeSlot)
        {
            bool stuExist = dbc.checkIfExist("Student", Int32.Parse(nStuId.Text));

            if (!stuExist)
            {
                MessageBox.Show("Choose a valid student id first");
                return;
            }
                //TODO: prevent from processing if student is not valid
                //TODO: show all reservations
                //get rooms and tutors
                TwoLists arr = getTutorsAndRooms(day, timeSlot);
            //get the date and time
            DateTime date = getDate(week, day);

            makeRegForm = new MakeReservationForm(date, timeSlot, stu, arr.tuts, arr.rooms);
            makeRegForm.FormClosed += MakeRegForm_FormClosed;
            makeRegForm.ReservationMade += makeRegForm_ReservationMade;
            makeRegForm.Show();
                                        
        }

        private void makeRegForm_ReservationMade(object sender, EventArgs e)
        {
            updateCalendar();
            updateList();
        }

        private void MakeRegForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            makeRegForm = null;
        }

        //enable and disable buttons depending on availability
        private void enableButtons()
        {        
            foreach(Button b in buttons)
            {
                b.Enabled = true;
            }
        }

        private void disableButtons()
        {
            //TODO: disable buttons that have no matching tutor and room available for their time
            foreach (Button b in buttons)
            {
                //get the day and the timeslot that this button belongs to using its name 
                //(b1_1 would be Monday 9am, b2_1 - tuesday 9am, b3_2 - Wednsday 10 am)
                string name = b.Name;
                string pattern = @"b(\d+)_(\d+)";
                int day = -1;
                int timeSlot = -1;
                foreach (Match m in Regex.Matches(name, pattern))
                {
                    day = Int32.Parse(m.Groups[1].Value);
                    timeSlot = Int32.Parse(m.Groups[2].Value);
                }
                if ( day!=-1 && timeSlot!= -1){
                    //check if this time and day has available tutors and rooms and if not, disable the button
                    if( !checkButton(day, timeSlot))
                    {
                        b.Enabled = false;
                    }                       
                }               
            }
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dbc.delete("Reservation", res.Id);
            updateList();
            updateCalendar();
        }

        private void lvResList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedListViewItemCollection items = lvResList.SelectedItems;
            if (items.Count > 0)
            {
                int index = Int32.Parse(items[0].Text);
                res = new Reservation(index);
            }
        }
    }
}
