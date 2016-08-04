using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace projectTutor
{
    public partial class Tutor : Form
    {

        DataSet ds;
        public Tutor()
        {
            InitializeComponent();
            TutorName.Validating += TutorName_Validating;
            Subjects.Validating += Subjects_Validating;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tutor_Load(object sender, EventArgs e)
        {
            DBConnector dbc = new DBConnector();
            ds = new DataSet();
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\Projects;Initial Catalog=FinalProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            using (con)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tutor", con);
                da.Fill(ds,"Tutor");
                da = new SqlDataAdapter("SELECT * FROM Availability", con);
                da.Fill(ds, "Availability");
                
            }
            DataTable tutorT = ds.Tables["Tutor"];
            foreach (DataRow row in ds.Tables["Tutor"].Rows) 
            {
                ListViewItem item = new ListViewItem(row["Id"].ToString());
                item.SubItems.Add(row["name"].ToString());
                item.SubItems.Add(row["subjects"].ToString());
                item.SubItems.Add(row["level"].ToString());
                item.SubItems.Add(row["hourlyRate"].ToString());
                listView1.Items.Add(item);
            }
            foreach (DataRow row in ds.Tables["Availability"].Rows)
            {
                ListViewItem item = new ListViewItem(row["Id"].ToString());
                item.SubItems.Add(row["Day"].ToString());
                item.SubItems.Add(row["Time"].ToString());
                item.SubItems.Add(row["TutorId"].ToString());
                listView2.Items.Add(item);
            }

        }

        private void TutorName_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            string regex = "^[a-zA-Z0-9_ ]*$";
            Match match = Regex.Match(TutorName.Text, regex, RegexOptions.IgnoreCase);
            if (!match.Success)
            {
                errorMsg = "Contains illegal character only use numerics and alphacharecter";
                TutorName.Select(0, TutorName.Text.Length);
                this.errorProvider1.SetError(TutorName, errorMsg);
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.Clear();
                e.Cancel = false;
            }
        }

        private void Subjects_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            string regex = "^[a-zA-Z0-9_, ]*$";
            Match match = Regex.Match(Subjects.Text, regex, RegexOptions.IgnoreCase);
            if (!match.Success)
            {
                errorMsg = "Contains illegal character only use numerics and alphacharecter";
                Subjects.Select(0, Subjects.Text.Length);
                this.errorProvider2.SetError(Subjects, errorMsg);
                e.Cancel = true;
            }
            else
            {
                this.errorProvider2.Clear();
                e.Cancel = false;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
                
            

        }

        private void listView1_Click(object sender, EventArgs e)
        {
   
            TutorID.Value = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
            TutorName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            Subjects.Text = listView1.SelectedItems[0].SubItems[2].Text;
            level.Value = Convert.ToInt32(listView1.SelectedItems[0].SubItems[3].Text);
            rate.Text = listView1.SelectedItems[0].SubItems[4].Text;
            listView2.Items.Clear();
            foreach (DataRow row in ds.Tables["Availability"].Select("TutorId="+ listView1.SelectedItems[0].SubItems[0].Text))
            {
                ListViewItem item = new ListViewItem(row["Id"].ToString());
                item.SubItems.Add(row["Day"].ToString());
                item.SubItems.Add(row["Time"].ToString());
                item.SubItems.Add(row["TutorId"].ToString());
                listView2.Items.Add(item);
            }

        }

        private void AvailIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void listView2_Click(object sender, EventArgs e)
        {
            AvailID.Text= listView2.SelectedItems[0].SubItems[0].Text;
            Day.Value= Convert.ToInt32(listView2.SelectedItems[0].SubItems[1].Text);
            Time.Text= listView2.SelectedItems[0].SubItems[2].Text;
            AvailTutorID.Value= Convert.ToInt32(listView2.SelectedItems[0].SubItems[3].Text);
        }

        private void Save_Click(object sender, EventArgs e)
        {

        }
    }
   
}
