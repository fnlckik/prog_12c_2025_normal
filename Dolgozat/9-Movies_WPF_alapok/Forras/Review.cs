namespace Movies
{
    public class Review
    {
        private string title;
        private int point;

        public Review(string title, int point)
        {
            this.title = title;
            this.point = point;
        }

        public string Title { get => title; set => title = value; }
        public int Point { get => point; set => point = value; }

        public override string ToString()
        {
            return title;
        }
    }
}
