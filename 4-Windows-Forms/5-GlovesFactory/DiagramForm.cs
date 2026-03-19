using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GlovesFactory
{
    public partial class DiagramForm : Form
    {
        private List<int> data;
        private SeriesChartType type;

        public DiagramForm(List<int> data, SeriesChartType type)
        {
            InitializeComponent();
            this.data = data;
            this.type = type;
        }

        private void DiagramForm_Load(object sender, EventArgs e)
        {
            Font font = new Font("Microsoft Sans Serif", 14);

            DataChart.Legends[0].Font = font;

            // Adatsokaság beállításai
            Series serie = DataChart.Series[0];
            serie.LegendText = "Felhasznált bőrmennyiség"; // jelmagyarázat
            serie.ChartType = type;
            serie.Color = Color.Black;
            serie["PointWidth"] = "0.5";
            serie.BorderWidth = 3;

            if (serie.ChartType == SeriesChartType.Line)
            {
                serie.MarkerStyle = MarkerStyle.Circle;
                serie.MarkerBorderWidth = 5;
                serie.MarkerBorderColor = Color.Blue;
            }

            DataPointCollection points = serie.Points;
            points.Clear();
            //points.AddXY("Kis János", 85);
            //points.AddXY("Nagy Fanni", 48);
            for (int i = 0; i < data.Count; i++)
            {
                //points.AddXY(i + 1, data[i]);
                DataPoint p = new DataPoint();
                p.SetValueXY(i + 1, data[i]);
                p.ToolTip = data[i].ToString();
                points.Add(p);
            }

            ChartArea area = DataChart.ChartAreas[0];
            area.AxisX.Title = "Napok";
            area.AxisX.TitleFont = font;
            area.AxisX.MajorGrid.LineColor = Color.Gray;
            area.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            area.AxisY.Title = "Felhasznált bőrmennyiség";
            area.AxisY.TitleFont = font;
            area.AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            area.AxisY.MajorGrid.LineColor = Color.Gray;
            area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
        }
    }
}
