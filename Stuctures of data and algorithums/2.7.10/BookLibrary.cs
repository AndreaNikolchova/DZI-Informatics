namespace _2._7._10
{
    public class BookLibrary
    {
        public List<Book> Books { get; } = new List<Book>();
        public void Size()
        {
            Console.WriteLine(Books.Count);
        }
        public void Append(Book b)
        {
            if (this.Books.Where(x => x.Author == b.Author && x.Title == b.Title).Count() == 0)
            {
                this.Books.Add(b);

            }
        }
        public void Delete(string title, string author)
        {
            int index = this.Books.FindIndex(x => x.Title == title && x.Author == author);
            this.Books.Remove(this.Books[index]);
        }
        public void GetB(string title)
        {
            int index = this.Books.FindIndex(x => x.Title == title);
            Console.WriteLine(this.Books[index]);
        }
        public void GetBa(string title, string author)
        {
            int index = this.Books.FindIndex(x => x.Title == title && x.Author == author);
            Console.WriteLine(this.Books[index]);
        }
    }
}
