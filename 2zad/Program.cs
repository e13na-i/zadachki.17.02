namespace _2zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[]
            {
                new Book("Harry Potter and the Goblet of fire", "J.K. Rowling"),
                new Book("Pride and Prejudice", "Jane Austen"),
                new Book("Anne of Green Gables", "Lucy Maud Montgomery"),
                new Book("Sherlock Holmes", "Arthur Connan Doyle")
            };

            Console.WriteLine("Before sorting:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }

            SelectionSort(books);


            Console.WriteLine("\nAfter sorting by title:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

        static void SelectionSort(Book[] books)
        {
            int n = books.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (string.Compare(books[j].Title, books[minIndex].Title) < 0)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    Book temp = books[i];
                    books[i] = books[minIndex];
                    books[minIndex] = temp;
                }
            }
        }
    }
}
