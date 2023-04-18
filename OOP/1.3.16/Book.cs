namespace _1._3._16
{
    public class Book
    {
        private string title;
        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Title cannot be null!");
                }
                this.title = value;
            }
        }

        public string Author { get; set; }

        private decimal price;
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative!");
                }
                this.price = value;
            }
        }
        public string Genre { get; set; }
        public Book(string title, string author, decimal price, string genre)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
            this.Genre = genre;
        }
        public override string ToString()
        {
            return $"{this.Title} от {this.Author}, {this.Price:f2}";
        }
    }
}
