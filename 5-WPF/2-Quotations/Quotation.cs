using System.ComponentModel;

namespace _2_Quotations
{
    public class Quotation : INotifyPropertyChanged
    {
        private string author;
        private string title;
        private int year;
        private string text;
        private int point;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Author
        { 
            get => author;
            set
            {
                author = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Author)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DisplayedText)));
            }
        }

        public string Title
        {
            get => title;
            set
            {
                title = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Title)));
            }
        }

        public int Year
        {
            get => year;
            set
            {
                year = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Year)));
            }
        }

        public string Text { get => text; set => text = value; }

        public Quotation(string author, string title, int year, string text)
        {
            Author = author;
            Title = title;
            Year = year;
            Text = text;
            Point = 0;
        }

        public Quotation()
        {
            Author = "";
            Title = "";
            Year = 1000;
            Text = "";
            Point = 0;
        }

        // Számított property
        public string DisplayedText
        {
            get
            {
                return $"{Author}: {Text}";
            }
        }

        public int Point { get => point; set => point = value; }

        public override string ToString()
        {
            return string.Join("", Text.Take(20)) + "...";
        }

        // Készít egy másolatot az objektumról.
        public Quotation Clone()
        {
            return new(author, title, year, text);
        }
    }
}
