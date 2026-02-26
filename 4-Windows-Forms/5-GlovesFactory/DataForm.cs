using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GlovesFactory
{
    public partial class DataForm : Form
    {
        private List<int> data;

        public DataForm()
        {
            InitializeComponent();
        }

        private void RandomMenuItem_Click(object sender, EventArgs e)
        {
            data = new List<int>();
            Random r = new Random();
            // 123 adat
            for (int i = 0; i < 123; i++)
            {
                double p = r.NextDouble(); // [0, 1)
                int n;
                if (p < 0.25)
                {
                    n = r.Next(50, 60);
                }
                else if (p < 0.95)
                {
                    n = r.Next(60, 70);
                }
                else
                {
                    n = r.Next(90, 100);
                }
                data.Add(n);
            }
            MaterialDataGrid.ColumnCount = 8;
            MaterialDataGrid.RowCount = (int)Math.Ceiling((double)data.Count / 8);
            int rowIndex = 0;
            int colIndex = 0;
            foreach (int number in data)
            {
                MaterialDataGrid.Rows[rowIndex].Cells[colIndex].Value = number;
                MaterialDataGrid.Rows[rowIndex].Height = MaterialDataGrid.Height / 8;
                colIndex++;
                if (colIndex > 7)
                {
                    rowIndex++;
                    colIndex = 0;
                }
            }
            //MaterialDataGrid.Rows[0].Cells[0].Value = data[0];
            //MaterialDataGrid.Rows[0].Cells[1].Value = data[1];
            //MaterialDataGrid.Rows[0].Cells[2].Value = data[2];
            //MaterialDataGrid.Rows[0].Cells[3].Value = data[3];

            //MaterialDataGrid.Rows[1].Cells[0].Value = data[8];
            //MaterialDataGrid.Rows[1].Cells[1].Value = data[9];
            //MaterialDataGrid.Rows[1].Cells[2].Value = data[10];
            //for (int i = 0; i < data.Count; i++)
            //{
            //    MaterialDataGrid.Rows[i / 8].Cells[i % 8].Value = data[i];
            //    MaterialDataGrid.Rows[i / 8].Height = MaterialDataGrid.Height / 8;
            //}
            StatsGroupBox.Enabled = true;
            ExtremeGroupBox.Enabled = true;
        }
    }
}
