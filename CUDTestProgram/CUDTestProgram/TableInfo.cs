using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUDTestProgram
{
    public partial class TableInfo : Form
    {
        private SqlConnection connection;
        private DataTable dt = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        private DataConnector dc = new DataConnector();
        string tableName = string.Empty;
        string DBname = string.Empty;
        public TableInfo()
        {
            
        }

        public TableInfo(SqlConnection connection, string tblnm, string DBnm)
        {
            this.connection = connection;
            InitializeComponent();
            adapter = new SqlDataAdapter(string.Format(Query.selectAll, DBnm, tblnm), connection);
            adapter.Fill(dt);
            tableName = tblnm;
            DBname = DBnm;
            dt.Columns[0].ReadOnly = true;
            
            ultraGrid1.DataSource = new BindingSource(dt, string.Empty);
            ultraGrid1.DisplayLayout.GroupByBox.Hidden = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            DataRow row = dt.NewRow();  //만들어서
            row["상태"] = "C";
            dt.Rows.InsertAt(row, 0);   //넣어줘야함
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.ultraGrid1.ActiveRow == null)
            {
                MessageBox.Show("선택된 행이 존재하지 않습니다.", "경고", MessageBoxButtons.OK);
                return;
            }
            dt.Columns[0].ReadOnly = false;
            this.ultraGrid1.ActiveRow.Cells[0].Value = "D";
            dt.Columns[0].ReadOnly = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var i = MessageBox.Show("다시 로드하시겠습니까?","경고",MessageBoxButtons.OKCancel);
            if (i.Equals( DialogResult.OK))
            {
                dt.Clear();
                adapter = new SqlDataAdapter(string.Format(Query.selectAll, DBname, tableName), connection);
                adapter.Fill(dt);
            }
            else
            {
                return;
            }
           
        }
        private string insertRow(DataRow row,DataSet ds)
        {
            string[] insertStatement = new string[row.ItemArray.Length-1];

            for(int i = 1; i < row.ItemArray.Length ; i++)
            {
                if (row.ItemArray[i].GetType().Name.Equals("DateTime"))
                {
                    insertStatement[i-1] += "'" + DateTime.ParseExact(row.ItemArray[i].ToString(), "yyyy-MM-dd tt hh:mm:ss", null, System.Globalization.DateTimeStyles.AssumeLocal).ToString("yyyy-MM-dd HH:mm:ss") + "'";
                }
                else
                {
                    insertStatement[i-1] += "'" + row.ItemArray[i] + "'";
                }

            }
            
            return String.Join(",", insertStatement);
        }

        private string[] updateRow(DataRow row, DataSet ds)
        {
            DataSet pkDS = new DataSet();
            adapter = new SqlDataAdapter(string.Format(Query.selectPK, tableName), this.connection);
            adapter.Fill(pkDS);
            string[] updateStatement = new string[row.ItemArray.Length-1];
            string[] updateWhere = new string[pkDS.Tables[0].Rows.Count] ;

            for (int i=1; i < row.ItemArray.Length ; i++)
            {   
            
                    if (row.ItemArray[i].GetType().Name.Equals("DateTime"))
                    {
                        updateStatement[i-1] += ds.Tables[0].Rows[i-1]["column_name"] + " = '" + DateTime.ParseExact(row.ItemArray[i].ToString(), "yyyy-MM-dd tt hh:mm:ss", null, System.Globalization.DateTimeStyles.AssumeLocal).ToString("yyyy-MM-dd HH:mm:ss") + "'";
                    }
                    else
                    {
                        updateStatement[i-1] += ds.Tables[0].Rows[i-1]["column_name"] + " = '" + row.ItemArray[i] + "'";
                    }
                
            }
           
            for (int i =0; i < pkDS.Tables[0].Rows.Count; i++)
            {
                foreach (var column in row.Table.Columns.Cast<DataColumn>())
                {
                    if(column.ToString().Equals(pkDS.Tables[0].Rows[i]["column_name"]))
                    {
                        if (pkDS.Tables[0].Rows[i]["column_name"].GetType().Name.Equals("DateTime"))
                        {
                            updateWhere[i] += pkDS.Tables[0].Rows[i]["column_name"] + " = '" + DateTime.ParseExact(row[column.ColumnName].ToString(), "yyyy-MM-dd tt hh:mm:ss", null, System.Globalization.DateTimeStyles.AssumeLocal).ToString("yyyy-MM-dd HH:mm:ss") + "'";
                        }
                        else
                        {
                            updateWhere[i] += pkDS.Tables[0].Rows[i]["column_name"] + " = '" + row[column.ColumnName] + "'";
                        }
                    }
                   
                }

            }
            return new string [2]{ String.Join(" , ", updateStatement), String.Join(" and ", updateWhere) };
        }

        private string deleteRow(DataRow row, DataSet ds)
        { 
            DataSet pkDS = new DataSet();
            adapter = new SqlDataAdapter(string.Format(Query.selectPK, tableName), this.connection);
            adapter.Fill(pkDS);

            string[] deleteWhere = new string[pkDS.Tables[0].Rows.Count];

            for (int i = 0; i < pkDS.Tables[0].Rows.Count; i++)
            {
                foreach (var column in row.Table.Columns.Cast<DataColumn>())
                {
                    if (column.ToString().Equals(pkDS.Tables[0].Rows[i]["column_name"]))
                    {
                        if (pkDS.Tables[0].Rows[i]["column_name"].GetType().Name.Equals("DateTime"))
                        {
                            deleteWhere[i] += pkDS.Tables[0].Rows[i]["column_name"] + " = '" + DateTime.ParseExact(row[column.ColumnName].ToString(), "yyyy-MM-dd tt hh:mm:ss", null, System.Globalization.DateTimeStyles.AssumeLocal).ToString("yyyy-MM-dd HH:mm:ss") + "' ";
                        }
                        else
                        {
                            deleteWhere[i] += pkDS.Tables[0].Rows[i]["column_name"] + " = '" + row[column.ColumnName] + "'  ";
                        }
                    }
                }
            }
            return String.Join(" and ", deleteWhere);
        }

        private void before_btnSave_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            adapter = new SqlDataAdapter(string.Format(Query.selectPK, tableName), this.connection);
            adapter.Fill(ds);
            string[] PKList = new string[dt.Rows.Count];
            object[] PKquery = new string[dt.Rows.Count];
            try
            {
                List<string> pkList= new List<string>();
                for (int index = 0; index < ds.Tables[0].Rows.Count; index++)
                {
                    pkList.Add(ds.Tables[0].Rows[index]["COLUMN_NAME"].ToString());
                }

               

                foreach (var pk in pkList)  //dt의 pk
                {
                    var sameCount = 0;
                    int i = 0;
                    
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = string.Format(Query.selectPKList, string.Join(" ,", pkList), tableName);

                        // SqlDataReader 객체를 리턴
                        SqlDataReader rdr = cmd.ExecuteReader();

                        // 다음 레코드 계속 가져와서 루핑
                        while (rdr.Read())
                        {
                             PKquery[i] = rdr[pk]; //드럽고 치사해서 더 안한다
                            i++;
                        }
                        // 사용후 닫음
                        rdr.Close();


                    foreach (var dpk in PKquery)//db의 pk
                    {
                        if (dpk.Equals(dt.Columns[pk].ToString()))
                        {
                            sameCount++;
                        }
                        if (pk.Equals(ultraGrid1.DisplayLayout.Bands[0].Columns[pk].ValueList.GetValue(0).ToString()))
                        {
                            ultraGrid1.DisplayLayout.Bands[0].Columns[pk].CellActivation = Activation.Disabled;
                        }
                    }
                    if (sameCount > 1)
                    {
                        MessageBox.Show("PK가 중복 됩니다.", "알림", MessageBoxButtons.OK);
                        return;
                    }
                }
                
                btnSave_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "경고", MessageBoxButtons.OK);
            }
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            adapter = new SqlDataAdapter(string.Format(Query.selectTableInfo, tableName), this.connection);
            adapter.Fill(ds);

            var query1 = new string[] { };
            var query2 = new string[] { };
            var query3 = new string[] { };

            var query = string.Empty;

            try
            {
                List<string> cud_char = new List<string>();
                for (int index = 0; index < dt.Rows.Count; index++)
                {
                    cud_char.Add(dt.Rows[index]["상태"].ToString());
                }
                if (!cud_char.Contains("C") && !cud_char.Contains("U") && !cud_char.Contains("D"))
                {
                    MessageBox.Show("변경된 데이터가 없습니다.", "알림", MessageBoxButtons.OK);
                    return;
                }


                foreach (DataRow row in dt.AsEnumerable())
                {

                    if (row.Field<string>("상태").ToString().Equals("C"))
                    {
                        query1 = (from insertrow in dt.AsEnumerable()
                                  where insertrow.Field<string>("상태").Equals("C")
                                  select string.Format(Query.insert, tableName, insertRow(row, ds))
                         ).ToArray();

                    }
                    else if (row.Field<string>("상태").ToString().Equals("U"))
                    {
                        query2 = (from updaterow in dt.AsEnumerable()
                                  where updaterow.Field<string>("상태").Equals("U")
                                  select string.Format(Query.udpate, tableName, updateRow(row, ds)[0], updateRow(row, ds)[1])
                                 ).ToArray();

                    }
                    else if (row.Field<string>("상태").ToString().Equals("D"))
                    {
                        query3 = (from deleterow in dt.AsEnumerable()
                                  where deleterow.Field<string>("상태").Equals("D")
                                  select string.Format(Query.delete, tableName, deleteRow(row, ds))
                                ).ToArray();
                    }

                }
                query += string.Format(Query.saveQuery, string.Join(Environment.NewLine, query1),
                     string.Join(Environment.NewLine, query2),
               string.Join(Environment.NewLine, query3));
                dc.ExecuteQuery(query);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "경고", MessageBoxButtons.OK);
            }
            finally
            {
                dt.Clear();
                adapter = new SqlDataAdapter(string.Format(Query.selectAll, DBname, tableName), connection);
                adapter.Fill(dt);
                this.ultraGrid1.ActiveRow = null;
            }
            
        }

        private void ultraGrid1_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            
        }

        private void ultraGrid1_AfterCellUpdate(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            dt.Columns[0].ReadOnly = false;
            if (!((ultraGrid1.ActiveRow.Cells[0].Value.ToString() == "D")||(ultraGrid1.ActiveRow.Cells[0].Value.ToString() == "C")))
            {
                this.ultraGrid1.ActiveRow.Cells[0].Value = "U";
            }
            dt.Columns[0].ReadOnly = true;
            this.ultraGrid1.ActiveRow = null;
        }

        private void ultraGrid1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menuStrip = new ContextMenuStrip();

                ToolStripMenuItem addItem = new ToolStripMenuItem("추가");
                ToolStripMenuItem deleteItem = new ToolStripMenuItem("삭제");
                ToolStripMenuItem resetItem = new ToolStripMenuItem("초기화");
                ToolStripMenuItem saveItem = new ToolStripMenuItem("저장");
                menuStrip.Items.AddRange(new ToolStripItem[]
        {
                addItem,
                deleteItem,
                resetItem,
                saveItem
        });


                addItem.Click += btnAdd_Click;
                deleteItem.Click += btnRemove_Click;
                resetItem.Click += btnReset_Click;
                saveItem.Click += before_btnSave_Click;

                menuStrip.Show(ultraGrid1, new Point(e.X, e.Y));
            }
        }
    }
}
