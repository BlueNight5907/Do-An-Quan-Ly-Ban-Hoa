using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
namespace QuanLyBanHoa.DAO
{

    public class DataProvider
    {
        static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) 
                    instance = new DataProvider();
                return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        public DataProvider() { }
        private String connectionString = @"Data Source=localhost;Initial Catalog=QuanLyBanHoa;Integrated Security=True";
        // cac ham query phu hop voi tung dieu kien



        //Truy van su dung cau lenh co tra ve bang gia tri
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }
        //Truy van tra ve so dong cua bang
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }
        //Truy van tra ve mot gia tri cu the
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }


        //Doc du lieu connection string tu file
        private string readConnectionString()
        {
            StreamReader fr = new StreamReader("Config.txt");

            String s = fr.ReadLine();

            String server, db, uid, pw;

            server = fr.ReadLine();

            db = fr.ReadLine();

            if (s.Equals("sql"))
            {
                uid = fr.ReadLine();

                pw = fr.ReadLine();

                string sql_conn = "server = " + server + ", database = " + db + ", uid =" + uid + ", pwd = " + pw;

                return sql_conn;
            }
            else
            {
                return "Data Source =" + server + ";Initial Catalog=" + db + ";Integrated Security=True";
            }
        }

    }
}
