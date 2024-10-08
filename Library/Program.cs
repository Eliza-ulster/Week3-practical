using Library;
class Program
{
   
    static void Main(string[] args)
    {

        Book book = new Book("C# for beginners", "Bill Gates", "123567800");
        Book book1 = new Book("Ultimate C#", "Microsoft", "222889");


        book.DisplayInfo();
        book1.DisplayInfo();




    }
}