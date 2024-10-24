
using Infragistics.Win.UltraWinTree;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TreeTest
{
    public partial class Form1 : Form
    {
		private DataConnector dc = new DataConnector();
		private DataTable dt = new DataTable();

		public Form1()
        {
            InitializeComponent();
			dt = dc.ConnectionOpen();
			RecurseRows();
		}


		//findNode(dt.Rows[0], new Dictionary<string, UltraTreeNode>());
		private void RecurseRows()
        {
			ultraGrid1.Update();
			for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["DEPTH"].ToString().Equals("1"))
                {
					findNode(dt.Rows[i], new Dictionary<string, UltraTreeNode>());
				}
            }
		}

        private void findNode(DataRow row, Dictionary<string, UltraTreeNode> dictionary)
        {
			if (dictionary == null)
			{
				dictionary = new Dictionary<string, UltraTreeNode>();
			}

			var newNode = new UltraTreeNode(row["MNU_ID"].ToString() );
			

			if (dictionary.ContainsKey(row["UPPER_MNU_ID"].ToString()))
			{
				dictionary[row["UPPER_MNU_ID"].ToString()].Nodes.Add(newNode);
			}
			else
			{
				ultraTree1.Nodes.Add(newNode);
			} // 부모노드 찾기

			dictionary.Add(row["MNU_ID"].ToString(), newNode);

			DataRow[] children = (
				from e in row.Table.AsEnumerable()
				where e["UPPER_MNU_ID"].ToString() == row["MNU_ID"].ToString()
		select e).ToArray();

			foreach (var child in children)//없으면 끝나게됨
			{
				findNode(child, dictionary);
			}
		}

        private void ultraTree1_AfterSelect(object sender, SelectEventArgs e)
        {
            try {
				DataRow SelectionRow = dt.Rows[0];
				SelectionRow = dt.Select("MNU_ID = '" + e.NewSelections.GetItem(0) as string + "'").CopyToDataTable().Rows[0];

				txt_mnu_id.Text = e.NewSelections.GetItem(0).ToString();
				txt_mnu_nm.Text = SelectionRow["MNU_NM"].ToString();    
				txt_mnu_seq.Text = SelectionRow["MNU_SEQ"].ToString();
				txt_mnu_type.Text = SelectionRow["MNU_TYPE"].ToString();


				var table = dt.Select("UPPER_MNU_ID = '" + e.NewSelections.GetItem(0) as string + "' OR MNU_ID = '" + e.NewSelections.GetItem(0) as string + "'").CopyToDataTable();
				table.Columns.Remove("UPPER_MNU_ID");
				table.Columns.Remove("UPPER_MNU_TYPE");
				table.Columns.Remove("DEPTH");
				
				//하위그리드 정보 모으기
				ultraGrid1.SetDataBinding(table, null);

				ultraTextEditor1.Value = ultraTree1.ActiveNode.FullPath;

			}
            catch(Exception ex)
            {
				MessageBox.Show("하위 데이터가 존재하지 않습니다.", "경고", MessageBoxButtons.OK);
				return;
            }
			
			
		}
    }
}
