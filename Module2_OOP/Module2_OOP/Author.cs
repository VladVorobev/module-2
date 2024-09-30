public class Author
{
    public string Name { get; }
    public int BirthYear { get; }

    public Author(string name, int birthYear)
    {
        Name = name;
        BirthYear = birthYear;
    }
}
