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
        DateTime date;
        string time;
        Student stu;
        Tutor tut;
        string room;

        public MakeReservationForm(DateTime date, string time, Student stu)
        {
            InitializeComponent();
            this.date = date;
            this.time = time;
            this.stu = stu;
            lblStudent.Text = stu.Name;
            lblDate.Text = date.ToShortDateString() + " " + time;
        }


        private void btnSubmitReservation_Click(object sender, EventArgs e)
        {
            //show receipt

            Receipt receipt = new Receipt(date, time, stu, tut, room);         
            receipt.Show();          
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
