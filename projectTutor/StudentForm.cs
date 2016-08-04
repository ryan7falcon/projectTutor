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
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
        private void saveStudenFormButton_Click(object sender, EventArgs e)
        {
            //Get name
            //Get program
            //Get startdate
            String studentName = nameStudentFormMaskedBox.Text;
            String studentProgram = programStudentFormMaskedBox.Text;
            String startDate = startDateFormMaskedBox.Text;
       




            /*Establish a connection from dbo.Student table
            string connectionString = "Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\javel\Documents\dataContainers.mdf; Integrated Security = True; Connect Timeout = 30";
           
            //Establish data adapter (data source, disconnected data source)
            SqlConnection connection = new SqlConnection(connectionString);

            //Create a DataSet
            DataSet data = new DataSet();

            //Pass the data from the customer table to the dataset
            SqlDataAdapter studentDataAdapter = new SqlDataAdapter("SELECT * FROM Student", connection);
            studentDataAdapter.Fill(data, "Student");
            */

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
