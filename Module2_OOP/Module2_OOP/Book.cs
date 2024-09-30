public class Book
{
    public string Title { get; }
    public int Year { get; }
    public Author Author { get; }

    public Book(string title, int year, Author author)
    {
        Title = title;
        Year = year;
        Author = author;
    }

    public override string ToString() => $"{Title}, {Year}, Автор: {Author.Name}";
}
