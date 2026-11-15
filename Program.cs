namespace C__Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region my region Q1
            // 1-   Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object. Print it.
            Book book = new Book();
            book.Title = "C# Basics";
            book.Pages = 464;

            object obj = book;
            Console.WriteLine(obj);
            #endregion
            #region Question 2
            // 2-Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.

            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());

            #endregion
        }
    }


class Book
{
    public string Title;
    public int Pages;
}
}
