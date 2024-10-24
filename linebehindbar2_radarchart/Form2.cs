using Infragistics.UltraChart.Resources.Appearance;
using Infragistics.UltraChart.Shared.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace linebehindbar2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
            LoadRadarChart();

        }
        private void LoadRadarChart()
        {
            ultraChart1.ChartType = ChartType.RadarChart;
            
            // Bind the DataTable to the chart
            ultraChart1.Data.DataSource = GetChartData();
            ultraChart1.Data.DataBind();
            RadarChartAppearance radarAppearance = new RadarChartAppearance();
            radarAppearance.SplineTension = 0.1F;
            radarAppearance.ColorFill = true;
            radarAppearance.LineThickness = 1;
            radarAppearance.LineDrawStyle = LineDrawStyle.Solid;
            radarAppearance.MidPointAnchors = true;
            radarAppearance.SpacingAroundChart = 5;

            ultraChart1.RadarChart = radarAppearance;
            // Customize the X-axis (Category labels)
            ultraChart1.Axis.X.Labels.Visible = true;
            ultraChart1.Axis.X.Labels.Font = new Font("Arial", 8, FontStyle.Regular);
            ultraChart1.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>";
            ultraChart1.Axis.X.MajorGridLines.Visible = true;
            ultraChart1.Axis.X.MajorGridLines.Color = Color.Gray;

            // Customize the Y-axis (Values)
            ultraChart1.Axis.Y.Labels.Visible = true;
            ultraChart1.Axis.Y.Labels.Font = new Font("Arial", 8, FontStyle.Regular);
            ultraChart1.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:0>";
            ultraChart1.Axis.Y.MajorGridLines.Visible = true;
            ultraChart1.Axis.Y.MajorGridLines.Color = Color.LightGray;

            // Optionally set a custom Y-axis range
            ultraChart1.Axis.Y.RangeType = AxisRangeType.Custom;
            ultraChart1.Axis.Y.RangeMin = 0;
            ultraChart1.Axis.Y.RangeMax = 100;
            //ultraChart1.Axis.Y.RangeStep = 20;

            // Customize the chart colors using ColorModel
            ultraChart1.ColorModel.ModelStyle = ColorModels.CustomLinear;
            ultraChart1.ColorModel.CustomPalette = new Color[]
            {
            Color.LightBlue,  // First series color
            Color.LightGreen, // Second series color
            Color.LightCoral  // Third series color
            };

            // Enable or configure tooltips
            ultraChart1.Tooltips.FormatString = "<ITEM_LABEL>: <DATA_VALUE>";
        }

        public DataTable GetChartData()
        {
            DataTable table = new DataTable();

            // First column represents categories
            table.Columns.Add("Category", typeof(string));


            table.Columns.Add("Category 1", typeof(int));
            table.Columns.Add("Category 2", typeof(int));
            table.Columns.Add("Category 3", typeof(int));
            table.Columns.Add("Category 4", typeof(int));
            table.Columns.Add("Category 5", typeof(int));

            // Rows represent category data for each series
            table.Rows.Add("Value", 40, 60, 30,80,50);
           

            return table;
        }
    }
}
