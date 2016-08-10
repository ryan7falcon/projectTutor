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
            //intializes the componets
            InitializeComponent();
            //attachs the validating event to the subjects and tutorname textbox
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
        // on the loading of the new form fills the ds tables with values form the db
        private void Tutor_Load(object sender, EventArgs e)
        {
            //creates a new connection and sets the data set to a new data set
            DBConnector dbc = new DBConnector();
            ds = new DataSet();
            SqlConnection con = dbc.getConnection();
            using (con)
            {
                //using the dataadpater fills the two tables of the ds from the db
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tutor", con);
                da.Fill(ds, "Tutor");
                da = new SqlDataAdapter("SELECT * FROM Availability", con);
                da.Fill(ds, "Availability");

            }
            //sets the maxium value of the tutor id related number pickers based off the records in the tutor table
            TutorID.Maximum = ds.Tables["Tutor"].Rows.Count + 1;
            AvailTutorID.Maximum = ds.Tables["Tutor"].Rows.Count;
            loadListView();


        }

        //Validates the tutorname textbox to ensure only spaces  and alpha characters 
        private void TutorName_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            //regex only accepts alpha characters
            string regex = "^[a-zA-Z_ ]*$";
            Match match = Regex.Match(TutorName.Text, regex, RegexOptions.IgnoreCase);
            // if the match is not a succes then set set error message
            if (!match.Success)
            {
                errorMsg = "Contains illegal character  only alphacharecter";
                TutorName.Select(0, TutorName.Text.Length);
                this.errorProvider1.SetError(TutorName, errorMsg);
                e.Cancel = true;
            }
            // if it is a succes then clear the error message
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
            //check to see if the match is a succes if not sets error message
            if (!match.Success)
            {
                errorMsg = "Contains illegal character only use numerics and alphacharecter";
                Subjects.Select(0, Subjects.Text.Length);
                this.errorProvider2.SetError(Subjects, errorMsg);
                e.Cancel = true;
            }
            //removes the error provider
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
            // takes the value from the list view and sets the values and text elements of the other form control
            TutorID.Value = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
            TutorName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            Subjects.Text = listView1.SelectedItems[0].SubItems[2].Text;
            level.Value = Convert.ToInt32(listView1.SelectedItems[0].SubItems[3].Text);
            rate.Text = listView1.SelectedItems[0].SubItems[4].Text;
            listView2.Items.Clear();
            // if tutor has any availbitiies sets and the second listview to display only those records
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
                //creates a new connection
                DBConnector dbc = new DBConnector();
                SqlConnection con = dbc.getConnection();
                //checks to which row is selected byt he form control
                DataRow[] selectedrow = ds.Tables["Tutor"].Select("Id = '" + TutorID.Value.ToString() + "'");

                //if thr the row exists then it updates that row
                if (selectedrow.Length == 1)

                {
                    if (TutorName.Text != null && Subjects.Text != null && rate.MaskCompleted)
                    {
                        selectedrow[0]["Id"] = TutorID.Value.ToString();
                        selectedrow[0]["name"] = TutorName.Text;
                        selectedrow[0]["subjects"] = Subjects.Text;
                        selectedrow[0]["level"] = level.Value.ToString();
                        selectedrow[0]["hourlyRate"] = Convert.ToDecimal(rate.Text);
                    }
                }
                // if the row doesnt exist insert the row into  the new table
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

                //check to see an id has been given
                if (AvailID.Value >= 1)
                {
                    DataRow[] selectedAvilrow = ds.Tables["Availability"].Select("Id = '" + AvailID.Text + "'");
                    //if the row exists then updates that row
                    if (selectedAvilrow.Length == 1)
                    {
                        if (Time.MaskCompleted)
                        {
                            selectedAvilrow[0]["Id"] = AvailID.Value;
                            selectedAvilrow[0]["Day"] = Day.Value.ToString();
                            selectedAvilrow[0]["Time"] = Time.Text;
                            selectedAvilrow[0]["TutorId"] = AvailTutorID.Value.ToString();
                        }
                    }
                    else
                    {
                        // if the row doesnt exist inserts into the da
                        if (Time.MaskCompleted)
                        {
                            DataRow toInsert = ds.Tables["Availability"].NewRow();
                            toInsert["Id"] = AvailID.Value;
                            toInsert["Day"] = Day.Value.ToString();
                            toInsert["Time"] = Time.Text;
                            toInsert["TutorId"] = AvailTutorID.Value.ToString();
                            ds.Tables["Availability"].Rows.Add(toInsert);

                        }
                    }
                }
                //after the insertion connects and sends changes to the db
                using (con)
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tutor", con);
                    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);
                    da.Update(ds, "Tutor");
                    da = new SqlDataAdapter("SELECT * FROM Availability", con);
                    cmdBuilder = new SqlCommandBuilder(da);
                    da.Update(ds, "Availability");


                }
                //load the list views with updates tables
                loadListView();
                //cahnges max tutor id if the changes are required
                TutorID.Maximum = ds.Tables["Tutor"].Rows.Count + 1;
                AvailTutorID.Maximum = ds.Tables["Tutor"].Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        // using the ds loads the the listview with values
        public void loadListView()
        {
            //clears the list view
            listView1.Items.Clear();
            listView2.Items.Clear();
            //loops all the rows and add them to tutor listview
            foreach (DataRow row in ds.Tables["Tutor"].Rows)
            {
                ListViewItem item = new ListViewItem(row["Id"].ToString());
                item.SubItems.Add(row["name"].ToString());
                item.SubItems.Add(row["subjects"].ToString());
                item.SubItems.Add(row["level"].ToString());
                item.SubItems.Add(row["hourlyRate"].ToString());
                listView1.Items.Add(item);
            }
            //loops all the rows and add them to avial list view
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
            //sets the tutorid value to the max
            TutorID.Value = TutorID.Maximum;
        }

        private void listView1_Leave(object sender, EventArgs e)
        {

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            listView2.Items.Clear();
            if (listView1.SelectedIndices.Count == 0)
            {
                foreach (DataRow row in ds.Tables["Availability"].Rows)
                {
                    ListViewItem item = new ListViewItem(row["Id"].ToString());
                    item.SubItems.Add(row["Day"].ToString());
                    item.SubItems.Add(row["Time"].ToString());
                    item.SubItems.Add(row["TutorId"].ToString());
                    listView2.Items.Add(item);
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                //creates a new connection
                DBConnector dbc = new DBConnector();
                SqlConnection con = dbc.getConnection();
                DataRow[] selectedrow = ds.Tables["Tutor"].Select("Id = '" + TutorID.Value.ToString() + "'");
                if (selectedrow.Length==1) {

                    int index = ds.Tables["Tutor"].Rows.IndexOf(selectedrow[0]);
                    if (dbc.checkIfExist("Availability", "TutorId",Convert.ToInt32(selectedrow[0]["Id"].ToString())))
                    {
                        MessageBox.Show("Unable to delete row due to refernital inregity");
                    }
                    else {
                        ds.Tables["Tutor"].Rows[index].Delete();
                    }
                }                       
                   
                        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tutor", con);
                        SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);
                        da.Update(ds, "Tutor");
                                               
                    
                    //load the list views with updates tables
                    loadListView();
                    //cahnges max tutor id if the changes are required
                    TutorID.Maximum = ds.Tables["Tutor"].Rows.Count + 1;
                    AvailTutorID.Maximum = ds.Tables["Tutor"].Rows.Count;                
            }
            catch (SqlException sqle)
            {
                MessageBox.Show(sqle.Message);

            }
        }

        private void DeleteAvail_Click(object sender, EventArgs e)
        {
            try
            {
                //creates a new connection
                DBConnector dbc = new DBConnector();
                SqlConnection con = dbc.getConnection();
                DataRow[] selectedAvilrow;
                int avialindex;
                

                if (AvailID.Value >= 1)
                {
                    selectedAvilrow = ds.Tables["Availability"].Select("Id = '" + AvailID.Text + "'");
                    if (selectedAvilrow.Length == 1)
                    {
                        avialindex = ds.Tables["Availability"].Rows.IndexOf(selectedAvilrow[0]);
                        ds.Tables["Availability"].Rows[avialindex].Delete();
                    }
                }
                using (con)
                {

                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Availability", con);
                    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);
                    da.Update(ds, "Availability");

                }

                //load the list views with updates tables
                loadListView();


            }
            catch (SqlException sqle)
            {
                MessageBox.Show(sqle.Message);

            }
        }
    }
}
