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
            #region Question 3
            // Q03.  Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it. int pages = "464";


            int pages = 464;
            Console.WriteLine(pages);

            #endregion
           
            #region Question 4
            // Q04. Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.

            try
            {
                int a = 10;
                int b = 0;
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }

            #endregion
            #region Question 5
            // Q05. Declare an int pages = 300; then store it in a double variable without using a cast.

            int pagesQ5 = 300;
            double pagesDouble = pagesQ5;
            Console.WriteLine(pagesDouble);

            #endregion
            #region Question 6
            // Q06. Declare a double price = 49.99; then convert it into an int using a cast.

            double price = 49.99;
            int newPrice = (int)price;
            Console.WriteLine(newPrice);

            #endregion
            #region Question 7
            // Q07. Given string pagesText = "464";, convert it into an int using the Convert class.

            string pagesText = "464";
            int convertedPages = Convert.ToInt32(pagesText);
            Console.WriteLine(convertedPages);

            #endregion
            #region Question 8
            // Q08. Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.

            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine(year);

            string badText = "abc";

            if (!int.TryParse(badText, out int number))
            {
                Console.WriteLine("Invalid number");
            }

            #endregion
            #region Question 9
            // Q09. Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.

            int pagesQ9 = 464;
            string pagesString = pagesQ9.ToString();

            Console.WriteLine(pagesString.GetType());

            #endregion
            #region Question 10
            // Q10. Declare an int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.

            int copies = 100;
            object boxedCopies = copies;
            int unboxedCopies = (int)boxedCopies;

            Console.WriteLine(boxedCopies);
            Console.WriteLine(unboxedCopies);

            #endregion
            #region Question 11
            // Q11. Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its value.

            int? nullableYear = null;
            Console.WriteLine(nullableYear.HasValue);

            nullableYear = 2023;
            Console.WriteLine(nullableYear.Value);

            #endregion
            #region Question 12
            // Q12. Declare a string? reviewer = null;. Print whether it is null.

            string? reviewer = null;
            Console.WriteLine(reviewer == null);

            #endregion
        }
    }


    class Book
{
    public string Title;
    public int Pages;
}
}
