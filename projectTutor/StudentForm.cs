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

            //Testing load student to List
            getStudents();   
            
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

            //Get the last id of the table
            //Add one then increase by 1
            int id = dbc.getLastId("Student") + 1;

            //Add to student object
            student = new Student(id, studentName, studentProgram, startDate);

            //Pass data to database
            dbc.insert("Student", student);

            //Show that it is inserted
            MessageBox.Show("Added students");
        }

       

        //Load all the current students in the database Students
        private void getStudents()
        {
            studentListView.Clear();

            //Get the current students in the database
            List<List<string>> studentsList = dbc.getList("Student");
            //Loop through each to get a student in studentList
            foreach (List<string> student in studentsList)
            {
                //Pass each student to class Student
                Student aStudent = new Student(Int32.Parse(student[0]), student[1],
                                                student[2], Int32.Parse(student[3]));


                //Pass student object to List object
                /*Need to refactor*/
                ListViewItem studentItem = new ListViewItem(new[]{
                    aStudent.Id.ToString() + " " + aStudent.Name + " " +
                    aStudent.Program + " " + aStudent.StartYear.ToString()
                });
                //Append to studentLisView to display
                studentListView.Items.Add(studentItem);
            }
        }
    }
}
