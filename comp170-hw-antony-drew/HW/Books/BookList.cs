using System;
using System.IO;
using System.Collections.Generic;
// Names:

namespace Books
{
   /** A class that maintains a list of books. */
   public class BookList
   {
      private List<Book> list;

      /** Create an empty list of books. */
      public BookList()
      {
         list = new List<Book>();
      }

      /** Add book to the list.
        * The regular assignment version always returns true. */
      public bool Addbook(Book book)
      {   // code
			list.Add(book);
         return true; 
      }

      /** List the full descriptions of each book,
        * with each book separated by a blank line. */
      public void PrintList()
      {  // code
			StreamWriter writer;    
			writer = new StreamWriter("Test Output" + ".txt");
			foreach (Book book in list) {
             Console.WriteLine("{0}"+"\n",book);
			 writer.WriteLine("{0}"+"\n",book); 	
           }
			writer.Close();
      }

      /** List the titles (only!) of each book in the list
        * by the specified author, one per line. */
		
	  public string[,] GetListAuthors()
      {  //code
			int counter =0;
			string[,] authors = new string[1,list.Count];
		foreach (Book book in list) {
           
				authors[0,counter] = book.GetAuthor();
				counter++;
           }
			return authors;
      }
      public void PrintTitlesByAuthor(string[,] author)
      {  //code
		foreach (Book book in list) {
           
				Console.WriteLine("{0}\n",book.GetTitle());
           }
      }

      /** List the full descriptions of each book printed
        * in the range of years specified,
        * with each book separated by a blank line. */
      public void PrintBooksInYears(int firstYear, int lastYear)
      {  // code
			
				foreach (Book book in list) {
           		if ((book.Getyear() >= firstYear) && (book.Getyear() <= lastYear)){
				Console.WriteLine("{0}",book);}
           	}
      }

      public override string ToString()     												                        
      {  // code for extra credit 
			foreach (Book book in list) {
				if (book != null) 

             return string.Format("{0}\n",book.ToString()); }
				return "";
           
	  }	
			

      ////////////////////////////
      // Extra Credit past here //
      ////////////////////////////

      /** Construct a new BookList using Book data read from
        * reader.  The data coming from reader will contain groups
        * of three line descriptions useful for the Book constructor
        * that reads from a stream.  Each three-line book description
        * may or may not be preceded by an empty line. */
      public BookList(StreamReader reader)													
      { // code for extra credit
//			
			
			int counter = 0;
			string tit,aut;
			int yr;
			
			string[,] lines = new string[1,1000];
			string line = reader.ReadLine();
			
			BookList list = new BookList();
			
                        do
                        {
						lines[0,counter] = line;
						counter++;
						
                           
                        } while ((line = reader.ReadLine()) != null);

                        reader.Close();
				
				for (int x = 0; x < counter; x=x+4) {
						tit = lines[0,x];
						aut = lines[0,x+1];
						yr = Convert.ToInt32(lines[0,x+2]);
						
						list.Addbook(new Book(tit, aut, yr));
						
						
						 }
			
			Console.WriteLine("\nThe FULL-AUTO list is:");
			list.PrintList();
			
			
      }

      /** Test if aBook is contained in this BookList.
        * Return true if book is equal to a Book in the list,
        * false otherwise. */
      public bool Contains(Book book)
      { // code for extra credit
			foreach (Book aBook in list) {
           		
			if (aBook.GetTitle() == book.GetTitle() && aBook.GetAuthor() == book.GetAuthor() && aBook.Getyear() == book.Getyear())
			
         	return true; }
			return false;
      }

      /** Add all the Books in books to this BookList.
        * Return true if the current list was changed.
        * Return false if each Book in books is a
        * duplicate of a Book in the current list. */
      public bool AddAll(BookList books)
      { // code for extra credit
			foreach (Book book in list) {
           		
			if (list.Contains(book) == false && books.Contains(book) == true)
			//list.Add(book);
         	return true; }
			return false;
      }

     // Revised AddBook documentation for extra credit:
     /** Adds aBook to the list if aBook is
       * not already in the list.
       * Return true if aBook is added,
       * and false if it was already in the list. */
	  public bool AddAllRevised(BookList books)
      { // code for extra credit
			foreach (Book book in list) {
           		
			if (list.Contains(book) == false && books.Contains(book) == true)
			list.Add(book);
         	return true; }
			return false;
      }
   }
}