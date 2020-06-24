using System;
using System.IO;
using System.Collections.Generic;

// Names:
// Help from:
/* Help details:
*/

namespace Books
{

   /** A class that maintains information on a book. */
   public class Book
   {
      private String tit;
      private String aut;
      private int yr;  // of publication
		
      public Book(String title, String author, int year)
      { //code
		tit = title;
		aut = author;
		yr = year;
      }
	  public String GetTitle()
      {  // code
   
         return tit; //just so skeleton compiles
      }

      /** Return the author. */
      public String GetAuthor()
      {

         return aut; //just so skeleton compiles
      }

      /** Return the year of publication. */
      public int Getyear()
      {  // copy code from before!

         return yr; //just so skeleton compiles
      }

      /** Return a multi-line String labeling all Book information. */
      public override string ToString()
      {  // code
			string yrs = Convert.ToString (yr);
         return string.Format("{0}"+"\n"+"{1}"+"\n"+"{2}", tit, aut, yrs);
      }

      ////////////////////////////////////
      // Extra credit methods hereafter //
      ////////////////////////////////////

      /** Construct a Book, taking data from reader.
         * Read through three lines that contain the
         * title, author, and year of publication, respectively.
         * There may be an extra blank line at the beginning.
         * If so ignore it.
         * Nothing beyond the line with the year is read. */
      public Book(StreamReader reader)
      {  // code for extra credit!
			int counter = 0;
			
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
						//Book book = new Book(tit, aut, yr);
						list.Addbook(new Book(tit, aut, yr));
						
						 }
			
			Console.WriteLine("\nThe SEMI-AUTO list is:");
			list.PrintList();
			
			
      }

      /** Return true if all the corresponding fields in this Book
         * and in aBook are equal.  Return false otherwise.  */
      public bool Equals(Book aBook)
      {// code for extra credit, before BookList changes
			
			if (aBook.tit == tit && aBook.aut == aut && aBook.yr == yr)
			
         return true; 
			return false;//so skeleton compiles
      }
   }
}
