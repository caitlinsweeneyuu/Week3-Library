namespace Library;

class Book
{
    private string title;
    private string author;
    private string isbn;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public string ISBN
    {
        get { return isbn; }
        set { isbn = value; }
    }
    public Book(string bookTitle, string bookAuthor, string bookISBN)
    {
        this.Title = bookTitle;
        this.Author = bookAuthor;
        this.ISBN = bookISBN;
    }
    public void DisplayInfo()
    {
        // Print the book details to the console
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");

    }
}

