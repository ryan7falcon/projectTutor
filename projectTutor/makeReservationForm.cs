using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectTutor
{
    public partial class MakeReservationForm : Form
    {
        DBConnector dbc = new DBConnector();
        DateTime date;
        int timeSlot;
        Student stu;
        List<Tutor> tuts;
        Tutor selectedTut;
        List<Room> rooms;
        Room selectedRoom;

        public MakeReservationForm(DateTime date, int timeSlot, Student stu, List<Tutor> tuts, List<Room> rooms)
        {
            InitializeComponent();
            this.date = date;
            this.timeSlot = timeSlot;
            this.stu = stu;
            this.tuts = tuts;
            this.rooms = rooms;

            //populate controls
            lblStudent.Text = stu.Name;
            lblDate.Text = date.ToShortDateString() + " " + Reservation.GetStartTime(timeSlot);

            foreach (Tutor tut in tuts){
                cbTutor.Items.Add(tut.Name);
            }
            foreach (Room room in rooms)
            {
                cbRoom.Items.Add(room.Name);
            }
            cbTutor.SelectedIndex = 0;
            cbRoom.SelectedIndex = 0;

            //TODO: get a list of Tutors and rooms for the chosen time, show them in combo boxes, update tut and room vars, print the price
        }

        

        private void btnSubmitReservation_Click(object sender, EventArgs e)
        {
            //show receipt

            Receipt receipt = new Receipt(date, Reservation.GetStartTime(timeSlot), stu, selectedTut, selectedRoom);         
            receipt.Show();


            //add reservation to the database
            Reservation res = new Reservation(dbc.getLastId("Reservation") + 1, stu.Id, date.Date +  TimeSpan.Parse(Reservation.GetStartTime(timeSlot)), selectedTut.Id, selectedRoom.Id);
            dbc.insert("Reservation", res);
                   
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTut = tuts[cbTutor.SelectedIndex];
            lblPrice.Text = "$" + selectedTut.HourlyRate.ToString();
            lblTutorLevel.Text = Tutor.getLevelName(selectedTut.Level);
            lblSubjects.Text = selectedTut.Subjects;
        }

        private void cbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRoom = rooms[cbRoom.SelectedIndex];
        }
    }
}
