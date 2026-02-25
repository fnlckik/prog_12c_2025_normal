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

        }
    }
}
