class Book
{
    string Title;
    string Author;
    string ISBN;
 

    public Book(string title, string author, string iSBN)
    {
        Title = title;
        Author = author;
        ISBN = iSBN;
    }

    void DisplayInfo()

    {
        Console.WriteLine("Book Inforamation");
        Console.WriteLine("-----------------");
        Console.WriteLine($"Book Title : {Title}");
        Console.WriteLine($"Book Author : {Author}");
        Console.WriteLine($"Book ISBN : {ISBN}");
        Console.WriteLine();
    
    }

    static void Main(string[] args)
    {

        Book book = new Book("C# for beginners", "Bill Gates", "123567800");

        book.DisplayInfo();




    }
}