using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace Movies
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Review? selected;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<Review> Reviews { get; set; }
        public ObservableCollection<Review> Storage { get; set; }

        public Review? Selected
        {
            get => selected;
            set
            {
                selected = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Selected)));
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Reviews = [];
            Storage = [];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new();
            bool? result = dialog.ShowDialog();
            if (result != true) return; // 1
            Reviews.Clear();
            using StreamReader sr = new(dialog.FileName);
            while (!sr.EndOfStream)
            {
                string[] temp = sr.ReadLine()!.Split(','); // 2
                Review r = new(temp[0], int.Parse(temp[1])); // 3
                Reviews.Add(r); // 4
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Selected == null) return;
            Storage.Add(Selected);
        }
    }
}