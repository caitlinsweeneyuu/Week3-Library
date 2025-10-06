// See https://aka.ms/new-console-template for more information


using Library;
class Program
{
    static void Main(string[] args)
    {
        // Create a new instance (object) of the Book class
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");

        book.DisplayInfo();
    }
}