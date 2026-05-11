using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Election
{
    public partial class Form1 : Form
    {
        private string[] parties;
        private List<Vote> votes;

        public Form1()
        {
            InitializeComponent();
        }

        // F1 - 4p
        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.OK) return; // 1p
            using (StreamReader sr = new StreamReader(dialog.FileName))
            {
                parties = sr.ReadLine().Split(','); // 1p
                votes = new List<Vote>();
                while (!sr.EndOfStream)
                {
                    string[] temp = sr.ReadLine().Split(',');
                    string name = temp[0];
                    DateTime birth = DateTime.Parse(temp[1]);
                    char c = char.Parse(temp[2]);
                    string party = temp[3];
                    Vote v = new Vote(name, birth, c, party); // 1p
                    votes.Add(v); // 1p
                }
            }
            ShowVotes();
        }

        // F2 - 5p
        private void ShowVotes()
        {
            VotesDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            VotesDataGrid.RowHeadersVisible = false; // 1p

            VotesDataGrid.ColumnCount = 4;
            VotesDataGrid.Columns[0].HeaderText = "Név";
            VotesDataGrid.Columns[1].HeaderText = "Születési dátum";
            VotesDataGrid.Columns[2].HeaderText = "Osztály";
            VotesDataGrid.Columns[3].HeaderText = "Párt"; // 1p
            VotesDataGrid.Rows.Clear();
            foreach (Vote vote in votes)
            {
                VotesDataGrid.Rows.Add(vote.Name, vote.Birth.ToShortDateString(), vote.Class, vote.Party); // 2p
            }
            ResultsMenuItem.Enabled = true;
        }

        // F3 - 5p
        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            if (VotesDataGrid.SelectedRows.Count == 0) return; // 1p
            string name = VotesDataGrid.SelectedRows[0].Cells[0].Value.ToString(); // 1p
            Vote selected = votes.First(v => v.Name == name); // 1p
            EditForm form = new EditForm(selected, parties);
            form.ShowDialog(); // 1p

            // Ez már F4 feladat.
            votes[votes.IndexOf(selected)] = form.EditedVote; // 1p
            ShowVotes();
        }

        // F5 - 6p
        private void ResultsMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> results = new Dictionary<string, int>();
            foreach (Vote vote in votes)
            {
                if (results.ContainsKey(vote.Party))
                {
                    results[vote.Party]++;
                }
                else
                {
                    results.Add(vote.Party, 1);
                }
            } // 2p

            Series series = Chart.Series[0];
            series.ChartType = SeriesChartType.Column; // 1p
            series.Points.Clear();
            foreach (string party in parties)
            {
                DataPoint p = new DataPoint();
                p.SetValueXY(party, results[party]); // 1p
                p.ToolTip = results[party].ToString() + " db"; // 1p
                series.Points.Add(p);
            }
            Chart.Visible = true; // 1p
        }
    }
}
