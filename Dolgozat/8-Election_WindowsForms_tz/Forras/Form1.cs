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
    }
}
