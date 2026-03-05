using System;
using System.Collections.Generic;
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
            // Adatsokaság beállításai
            Series serie = DataChart.Series[0];
            serie.ChartType = type;

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
        }
    }
}
