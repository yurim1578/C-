using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace linebehindbar2
{
    internal class Data
    {
        public DataTable GetChartData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("Value", typeof(int));

            table.Rows.Add("Category 1", 40);
            table.Rows.Add("Category 2", 60);
            table.Rows.Add("Category 3", 30);
            table.Rows.Add("Category 4", 80);
            table.Rows.Add("Category 5", 50);

            return table;
        }
    }
}
