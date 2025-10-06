// See https://aka.ms/new-console-template for more information

class Book
{
    string Title;
    string Author;
    string ISBN;

    public Book(string bookTitle, string bookAuthor, string bookISBN)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
    }
    void DisplayInfo()
    {
        // Print the book details to the console
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");

    }
    static void Main(string[] args)
    {
        // Create a new instance (object) of the Book class
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");

        book.DisplayInfo();
    }
}