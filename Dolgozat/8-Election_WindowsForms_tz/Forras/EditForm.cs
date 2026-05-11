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
            // 4. feladat...
        }
    }
}
