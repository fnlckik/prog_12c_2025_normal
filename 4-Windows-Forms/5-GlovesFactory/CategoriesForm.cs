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

            foreach (DataGridViewRow row in CategoriesDataGrid.Rows)
            {
                int value = (int)row.Cells[0].Value;

                DataPoint p = new DataPoint();
                p.SetValueY(value);
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
    }
}
