class Book
{
    string Title;
    string Author;
    string ISBN;

    void DisplayInfo()

    {
        Console.WriteLine("Book Inforamation");
        Console.WriteLine("-----------------");
        Console.WriteLine($"Book Title;{Title}");
        Console.WriteLine($"Book Author:{Author}");
        Console.WriteLine($"Book ISBN:{ISBN}");
    }

    static void Main(string[] args)
    {
        // Create a new instance of the book class
        Book book = new Book();

        book.Title = " C# for beginners";
        book.Author = "Bill Gates";
        book.ISBN = "123456699";

        Book book2 = new Book();

        book2.Title = "C# Methods and Classes";
        book2.Author = " Microsoft";
        book2.ISBN = "23556189";
        
        // output book information to the Console
        book.DisplayInfo();
        book2.DisplayInfo();




    }
}