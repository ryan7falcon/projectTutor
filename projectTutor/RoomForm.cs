using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace projectTutor
{
    public partial class RoomForm : Form
    {
        DBConnector dbc;
        Room room;
        int roomId;

        String[] days = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday"
            };


        public RoomForm()
        {
            InitializeComponent();

            dbc = new DBConnector();
            loadInputs();
            getRooms();
        }

        private void loadInputs()
        {

            //Add items in the combobox
            //Can I refactor this later with convertDay to have one declaration of all the days?
            dayBox.Items.AddRange(new Object[] {
                days[0], days[1], days[2],
                days[3], days[4]
            });

        }

        private void savedButton_Click(object sender, EventArgs e)
        {
            if (dbc.checkIfExist("Room", roomId))
            {
                //Get the selected item
                //Pass it to rooms object
                room.Name = roomBox.Text;
                room.Day = convertDay(dayBox.Text);
                room.Time = DateTime.Parse(dateTimePicker.Text);

                dbc.update("Room", room);
                MessageBox.Show("Updated room");

            }
            else
            {

                //Get all the inputs from user
                String aRoom = roomBox.Text;
                String day = dayBox.Text;
                DateTime time = DateTime.Parse(dateTimePicker.Text);

                //Check the last id of the user in the database and add 1
                int id = dbc.getLastId("Room") + 1;


                //Create new room object then pass to database
                room = new Room(id, aRoom, convertDay(day), time);

                dbc.insert("Room", room);
                MessageBox.Show("Added room");
            }
            //Update rooms list
            getRooms();
            refreshForm();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            //Find roomId in reservation table.
            //If found in reservation do not delete room
            if (dbc.checkRoomId(roomId))
            {
                MessageBox.Show("Cannot delete room due to referential integrity");
            }
            else
            {
                //fillForm.studentId is extracted
                dbc.delete("Room", roomId);

                MessageBox.Show("Deleted Room");

                //Update students list
                getRooms();
                refreshForm();
            }
        }

        private int convertDay(String n)
        {
            int day = 0;


            //Match the n input into the specified date.
            for(int i = 0; i < days.Length; i++)
            {
                //Loop once to find the index number of the day
                if (days[i] == n)
                {
                    //Add one, because array starts with zero.
                    day = i + 1;
                }
            }
            //Then return the number
            return day;
        }

        //Converts back to a day of the week string
        private string convertBackToDay(int n)
        {
            n = n - 1;
            return days[n];
        }


        private void roomListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedListViewItemCollection roomItems = roomListView.SelectedItems;

            if (roomItems.Count > 0)
            {
                //Patch for now//
                //Find the room id
                Regex regex = new Regex(@"^\d+");
                Match match = regex.Match(roomItems[0].Text);

                //Select the id number of the selected student
                int index = Int32.Parse(match.ToString());

                //Get the selected Student from the database student
                room = getRoom(index);

                fillForm();

            }


        }

        //Load a specific student from the database students
        private Room getRoom(int index)
        {
            List<string> aRoom = dbc.get("Room", index);
            return new Room(Int32.Parse(aRoom[0]), aRoom[1],
                             Int32.Parse(aRoom[2]), DateTime.Parse(aRoom[3]));
        }

        //Load all the current students in the database Students
        private void getRooms()
        {
            roomListView.Clear();

            //Get the current students in the database
            List<List<string>> roomsList = dbc.getList("Room");
            //Loop through each to get a student in studentList
            foreach (List<string> room in roomsList)
            {
                //Pass each student to class Student
                Room aRoom = new Room(Int32.Parse(room[0]), room[1],
                             Int32.Parse(room[2]), DateTime.Parse(room[3]));


                //Pass student object to List object
                /*Need to refactor*/
                ListViewItem roomItem = new ListViewItem(new[]{
                    aRoom.Id.ToString() + " " + aRoom.Name + " " +
                    convertBackToDay(aRoom.Day) + " " + aRoom.Time.ToString()
                });
                //Append to studentLisView to display
                roomListView.Items.Add(roomItem);
            }
        }

        private void fillForm()
        {
            roomId = room.Id;
            roomBox.Text = room.Name;
            dayBox.Text = room.Day.ToString();
            dateTimePicker.Text = room.Time.ToString();
        }

        private void refreshForm()
        {
            roomId = 0;
            roomBox.Text = "";
            dayBox.Text = "";
            dateTimePicker.Text = "";

        }

        private void roomBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dayBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
