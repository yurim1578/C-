using Infragistics.UltraChart.Shared.Styles;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace linebehindbar2
{
    public partial class Form1 : Form
    {
        private bool _drawn;

        public Form1()
        {
            InitializeComponent();
            Data data = new Data();
            ultraChart1.ChartType = Infragistics.UltraChart.Shared.Styles.ChartType.ColumnChart;
            ultraChart1.DataSource = data.GetChartData();
            ultraChart1.DataBind();

            ultraChart1.Axis.Y.RangeMin = 0;
            ultraChart1.Axis.Y.RangeMax = 100;
            ultraChart1.Axis.Y.RangeType = AxisRangeType.Custom;

            ultraChart1.Axis.X.Labels.Visible = false;
            ultraChart1.Axis.X.Labels.SeriesLabels.Visible = true;
            ultraChart1.Axis.X.Labels.SeriesLabels.Orientation = TextOrientation.VerticalLeftFacing;

            ultraChart1.Paint += ultraChart_Paint;
        }

        void ultraChart_Paint(object sender, PaintEventArgs e)
        {
                    // Set the Y-axis value for the horizontal line (e.g., Y = 50)
                    double yValue = 50;

                    // Calculate the Y position for the line based on the chart's size and Y-axis range
                    /* AxisItem yAxis = ultraChart1.Axis.Y as AxisItem;
                     AxisItem xAxis = ultraChart1.Axis.X as AxisItem ;*/

                    // Calculate the pixel position of the horizontal line based on the Y-axis value
                    double yMin = ultraChart1.Axis.Y.RangeMin;
                    double yMax = ultraChart1.Axis.Y.RangeMax;

                    // Map Y-axis value (e.g., 50) to pixel coordinates
                    float yPosition = (float)((yValue - yMin) / (yMax - yMin)) * ultraChart1.Height;

                    // Map X-axis minimum and maximum values to pixel coordinates
                    float xStart = 0;  // Start at the leftmost part of the chart
                    float xEnd = ultraChart1.Width;  // End at the rightmost part of the chart

                    // Define the appearance of the horizontal line
                    Pen pen = new Pen(Color.Red, 2);  // Red line with thickness of 2
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    // Draw the horizontal line across the chart

                    e.Graphics.DrawLine(pen, xStart, ultraChart1.Height - yPosition, xEnd, ultraChart1.Height - yPosition);
           
        }


       
    }
}
