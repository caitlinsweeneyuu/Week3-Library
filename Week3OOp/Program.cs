// See https://aka.ms/new-console-template for more information


using Library;
class Program
{
    static void Main(string[] args)
    {
        // Create a new instance (object) of the Book class
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");
        Book book1 = new Book("Ultimate C#", "Microsoft", "2233445");
        Console.WriteLine("Currently available book:");
        book.DisplayInfo();
        book1.DisplayInfo();

        Member member = new Member(1, "John Smith", "1 High Street", 0790090090);
        Member member1 = new Member(2, "Mary Jones", "102 Garden Road", 0790345666);

        Console.WriteLine("Current library members");
        member.DisplayInfo();
        member1.DisplayInfo();
    }
}