using System.Windows.Forms;

namespace Election
{
    public partial class EditForm : Form
    {
        public Vote EditedVote { get; }
        private string[] parties;

        public EditForm(Vote EditedVote, string[] parties)
        {
            InitializeComponent();
            this.EditedVote = EditedVote;
            this.parties = parties;
        }

        private void EditForm_Load(object sender, System.EventArgs e)
        {
            NameTextBox.Text = EditedVote.Name;
            PartiesComboBox.Items.AddRange(parties); // 1p
        }

        // F4 - 3p
        private void PartiesComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (PasswordTextBox.Text != EditedVote.Name.Split(' ')[1] + "123") return; // 1p
            EditedVote.Party = PartiesComboBox.SelectedItem.ToString(); // 1p
            Close();
        }
    }
}
