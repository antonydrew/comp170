using System;
using System.IO;
using System.Collections.Generic;
// Names:

namespace Books
{
   /** A main program to test the class BookList. */
   class TestBookList
   {
       /** Test BookList. */
       public static void Main()
       {
           	
			BookList books = new BookList();
           	books.Addbook(new Book("C# Yellow Book", "Rob Miles", 2011));
		   	books.Addbook(new Book("C# Software Solutions", "John Lewis", 2007));														// MANUAL list "books" has 2 books in it for further tests below
           	Console.WriteLine("The MANUAL list is:");
			books.PrintList();																											// MANUAL list: use PrintList() function as a test
           	Console.WriteLine("Manual titles by authors are:");
		 	books.PrintTitlesByAuthor(books.GetListAuthors());																			// MANUAL list: print titles in booklist as a test
			Console.WriteLine("Manual books by year 2011 are:");
			books.PrintBooksInYears(2011,2011);																							// MANUAL lIST: print books in year 2011 as a test
			
			BookList tab = new BookList();
			tab.Addbook(new Book(FileUtil.GetDataReader("books.txt")));																	// SEMI-AUTO list: added multiple books to booklist in 1 line via new Book constructor w/reader
			
			
			new BookList(FileUtil.GetDataReader("books.txt"));																			// FULL-AUTO list: created new booklist with 1 line via mod BookList contructor w/reader
			
			
			Book book1 = new Book("C# Yellow Book", "Rob Miles", 2011);
			Book book2 = new Book("C# Yellow Book", "Rob Miles", 2011);
			bool test = book2.Equals(book1);																							// test for same book versus book: returns true since books are same
			Console.WriteLine("\nThe logical test for the same book (both Miles books) is: {0}\n{1}\n{2}\n",test,book1,book2);
			
			bool test2 = books.Contains (book1);																						// test for same book in booklist: returns true since book already in booklist books
			Console.WriteLine("\nThe logical test for the same book (Miles) in booklist (books) is: {0}\n{1}\n{2}\n",test2,book1,books);
			
			BookList bookie = new BookList();
			bookie.Addbook(book1);
			bool test3 = books.AddAll (bookie);																							// test for same (items in) booklist versus booklist: return false for duped books
			Console.WriteLine("\nThe logical test for the same booklist is: {0}\n{1}\n{2}\n",test3,books,bookie);
			
			bool test4 = books.AddAllRevised (bookie);																					// revised test for same (items in) booklist versus booklist: add missing books & return true
			Console.WriteLine("\nThe logical test for the same booklist is: {0}\n{1}\n{2}\n",test4,books,bookie);
			
			
          
       }
   }
}