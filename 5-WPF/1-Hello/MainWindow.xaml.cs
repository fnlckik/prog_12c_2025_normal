using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _1_Hello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        // Binding: összekötés, összekapcsolás
        // Csak property-ket lehet Bindolni (get, set)
        // Observable: megfigyelhető lista
        public ObservableCollection<string> Names { get; set; }
        
        private string personName; // field (mező)
        public string PersonName // property (tulajdonság)
        {
            get
            {
                return personName;
            }
            set
            {
                this.personName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PersonName"));
            }
        } // aktuálisan kiválasztott ember

        public MainWindow()
        {
            InitializeComponent();
            //Names = new ObservableCollection<string>();
            //Names = new();
            //Names = new() { "Sándor", "József", "Benedek" };
            Names = ["Sándor", "József", "Benedek"];
            PersonName = "";
            DataContext = this;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Helló Világ!");
            //string name = NameTextBox.Text;
            GreetText.Text = $"Helló {PersonName}!";
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //string name = NameTextBox.Text;
            //NamesListBox.Items.Add(name);
            if (string.IsNullOrWhiteSpace(PersonName) || Names.Contains(PersonName)) return;
            Names.Add(PersonName);
            //NamesListBox.ItemsSource = null;
            //NamesListBox.ItemsSource = Names;
        }

        private void NamesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // null coalesce operator
            PersonName = NamesListBox.SelectedItem.ToString() ?? "";
        }
    }
}