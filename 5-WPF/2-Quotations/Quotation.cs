namespace _2_Quotations
{
    public class Quotation
    {
        public Quotation(string author, string title, int year, string text)
        {
            Author = author;
            Title = title;
            Year = year;
            Text = text;
        }

        public string Author { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return string.Join("", Text.Take(20)) + "...";
        }
    }
}
