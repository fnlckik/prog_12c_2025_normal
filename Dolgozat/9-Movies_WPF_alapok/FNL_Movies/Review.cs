using System.ComponentModel;

namespace Movies
{
    public class Review : INotifyPropertyChanged
    {
        private string title;
        private int point;

        public event PropertyChangedEventHandler? PropertyChanged;

        public Review(string title, int point)
        {
            this.title = title;
            this.point = point;
        }

        public string Title { get => title; set => title = value; }
        public int Point
        {
            get => point;
            set
            {
                point = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DisplayedText)));
            }
        }

        public string DisplayedText
        {
            get
            {
                return $"{Title} ({Point})";
            }
        }

        public override string ToString()
        {
            return title;
        }
    }
}
