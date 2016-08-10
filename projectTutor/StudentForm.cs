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
    public partial class StudentForm : Form
    {
        DBConnector dbc;
        Student student;

        //Global id for student in this form
        //The user should not be able to change their own id
        //Use this instead of nId
        int studentId;

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

            if (dbc.checkIfExist("Student", Int32.Parse(studentIdBox.Text)))
            {
                //Get all the inputs from user
                int studentId = Int32.Parse(studentIdBox.Text);
                String studentName = nameStudentFormMaskedBox.Text;
                String studentProgram = programStudentFormMaskedBox.Text;
                int startDate = Convert.ToInt32(startDateFormMaskedBox.Text);

                //Pass to student object
                student = new Student(studentId, studentName, studentProgram, startDate);

                //Pass the new updated student object to the database
                dbc.update("Student", student);
                MessageBox.Show("Updated student");
            }
            else
            {
                //Get all the inputs from user
                int studentId = Int32.Parse(studentIdBox.Text);
                String studentName = nameStudentFormMaskedBox.Text;
                String studentProgram = programStudentFormMaskedBox.Text;
                int startDate = Convert.ToInt32(startDateFormMaskedBox.Text);

                //Add to student object
                student = new Student(studentId, studentName, studentProgram, startDate);

                //Pass data to database
                dbc.insert("Student", student);

                //Show that it is inserted
                MessageBox.Show("Added students");
            }
                //Reload the form
                getStudents();
                refreshForm();
          }

        private void deleteStudentFormButton_Click(object sender, EventArgs e)
        {
            //Find studentId in reservation table.
            //If found in reservation do no delete student
            if (dbc.checkStudentId(student.Id))
            {
                MessageBox.Show("Cannot delete student due to referential integrity");
            }
            else
            {
                
                //fillForm.studentId is extracted
                dbc.delete("Student", studentId);

                MessageBox.Show("Deleted student");

                //Update students list
                getStudents();
                refreshForm();
            }
        }


        private void studentListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedListViewItemCollection studentItems = studentListView.SelectedItems;
            if (studentItems.Count > 0)
            {
                //Patch for now//
                //Find the student id
                Regex regex = new Regex(@"^\d+");
                Match match = regex.Match(studentItems[0].Text);

                //Select the id number of the selected student
                int index = Int32.Parse(match.ToString());

                //Get the selected Student from the database student
                student = getStudent(index);

                fillForm();

            }

        }

        //Load a specific student from the database students
        private Student getStudent(int index)
        {
            List<string> aStudent = dbc.get("Student", index);
            return new Student(Int32.Parse(aStudent[0]), aStudent[1],
                                aStudent[2], Int32.Parse(aStudent[3]));
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
                //TODO: Need to refactor to a much intuitive format. /
                ListViewItem studentItem = new ListViewItem(new[] {
                    aStudent.Id.ToString() + " " + aStudent.Name + " " +
                    aStudent.Program + " " + aStudent.StartYear.ToString()                });
                studentListView.Items.Add(studentItem);
            }
        }

        private void fillForm()
        {
            //TODO: Add student id on the form. Then, connect it after.
            studentIdBox.Text = student.Id.ToString();
            nameStudentFormMaskedBox.Text = student.Name;
            programStudentFormMaskedBox.Text = student.Program;
            startDateFormMaskedBox.Text = student.StartYear.ToString();

        }

        private void refreshForm()
        {
            studentIdBox.Text = "";
            nameStudentFormMaskedBox.Text = "";
            programStudentFormMaskedBox.Text = "";
            startDateFormMaskedBox.Text = "";

        }

        private void nameStudentFormMaskedBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }
    }
}
