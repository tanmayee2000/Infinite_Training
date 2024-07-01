using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Books
    {
        private string Book_Name;
        private string Author_Name;

        // Constructor
        public Books(string bookname, string authorname)
        {
            this.Book_Name = bookname;
            this.Author_Name = authorname;
        }

        public void Display()
        {
            Console.WriteLine($"* Book Name: {Book_Name}");
            Console.WriteLine($"* Author Name: {Author_Name}");
            Console.WriteLine();
        }
    }

    class Book_Shelf
    {
        // Array to store books
        private Books[] BooksArray = new Books[5];

        // Indexer for Books object
        public Books this[int index]
        {
            get { return BooksArray[index]; }
            set { BooksArray[index] = value; }
        }
    }

    class Q1
    {
        static void Main()
        {
            Book_Shelf shelf = new Book_Shelf();

            // Input and store 5 books using indexer
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter details for Book {i + 1} :");
                Console.Write("~ Book Name : ");
                string bookName = Console.ReadLine();
                Console.Write("~ Author Name : ");
                string authorName = Console.ReadLine();
                Console.WriteLine("-------------------------");

                shelf[i] = new Books(bookName, authorName);
            }

            Console.WriteLine("=======================");
            Console.WriteLine("Books on the BookShelf:");
            Console.WriteLine("=======================");

            // Display all books using Display() method
            for (int i = 0; i < 5; i++)
            {
                shelf[i].Display();
            }

            Console.Read();
        }
    }
}
