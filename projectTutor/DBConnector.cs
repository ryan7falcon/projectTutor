using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectTutor
{
    class DBConnector
    {
        SqlConnection con;

        public DBConnector()
        {
            con = new SqlConnection();

            con.ConnectionString = "Data Source=(localdb)\\Projects;Initial Catalog=FinalProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                                                                                                
        }
        
        public SqlConnection getConnection()
        {
            return con;
        }

        //get all records
        public List<List<string>> getList(string table)
        {
            List<List<string>> l = new List<List<string>>();

            try
            {
                con.Open();

                SqlCommand command = new SqlCommand();
                command.CommandText = "select * from [" + table + "];";
                command.Connection = con;
                SqlDataReader rd = command.ExecuteReader();

                while (rd.Read())
                {
                    List<string> arr = new List<string>();
                    for (int i = 0; i < rd.FieldCount; i++)
                    { 
                        arr.Add(rd[i].ToString());
                    }
                    l.Add(arr);
                }
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error in getting the list" + ex.Message);
            }

            return l;
        }

        //select
        public List<List<string>> getListWhere(string table, string[] pNames, string[] pValues)
        {
            List<List<string>> l = new List<List<string>>();

            try
            {
                con.Open();


                //constucts a string like tutorId=@1, tutorName=@2
                string setString = "";

                int lastIndex = pNames.Length - 1;              
                for (int i = 0; i < lastIndex; i++)
                {
                    setString += pNames[i] + "=@" + i + " AND ";
                }

                setString += pNames[lastIndex] + "=@" + lastIndex;

                SqlCommand command = new SqlCommand();
                command.CommandText = "select * from [" + table + "] where " + setString + ";";

                for (int i = 0; i < pValues.Length; i++)
                {
                    command.Parameters.AddWithValue("@" + i, pValues[i]);
                }
               
                command.Connection = con;
                SqlDataReader rd = command.ExecuteReader();

                while (rd.Read())
                {
                    List<string> arr = new List<string>();
                    for (int i = 0; i < rd.FieldCount; i++)
                    {
                        arr.Add(rd[i].ToString());
                    }
                    l.Add(arr);
                }
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error in getting the listWhere: " + ex.Message);
            }

            return l;
        }

        //get the first id in the database
        public int getFirstId(string table)
        {
            try
            {
                con.Open();

                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT TOP 1 * FROM [" + table + "] ORDER BY id ASC";

                command.Connection = con;
                SqlDataReader rd = command.ExecuteReader();

                int id = 0;
                if (rd.Read())
                {
                    id = Int32.Parse(rd[0].ToString());
                }

                con.Close();

                return id;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error in getting the first id" + ex.Message);
            }
            return 0;
        }

        //get the last id in the database
        public int getLastId(string table)
        {
            try
            {
                con.Open();

                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT TOP 1 * FROM [" + table + "] ORDER BY id DESC";

                command.Connection = con;
                SqlDataReader rd = command.ExecuteReader();

                int id = 0;
                if (rd.Read())
                {
                    id = Int32.Parse(rd[0].ToString());
                }

                con.Close();

                return id;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error in getting the last id" + ex.Message);
            }
            return 0;
        }

        //check if a record with a certain id exists in the database
        public bool checkIfExist(string table, int index)
        {
            try
            {
                con.Open();

                SqlCommand command = new SqlCommand();
                command.CommandText = "select * from [" + table + "] where id=@id";
                command.Parameters.AddWithValue("@id", index);
                command.Connection = con;
                SqlDataReader rd = command.ExecuteReader();
                if (rd.Read())
                {
                    con.Close();
                    return true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error in checking if exists: " + ex.Message);
            }
            con.Close();
            return false;

        }

        //gets a record from a database, returns a list of field values
        public List<string> get(string table, int index)
        {
            List<string> l = new List<string>();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "select * from [" + table + "] WHERE id=@id;";
                command.Parameters.AddWithValue("@id", index);
                command.Connection = con;
                SqlDataReader rd = command.ExecuteReader();
                if (rd.Read())
                {
                    for (int i = 0; i < rd.FieldCount; i++)
                    {
                        l.Add(rd[i].ToString());
                    }
                    con.Close();
                    return l;
                }
                else
                {
                    con.Close();
                    return null;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error in getting: " + ex.Message);
            }
            con.Close();
            return null;
        }

        //update a record in the database
        public int update(string table, Record r)
        {
            //get parameters (field values)
            string[] param = r.getParameters();
            //get parameter names (field names)
            string[] pnames = r.getParameterNames();

            //construct a string for the update statement
            //like tutorName=@1, tutorLevel=@2. Counter starts with 1 so that id is not included
            string setString = "";
            int lastIndex = pnames.Length - 1;
            for (int i = 1; i < lastIndex; i++)
            {
                setString += pnames[i] + "=@" + i + ", ";
            }

            setString += pnames[lastIndex] + "=@" + lastIndex;


            //perform update
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();

                command.CommandText = "UPDATE [" + table + "] SET " + setString + " WHERE id=@id;";
                command.Parameters.AddWithValue("@id", param[0]);
                for (int i = 1; i <= lastIndex; i++)
                {
                    command.Parameters.AddWithValue("@" + i, param[i]);
                }

                command.Connection = con;
                command.ExecuteNonQuery();
                con.Close();

                return 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error in updating: " + ex.Message);
                return -1;
            }

        }

        //insert a record in the database
        public int insert(string table, Record r)
        {
            //get parameters (field values)
            string[] param = r.getParameters();
            //get parameter names (field names)
            string[] pnames = r.getParameterNames();

            //construct a string for the insert statement
            string setString = "";
            int lastIndex = pnames.Length - 1;
            for (int i = 0; i < lastIndex; i++)
            {
                setString += "@" + i + ", ";
            }

            setString += "@" + lastIndex;


            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();

                command.CommandText = "insert into [" + table + "] values(" + setString + ");";
                for (int i = 0; i <= lastIndex; i++)
                {
                    command.Parameters.AddWithValue("@" + i, param[i]);
                }

                command.Connection = con;
                command.ExecuteNonQuery();
                con.Close();

                return 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error in adding a poop record: " + ex.Message);
                return -1;
            }
        }

        //delete a record from the database
        public int delete(string table, int index)
        {
            try
            {
                con.Open();

                SqlCommand command = new SqlCommand();
                command.CommandText = "delete from [" + table + "] where id=@id;";
                command.Parameters.AddWithValue("@id", index);
                command.Connection = con;
                command.ExecuteNonQuery();
                con.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error in deleting: " + ex.Message);
                return -1;
            }
        }

    }
}
