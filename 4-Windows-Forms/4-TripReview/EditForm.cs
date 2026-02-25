using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripReview
{
    public partial class EditForm : Form
    {
        internal Traveller EditedTraveller { get; set; }

        internal EditForm(Traveller t)
        {
            InitializeComponent();
            NameTextBox.Text = t.Name;
            EmailTextBox.Text = t.Email;
            BirthDateTime.Value = t.BirthDate;
            EditedTraveller = t;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int id = EditedTraveller.ID;
            string name = NameTextBox.Text;
            string email = EmailTextBox.Text;
            DateTime birthDate = BirthDateTime.Value;
            EditedTraveller = new Traveller(id, name, email, birthDate);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
