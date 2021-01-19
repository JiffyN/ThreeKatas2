namespace ThreeKatas
{
    public class Book
    {
        public string Title { get; set; }

        public Book(string title)
        {
            Title = title;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Book;
            if (other.Title == this.Title)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return Title.GetHashCode();
        }
    }
}
