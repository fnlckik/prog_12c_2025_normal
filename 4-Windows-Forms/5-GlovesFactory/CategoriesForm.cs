using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            CategoriesDataGrid.RowCount = categories.Count;
            CategoriesDataGrid.ColumnCount = 1;
            CategoriesDataGrid.Columns[0].HeaderCell.Value = "Gyakoriságok";
            CategoriesDataGrid.Font = new Font("Microsoft Sans Serif", 14);
            for (int i = 0; i < categories.Count; i++)
            {
                CategoriesDataGrid.Rows[i].HeaderCell.Value = categories[i];
            }
        }
    }
}
