using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
            data = Generate();
            ShowData();
        }

        private void ShowData()
        {
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
            CalculateStats();
        }

        private List<int> Generate()
        {
            List<int> result = new List<int>();
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
                result.Add(n);
            }
            return result;
        }

        private void CalculateStats()
        {
            BottomNumUpDown.Value = data.Min();
            TopNumUpDown.Value = data.Max();
            double avg = data.Average();
            AverageLabel.Text = "Átlag: " + Math.Round(avg, 2);
            MagnitudeLabel.Text = "Terjedelem: " + (data.Max() - data.Min());

            // Szórás
            //double s = 0;
            //foreach (int e in data)
            //{
            //    s = s + Math.Pow(avg - e, 2);
            //}
            //s = s / data.Count;
            //s = Math.Sqrt(s);
            //double s = Math.Sqrt(data.Sum(e => Math.Pow(avg - e, 2)) / data.Count);
            double s = Math.Sqrt(data.Aggregate(0.0, (S, e) => S + Math.Pow(avg - e, 2)) / data.Count);
            SpreadLabel.Text = "Szórás: " + Math.Round(s, 2);

            // Medián
            var ordered = data.OrderBy(x => x).ToList();
            int n = ordered.Count;
            if (n % 2 == 1)
            {
                // 1 2 3 4 5
                // Matek: 3. adat (n+1) / 2
                // Prog: 2. adat n/2
                MedianLabel.Text = "Medián: " + ordered[n / 2];
            }
            else
            {
                // 1 2 3 4 5 6
                // Matek: 3. és 4. adat n/2; n/2 + 1
                // Prog: 2. és 3. adat n/2; n/2 - 1
                MedianLabel.Text = "Medián: " + (ordered[n / 2 - 1] + ordered[n / 2]) / 2.0;
            }
        }

        private void FileMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Application.StartupPath;
            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.OK) return;
            string path = dialog.FileName;
            using (StreamReader sr = new StreamReader(path))
            {
                string[] temp = sr.ReadLine().Split();
                data = temp.Select(x => int.Parse(x)).ToList();
            }
            ShowData();
        }

        private void ExtremeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ExtremeCheckBox.Checked)
            {
                int min = (int)BottomNumUpDown.Value;
                int max = (int)TopNumUpDown.Value;
                foreach (DataGridViewRow item in MaterialDataGrid.Rows) // soronként járjuk be
                {
                    foreach (DataGridViewCell cell in item.Cells)
                    {
                        if (cell.Value != null && (int)cell.Value < min)
                        {
                            cell.Style.BackColor = Color.LightPink;
                        }
                    }
                }
            }
        }
    }
}
