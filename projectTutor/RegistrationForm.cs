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
    public partial class RegistrationForm : Form
    {
        DBConnector dbc;

        public RegistrationForm()
        {
            InitializeComponent();
            DBConnector dbc = new DBConnector();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
           SqlConnection con = dbc.getConnection();


        }
    }
}
