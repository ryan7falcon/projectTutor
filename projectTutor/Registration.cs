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
    public partial class Registration : Form
    {
        DBConnector dbc;

        public Registration()
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
