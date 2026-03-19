using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GlovesFactory
{
    public partial class CategoriesForm : Form
    {
        private readonly List<int> data;
        private readonly List<string> categories;

        // "50-54"
        public CategoriesForm(List<int> data, List<string> categories)
        {
            InitializeComponent();
            this.data = data;
            this.categories = categories;
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            CategoriesDataGrid.TopLeftHeaderCell.Value = "Kategóriák";
            CategoriesDataGrid.RowCount = categories.Count - 1;
            CategoriesDataGrid.ColumnCount = 1;
            CategoriesDataGrid.Columns[0].HeaderCell.Value = "Gyakoriságok";
            CategoriesDataGrid.Font = new Font("Microsoft Sans Serif", 14);
            for (int i = 1; i < categories.Count; i++)
            {
                CategoriesDataGrid.Rows[i-1].HeaderCell.Value = categories[i];
                CategoriesDataGrid.Rows[i-1].Cells[0].Value = CountCategory(categories[i]);
            }
            ShowChart();
        }

        private void ShowChart()
        {
            Series series = CategoriesChart.Series[0];
            //series.CustomProperties = "PieLabelStyle = Outside";
            series["PieLabelStyle"] = "Outside";

            foreach (DataGridViewRow row in CategoriesDataGrid.Rows)
            {
                int value = (int)row.Cells[0].Value;
                string category = row.HeaderCell.Value.ToString();

                DataPoint p = new DataPoint();
                p.SetValueY(value);
                p.LegendText = category; // jelmagyarázat
                
                if (value != 0)
                {
                    double percent = (double)value / data.Count;
                    p.Label = $"{Math.Round(percent * 360)}°"; // adatfelirat
                    p.LabelBackColor = Color.White;
                    p.LabelBorderDashStyle = ChartDashStyle.Solid;
                    p.LabelBorderColor = Color.Black;
                }
                p.BorderColor = Color.Black;
                //p.BorderDashStyle = ChartDashStyle.Dot;
                //p.BorderWidth = 3;
                series.Points.Add(p);
            }
        }

        // "50 - 54 m^2"
        private int CountCategory(string category)
        {
            int min = int.Parse(category.Split(' ')[0]);
            int max = min + 4;
            return data.Count(x => x >= min && x <= max);
        }

        private void CategoriesDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            var selected = CategoriesDataGrid.SelectedCells;
            var points = CategoriesChart.Series[0].Points;

            if (selected.Count == 0 || points.Count == 0) return;
            DataGridViewCell cell = selected[0];
            int rowIndex = cell.RowIndex;
            
            DataPoint p = points[rowIndex];
            foreach (DataPoint point in points)
            {
                point["Exploded"] = "false";
            }
            p["Exploded"] = "true";
        }
    }
}
