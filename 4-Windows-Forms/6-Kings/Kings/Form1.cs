using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Kings
{
    public partial class Form1 : Form
    {
        private List<King> kings;
        private string[] headers;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.OK) return;
            ReadFile(dialog.FileName);
            ShowKings(kings);
            ShowDynasty();
        }

        private void ShowDynasty()
        {
            //HashSet<string> dynasties = new HashSet<string>();
            //foreach (King king in kings)
            //{
            //    dynasties.Add(king.Dynasty);
            //}
            var dynasties = kings.Select(k => k.Dynasty).Distinct();
            DynastyComboBox.Items.Clear();
            DynastyComboBox.Items.Add("Minden adat...");
            //foreach (string dynasty in dynasties)
            //{
            //    DynastyComboBox.Items.Add(dynasty);
            //}
            DynastyComboBox.Items.AddRange(dynasties.ToArray());
        }

        private void ReadFile(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                headers = sr.ReadLine().Split(';');
                kings = new List<King>();
                while (!sr.EndOfStream)
                {
                    string[] temp = sr.ReadLine().Split(';');
                    int start = int.Parse(temp[0]);
                    int end = int.Parse(temp[1]);
                    string name = temp[2];
                    int year = int.Parse(temp[3]);
                    string place = temp[4];
                    string dynasty = temp[5];
                    King k = new King(name, year, place, start, end, dynasty);
                    kings.Add(k);
                }
            }
        }

        private void ShowKings(List<King> kings)
        {
            KingsDataGrid.ColumnCount = headers.Length - 1;
            for (int i = 0; i < KingsDataGrid.ColumnCount; i++)
            {
                KingsDataGrid.Columns[i].HeaderCell.Value = headers[i];
            }

            //KingsDataGrid.RowCount = kings.Count;
            //for (int i = 0; i < KingsDataGrid.RowCount; i++)
            //{
            //    DataGridViewRow r = KingsDataGrid.Rows[i];
            //    r.Cells[0].Value = kings[i].Start;
            //    r.Cells[1].Value = kings[i].End;
            //    r.Cells[2].Value = kings[i].Name;
            //    r.Cells[3].Value = kings[i].Year;
            //    r.Cells[4].Value = kings[i].Place;
            //}
            KingsDataGrid.Rows.Clear();
            foreach (King k in kings)
            {
                KingsDataGrid.Rows.Add(k.Start, k.End, k.Name, k.Year, k.Place);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile("kings.txt");
            ShowKings(kings);
            ShowDynasty();
        }

        private void DynastyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dynasty = DynastyComboBox.SelectedItem.ToString();
            if (dynasty == "Minden adat...")
            {
                ShowKings(kings);
                return;
            }
            var selectedKings = kings.Where(k => k.Dynasty == dynasty).ToList();
            //if (selectedKings.Count == 0) selectedKings = kings;
            ShowKings(selectedKings);
        }

        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            string name = KingsDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            King selectedKing = kings.First(k => k.Name == name);
            EditForm form = new EditForm(selectedKing);
            form.ShowDialog();
            int selectedIndex = kings.IndexOf(selectedKing);
            kings[selectedIndex] = form.EditedKing;
            ShowKings(kings);
        }

        private void RangeMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRows = KingsDataGrid.SelectedRows.Cast<DataGridViewRow>();
            var selectedKings = kings.Where(k => selectedRows.Any(r => r.Cells[2].Value.ToString() == k.Name));

            Series series = Chart.Series[0];
            series.ChartType = SeriesChartType.Pie;
            series.Points.Clear();
            foreach (King king in selectedKings)
            {
                DataPoint p = new DataPoint();
                int range = king.End - king.Start;
                p.SetValueY(range);
                p.Label = range.ToString();
                p.LegendText = king.Name;
                series.Points.Add(p);
            }
            Chart.Visible = true;
        }

        private void DynastyMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> freq = new Dictionary<string, int>();
            foreach (King king in kings)
            {
                if (freq.ContainsKey(king.Dynasty))
                {
                    freq[king.Dynasty]++;
                }
                else
                {
                    freq.Add(king.Dynasty, 1);
                }
            }
            DynastyForm form = new DynastyForm(freq);
            form.Show();
        }
    }
}
