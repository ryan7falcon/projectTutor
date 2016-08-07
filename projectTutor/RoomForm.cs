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

namespace projectTutor
{
    public partial class RoomForm : Form
    {
        DBConnector dbc;
        Room room;

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
        }

        private void loadInputs()
        {
            //Add items in the combobox
            roomBox.Items.AddRange(new Object[] {
                "Room 1",
                "Room 2",
            });

            //Add items in the combobox
            //Can I refactor this later with convertDay to have one declaration of all the days?
            dayBox.Items.AddRange(new Object[] {
                days[0], days[1], days[2],
                days[3], days[4]
            });


            //Add items in the combobox
            timeBox.Items.AddRange(new Object[] {
                "8:00 AM",
                "10:00 AM",
                "11:00 AM",
                "12:00 PM",
                "1:00 PM",
                "2:00 PM",
                "3:00 PM",
                "4:00 PM",
                "5:00 PM"
            });

        }

        private void savedButton_Click(object sender, EventArgs e)
        {
            //Get all the inputs from user
            String aRoom = roomBox.Text;
            String day = dayBox.Text;
            String time = timeBox.Text;

            
            //Check the last id of the user in the database and add 1
            int id = dbc.getLastId("Room") + 1;


            //Create new room object then pass to database
            room = new Room(id, aRoom, convertDay(day), convertTime(time));

            dbc.insert("Room", room);
            MessageBox.Show("Added room");

        }

        private int convertDay(String n)
        {
            int day = 0;


            //Match the n input into the specified date.
            for(int i = 1; i < days.Length; i++)
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

        private DateTime convertTime(String t)
        {
            //Find time
            Regex regexTime = new Regex(@"^\d+");
            Match matchTime = regexTime.Match(t);
            //Find am or pm
            Regex regexDay = new Regex(@"^?[AP]M$");
            Match matchDay = regexDay.Match(t);

            if (matchDay.ToString() == "AM")
            {
                //Convert matchTime into datetime format
                return DateTime.Parse(matchTime + ":00");
            }
            else
            {
                //Will have to refactor this
                if (matchTime.ToString() == "1")
                {

                }
            }
           
        }
    }

    
}
