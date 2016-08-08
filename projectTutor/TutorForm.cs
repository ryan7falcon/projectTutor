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
using System.Globalization;


namespace projectTutor
{
    public partial class TutorForm : Form
    {
        DataSet ds;
        public TutorForm()
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
        // on the loading of the nwe form fills the ds tables with values form the db
        private void Tutor_Load(object sender, EventArgs e)
        {
            DBConnector dbc = new DBConnector();
            ds = new DataSet();
            SqlConnection con = dbc.getConnection();
            using (con)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tutor", con);
                da.Fill(ds, "Tutor");
                da = new SqlDataAdapter("SELECT * FROM Availability", con);
                da.Fill(ds, "Availability");

            }
            TutorID.Maximum = ds.Tables["Tutor"].Rows.Count + 1;
            AvailTutorID.Maximum = ds.Tables["Tutor"].Rows.Count;
            loadListView();


        }

        //Validates the tutorname textbox to ensure only spaces  and alpha characters 
        private void TutorName_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            string regex = "^[a-zA-Z_ ]*$";
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
        //populates the form control related to the list view item
        private void listView1_Click(object sender, EventArgs e)
        {

            TutorID.Value = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
            TutorName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            Subjects.Text = listView1.SelectedItems[0].SubItems[2].Text;
            level.Value = Convert.ToInt32(listView1.SelectedItems[0].SubItems[3].Text);
            rate.Text = listView1.SelectedItems[0].SubItems[4].Text;
            listView2.Items.Clear();
            foreach (DataRow row in ds.Tables["Availability"].Select("TutorId=" + listView1.SelectedItems[0].SubItems[0].Text))
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
        //populates the form control related to the list view item
        private void listView2_Click(object sender, EventArgs e)
        {
            AvailID.Text = listView2.SelectedItems[0].SubItems[0].Text;
            Day.Value = Convert.ToInt32(listView2.SelectedItems[0].SubItems[1].Text);
            Time.Text = listView2.SelectedItems[0].SubItems[2].Text;
            AvailTutorID.Value = Convert.ToInt32(listView2.SelectedItems[0].SubItems[3].Text);
        }
        //save checks to see if the an update has happened or a new record insert and updates the database
        private void Save_Click(object sender, EventArgs e)
        {

            try
            {
                DBConnector dbc = new DBConnector();
                SqlConnection con = dbc.getConnection();
                DataRow[] selectedrow = ds.Tables["Tutor"].Select("Id = '" + TutorID.Value.ToString() + "'");

                if (selectedrow.Length == 1)

                {
                    if (TutorName.Text!=null &&Subjects.Text!=null && rate.MaskCompleted ) {
                        selectedrow[0]["Id"] = TutorID.Value.ToString();
                        selectedrow[0]["name"] = TutorName.Text;
                        selectedrow[0]["subjects"] = Subjects.Text;
                        selectedrow[0]["level"] = level.Value.ToString();
                        selectedrow[0]["hourlyRate"] = Convert.ToDecimal(rate.Text);
                    }
                }
                else
                {
                    if (TutorName.Text != null && Subjects.Text != null && rate.MaskCompleted)
                    {
                        DataRow toInsert = ds.Tables["Tutor"].NewRow();
                        toInsert["Id"] = TutorID.Value.ToString();
                        toInsert["name"] = TutorName.Text;
                        toInsert["subjects"] = Subjects.Text;
                        toInsert["level"] = level.Value.ToString();
                        toInsert["hourlyRate"] = Convert.ToDecimal(rate.Text);
                        ds.Tables["Tutor"].Rows.Add(toInsert);
                    }
                }


                if (AvailID.MaskCompleted) {
                    DataRow[] selectedAvilrow = ds.Tables["Availability"].Select("Id = '" + AvailID.Text + "'");

                    if (selectedAvilrow.Length == 1)
                    {
                        if (Time.MaskCompleted) {
                            selectedAvilrow[0]["Id"] = AvailID.Text;
                            selectedAvilrow[0]["Day"] = Day.Value.ToString();
                            selectedAvilrow[0]["Time"] = Time.Text;
                            selectedAvilrow[0]["TutorId"] = AvailTutorID.Value.ToString();
                        }
                    }
                    else
                    {
                        if (Time.MaskCompleted) {
                            DataRow toInsert = ds.Tables["Availability"].NewRow();
                            toInsert["Id"] = AvailID.Text;
                            toInsert["Day"] = Day.Value.ToString();
                            toInsert["Time"] = Time.Text;
                            toInsert["TutorId"] = AvailTutorID.Value.ToString();
                            ds.Tables["Availability"].Rows.Add(toInsert);
                            
                        }
                    }
                }
               
                using (con) {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tutor", con);
                    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);
                    da.Update(ds, "Tutor");
                    da = new SqlDataAdapter("SELECT * FROM Availability", con);
                    cmdBuilder = new SqlCommandBuilder(da);
                    da.Update(ds, "Availability");


                }
                    loadListView();
                TutorID.Maximum = ds.Tables["Tutor"].Rows.Count + 1;
                AvailTutorID.Maximum = ds.Tables["Tutor"].Rows.Count;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }


        }

        // using the ds loads the the listview with values
        public void loadListView() {
            listView1.Items.Clear();
            listView2.Items.Clear();
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

        private void UniqueID_Click(object sender, EventArgs e)
        {
            TutorID.Value = TutorID.Maximum;
        }
    }
}
