using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUDTestProgram
{
    class DataConnector
    {
        private static string connectionString;
        public SqlConnection connection;
        private DataTable dt = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        public bool Verification(string uid, string pw, string tbl, string db, string server)
        {
            if (uid is null || pw is null || tbl is null || db is null || server is null)
                return false;

            // DB 에 연결
            connectionString = $"Data Source={server};" +
                            $"Initial Catalog={db};" +
                            $"User ID={uid};" +
                            $"Password={pw};";

            connection = new SqlConnection(connectionString);

            
            try
            {
                // DB 서버 접속
                connection.Open();

                SqlCommand cmd = new SqlCommand(string.Format(Query.existTable, db, tbl), connection);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows==false)
                {
                    rdr.Close();
                    MessageBox.Show("Error connecting to database: 테이블이 존재하지 않습니다.");
                    return false;
                }
                else
                {
                    rdr.Close();
                    MessageBox.Show("Connection successful.");
                    return true;

                }
                

            }
            catch (Exception ex) // DB 서버 접속 실패 시
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
                return false;
            }

        }

        public bool ExecuteQuery(string query) //try~catch 적용해
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection())
                {
                    sqlCon.ConnectionString = connectionString;
                    sqlCon.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlCon;

                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "경고", MessageBoxButtons.OK);
                return false;
            }
            
        }

        
    }
}