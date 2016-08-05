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
    public partial class StudentForm : Form
    {
        SqlConnection con;
        DBConnector dbc;
        Student student;

        public StudentForm()
        {
            InitializeComponent();
            dbc = new DBConnector();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
        private void saveStudenFormButton_Click(object sender, EventArgs e)
        {
            con = dbc.getConnection();
            
            //Get all the inputs from user 
            String studentName = nameStudentFormMaskedBox.Text;
            String studentProgram = programStudentFormMaskedBox.Text;
            int startDate = Convert.ToInt32(startDateFormMaskedBox.Text);

            //Add to student object
            student = new Student(5, studentName, studentProgram, startDate);


            //Pass data to database
            dbc.insert("Student", student);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
