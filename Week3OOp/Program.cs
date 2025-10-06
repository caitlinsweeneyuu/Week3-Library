// See https://aka.ms/new-console-template for more information

class Book
{
    string Title;
    string Author;
    string ISBN;

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
        Book book = new Book();

        // Set the properties of the book object
        book.Title = "C# for beginners";
        book.Author = "BillGates";
        book.ISBN = "12345678";

        Book book1 = new Book();
        book1.Title = "C# Methods and classes";
        book1.Author = "Microsoft";
        book1.ISBN = "55667778";

        book.DisplayInfo();
        book1.DisplayInfo();
    }
}