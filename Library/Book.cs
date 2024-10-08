namespace Library
{
    class Book
    {
        private string title;
        private string author;
        private string isbn;

        //Title property to allow acess
        // to the title private variable
        public string Title
        {
            get { return  title; }// get method 
            set { title= value; }// set method

        }
        public string Author
        {
            get { return author; }
            set { author = value; }

        }
        // Constructor to add a new book
        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        // Constructor to add a new book
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            title = bookTitle;
            author = bookAuthor;
            isbn = bookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {title}");
            Console.WriteLine($"Book Author: {author}");
            Console.WriteLine($"Book ISBN: {isbn}");
            Console.WriteLine();
        }
    }

}