using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeTest
{
    class DataConnector
    {


        private static string connectionString = $"Data Source=10.10.0.216;" +
                        $"Initial Catalog=UNIERP60N;" +
                        $"User ID=sa;" +
                        $"Password=unierp@2011;";
        public DataTable dt = new DataTable();
        public DataTable ConnectionOpen()
        {
            
            try
            {
                dt.Columns.Add("UPPER_MNU_ID", typeof(string));
                dt.Columns.Add("UPPER_MNU_TYPE", typeof(string));
                dt.Columns.Add("MNU_ID", typeof(string));
                dt.Columns.Add("MNU_TYPE", typeof(string));
                dt.Columns.Add("DEPTH", typeof(string));
                dt.Columns.Add("MNU_SEQ", typeof(string));
                dt.Columns.Add("MNU_NM", typeof(string));

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @" WITH TREE AS 
   ( SELECT
       [UPPER_MNU_ID], [UPPER_MNU_TYPE],[MNU_ID], [MNU_TYPE], 1 AS [DEPTH]

    FROM [dbo].[Z_CO_MAST_MNU]

    WHERE [UPPER_MNU_ID] = N'*'

        AND [MNU_ID] != N'*'

    UNION ALL

    SELECT

        A.[UPPER_MNU_ID], A.[UPPER_MNU_TYPE],A.[MNU_ID], A.[MNU_TYPE], B.[DEPTH] + 1 AS [DEPTH]

    FROM [dbo].[Z_CO_MAST_MNU] AS A

        INNER JOIN TREE AS B
            ON A.[UPPER_MNU_ID] = B.[MNU_ID]
)
SELECT A.*,B.MNU_SEQ, C.MNU_NM
FROM TREE AS A
	LEFT JOIN [dbo].[Z_CO_MNU] AS B
		ON A.[MNU_ID] = B.[MNU_ID]
		AND A.[UPPER_MNU_ID] = B.[UPPER_MNU_ID]
	LEFT JOIN [dbo].[Z_LANG_CO_MAST_MNU] AS C
		ON A.[MNU_ID]=C.[MNU_ID] AND B.[MNU_ID]=C.[MNU_ID]
WHERE C.LANG_CD='KO'
ORDER BY A.UPPER_MNU_ID, A.MNU_ID, B.[MNU_SEQ];";

                    // SqlDataReader 객체를 리턴
                    SqlDataReader rdr = cmd.ExecuteReader();

                    // 다음 레코드 계속 가져와서 루핑
                    while (rdr.Read())
                    {
                        string u_id = rdr["UPPER_MNU_ID"] as string;
                        string u_type = rdr["UPPER_MNU_TYPE"] as string;
                        string id = rdr["MNU_ID"] as string;
                        string type = rdr["MNU_TYPE"] as string;
                        string dep = rdr["DEPTH"].ToString();
                        string seq = rdr["MNU_SEQ"] as string;
                        string nm = rdr["MNU_NM"] as string;

                        DataRow dr = dt.NewRow();
                        dr["UPPER_MNU_ID"] = u_id;
                        dr["UPPER_MNU_TYPE"] = u_type;
                        dr["MNU_ID"] = id;
                        dr["MNU_TYPE"] = type;
                        dr["DEPTH"] = dep;
                        dr["MNU_SEQ"] = seq;
                        dr["MNU_NM"] = nm;

                        dt.Rows.Add(dr);
                    }
                    // 사용후 닫음
                    rdr.Close();

                }
                return dt;
            }
            catch (Exception ex) // DB 서버 접속 실패 시
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
                return dt;
            }
        }
    }
    
}
