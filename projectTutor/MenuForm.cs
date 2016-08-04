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
    public partial class MenuForm : Form
    {
        ReservationForm regForm;
        StudentForm studentForm;
        RoomForm roomForm;
        //TutorForm tutorForm;
        

        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void reservationMainMenuItem_Click(object sender, EventArgs e)
        {
            if (regForm == null)
            {
                regForm = new ReservationForm();
                //regForm.MdiParent = this;
                regForm.FormClosed += RegForm_FormClosed;
                regForm.Show();
            }
            else
            {
                regForm.Activate();
            }
        }

        private void RegForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            regForm = null;
        }

        private void studentMainMenuItem_Click(object sender, EventArgs e)
        {
            if (studentForm == null)
            {
                studentForm = new StudentForm();
                studentForm.FormClosed += StudentForm_FormClosed;
                studentForm.Show();
            }
            else
            {
                studentForm.Activate();
            }
        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            studentForm = null;
        }

        private void roomMainMenuItem_Click(object sender, EventArgs e)
        {
            if (roomForm == null)
            {
                roomForm = new RoomForm();
                roomForm.FormClosed += RoomForm_FormClosed;
                roomForm.Show();
            }
            else
            {
                roomForm.Activate();
            }
        }

        private void RoomForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            roomForm = null;
        }

        /*private void tutorMainMenuItem_Click(object sender, EventArgs e)
        {
            if (tutorForm == null)
            {
                tutorForm = new TutorForm();
                tutorForm.FormClosed += TutorForm_FormClosed;
                tutorForm.Show();
            }
            else
            {
                tutorForm.Activate();
            }
        }

        private void TutorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            tutorForm = null;
        }*/

    }
}
