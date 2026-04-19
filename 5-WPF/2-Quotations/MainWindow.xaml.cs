using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.IO;
using System.Security.Policy;
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
using Xceed.Wpf.Toolkit.Core;

namespace _2_Quotations
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Csak public property-t lehet Binding-nál használni.
        public ObservableCollection<Quotation> Quotes { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Quotes = [];
            DataContext = this;
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
            Quotation q = (Quotation)QuotationComboBox.SelectedItem;
            QuotationTextBlock.Text = q.Text;
        }
    }
}