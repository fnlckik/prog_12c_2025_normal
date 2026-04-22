using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace _2_Quotations
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Quotation correct;
        private Quotation answer;
        private Brush? authorBackground;
        private Brush? titleBackground;
        private Brush? yearBackground;
        private bool isReload;

        public event PropertyChangedEventHandler? PropertyChanged;

        // Csak public property-t lehet Binding-nál használni.
        public ObservableCollection<Quotation> Quotes { get; set; }
        public ObservableCollection<Quotation> Answers { get; set; }

        public Quotation Correct
        { 
            get => correct;
            set
            {
                correct = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Correct)));
            }
        }

        public Quotation Answer
        {
            get => answer;
            set
            {
                answer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Answer)));
            }
        }

        public Brush? AuthorBackground
        { 
            get => authorBackground;
            set
            {
                authorBackground = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AuthorBackground)));
            }
        }

        public Brush? TitleBackground
        { 
            get => titleBackground;
            set
            {
                titleBackground = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TitleBackground)));
            }
        }

        public Brush? YearBackground
        {
            get => yearBackground;
            set
            {
                yearBackground = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(YearBackground)));
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            Quotes = [];
            Answers = [];
            DataContext = this;
            correct = new();
            answer = new();
            isReload = false;
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new();
            dialog.Filter = "Szöveges fájl|*.txt";
            //dialog.InitialDirectory = AppContext.BaseDirectory;
            bool? result = dialog.ShowDialog();
            if (result != true) return;
            string path = dialog.FileName;
            using StreamReader sr = new(path); // le is zárja automatikusan
            Quotes.Clear();
            while (!sr.EndOfStream)
            {
                // null forgiving operator !.
                // "Biztosan tudom, hogy nem null."
                string[] temp = sr.ReadLine()!.Split("|");
                string author = temp[0];
                string title = temp[1];
                int year = int.Parse(temp[2]);
                string text = temp[3];
                Quotation q = new(author, title, year, text);
                Quotes.Add(q);
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            QuotationTextBlock.Visibility = Visibility.Visible;
            //Quotation q = (Quotation)QuotationComboBox.SelectedItem;
            //QuotationTextBlock.Text = q.Text;
            if (isReload) return;
            Answer = new();
            //Answer.Author = "";
            //Answer.Title = "";
            //Answer.Year = 1000;
            AuthorBackground = Brushes.White;
            TitleBackground = Brushes.White;
            YearBackground = Brushes.White;
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            // Ez nagyon Windows Forms-os megoldás
            //if (answer.Author == "" || correct.Author == "")
            //{
            //    AuthorTextBox.Background = Brushes.White;
            //}
            //else if (answer.Author == correct.Author)
            //{
            //    AuthorTextBox.Background = Brushes.LightGreen;
            //}
            //else
            //{
            //AuthorTextBox.Background = Brushes.LightPink;
            //}
            if (answer.Author == "" || correct.Author == "")
            {
                AuthorBackground = Brushes.White;
            }
            else if (answer.Author == correct.Author)
            {
                AuthorBackground = Brushes.LightGreen;
            }
            else
            {
                AuthorBackground = Brushes.LightPink;
            }

            if (answer.Title == "" || correct.Title == "")
            {
                TitleBackground = Brushes.White;
            }
            else if (answer.Title == correct.Title)
            {
                TitleBackground = Brushes.LightGreen;
            }
            else
            {
                TitleBackground = Brushes.LightPink;
            }

            if (answer.Year == correct.Year)
            {
                YearBackground = Brushes.LightGreen;
            }
            else
            {
                YearBackground = Brushes.LightPink;
            }
        }

        private void StoreButton_Click(object sender, RoutedEventArgs e)
        {
            if (Correct.Text == "" || Answer.Author == "") return;
            Answer.Text = Correct.Text;
            Answers.Add(Answer.Clone());
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (answer == null) return; // Ha nincs kiválasztott elem
            // Keresés tétel!
            isReload = true;
            Correct = Quotes.First(q => q.Text == answer.Text);
            isReload = false;
            //MessageBox.Show(Answers[0].ToString());
            //MessageBox.Show(Answers[Answers.Count-1].ToString());
            CheckButton_Click(sender, e);
        }
    }
}