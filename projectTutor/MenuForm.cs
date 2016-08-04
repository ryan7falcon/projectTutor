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
        TutorForm tutorForm;

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

        private void tutorMainMenuItem_Click(object sender, EventArgs e)
        {
            if (tutorForm == null)
            {
                tutorForm = new TutorForm();
                //regForm.MdiParent = this;
                tutorForm.FormClosed += tutorForm_FormClosed;
                tutorForm.Show();
            }
            else
            {
                tutorForm.Activate();
            }
        }
        private void tutorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            tutorForm = null;
        }
    }
}
