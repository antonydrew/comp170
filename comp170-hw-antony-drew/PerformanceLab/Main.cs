using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;

namespace PerfFuncs
{
   public class PerformanceLab
   {
      // chunk-experiment1-begin
      public static long ExperimentIntArrayLinearSearch (int n, int rep, int seed)
      {
         Stopwatch watch = new Stopwatch ();
         int[] data = new int[n];
         Sorting.IntArrayGenerate (data, seed);
         watch.Reset ();       
         watch.Start ();
         int m = Math.Max(1, n/rep);
         // perform the rep lookups
         for (int k=0, i=0; k < rep; k++, i=(i+m)%n) {
            Searching.IntArrayLinearSearch (data, data [i]);
         }
         watch.Stop ();
         return watch.ElapsedMilliseconds;
      }
      // chunk-experiment1-end
    
      public static long ExperimentIntArrayBinarySearch (int n, int rep, int seed)
      {
         Stopwatch watch = new Stopwatch ();
         int[] data = new int[n];
         Sorting.IntArrayGenerate (data, seed);
         /* Use our existing work on sorting to generate sorted array for testing */
         Sorting.IntArrayQuickSort (data);
         watch.Reset ();       
         watch.Start ();
         int m = Math.Max(1, n/rep);
         // perform the rep lookups
         for (int k=0, i=0; k < rep; k++, i=(i+m)%n) {
            BinarySearching.IntArrayBinarySearch (data, data [i]);
         }
         watch.Stop ();
         return watch.ElapsedMilliseconds;
      }
          
      public static long ExperimentListSearch (int n, int rep, int seed)
      {
         Stopwatch watch = new Stopwatch ();
         int[] data = new int[n];
         Sorting.IntArrayGenerate (data, seed);
         List<int> dataAsList = new List<int> (data);
         watch.Reset ();       
         watch.Start ();
         int m = Math.Max(1, n/rep);
         // perform the rep lookups
         for (int k=0, i=0; k < rep; k++, i=(i+m)%n) {
            dataAsList.Contains(data [i]);
         }
         watch.Stop ();
         return watch.ElapsedMilliseconds;
      }

      public static long ExperimentSetSearch (int n, int rep, int seed)
      {
         var watch = new Stopwatch ();
         var data = new int[n];
         Sorting.IntArrayGenerate (data, seed);         
         var myset = new HashSet<int> (data);
         watch.Reset ();       
         watch.Start ();
         int m = Math.Max(1, n/rep);
         // perform the rep lookups
         for (int k=0, i=0; k < rep; k++, i=(i+m)%n) {
            myset.Contains(data [i]);
         }
         watch.Stop ();
         return watch.ElapsedMilliseconds;
      }
    
		public static string InputLine(string prompt)                                               
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static int IntInput(string prompt)                                                   
        {
            string nStr = InputLine(prompt).Trim();                                                 
            return int.Parse(nStr);
        }
		
      public static void Main (string[] args)
      {
			string rep, iter;
			int ns = 0;
			long time1 = 0000000;
			long time2 = 0000000;
			long time3 = 0000000;
			long time4 = 0000000;
			
			
			try 
			{
			rep = InputLine("Please type the number of reps as an integer: ");     					// prompt user for reps to pass to args[0]
			}
			catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try typing INTEGER again...");
                rep = InputLine("Please type the number of reps as an integer: ");   
            }
			
			try
			{
			ns = IntInput ("For how many sets of 'n' do you want to run the optimization? Enter int val: ");
			}
			catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try typing INTEGER again...");
                ns = IntInput ("For how many sets of iterations 'n' do you want to run the optimization? Enter integer value: ");
            }
			
			string[,] mns = new string[1,ns];
			
			for (int i = 0; i <= ns - 1; i++) 
			{	
			try
			{
				iter = InputLine("Please type the number of iterations 'n' as an integer for set " + (i+1) + ": ");     	// prompt user for iter n to pass to args[1]
				mns[0,i] = iter;
			}
			catch
			{
                Console.WriteLine("Invalid - Don't type % Sign after number - try typing INTEGER again...");
                iter = InputLine("Please type the number of iterations 'n' as an integer for set " + (i+1) + ": "); 
				mns[0,i] = iter;
            }
			}
			
			long[,] time1store = new long[1,ns];
			long[,] time2store = new long[1,ns];
			long[,] time3store = new long[1,ns];
			long[,] time4store = new long[1,ns];
			int[,] storen = new int[1,ns];
			
			for (int i = 0; i <= ns - 1; i++) 
			{
            args = new string[] {rep,mns[0,i]};       
			int n = Convert.ToInt32(args[1]);
			storen[0,i]=n;
			int reps = Convert.ToInt32(args[0]);
			int seed = 0;
			time1 = ExperimentIntArrayLinearSearch (n, reps, seed);
			time2 = ExperimentIntArrayBinarySearch (n, reps, seed);
			time3 = ExperimentListSearch (n, reps, seed);	
			time4 = ExperimentSetSearch (n, reps, seed);		
			time1store[0,i] = time1;
			time2store[0,i] = time2;
			time3store[0,i] = time3;
			time4store[0,i] = time4;
			Console.WriteLine(time1store[0,i]);
			Console.WriteLine(time2store[0,i]);
			Console.WriteLine(time3store[0,i]);
			Console.WriteLine(time4store[0,i]);
			}
         // Write the code to parse args for the parameters
         // rep n1 n2 n3 ...
       
			StreamWriter writer;                                                               // prep output text file so can have a record besides screen prompt 
                writer = new StreamWriter("Perf Summary" + ".txt");
                Console.WriteLine("n" + "\trep" + "\tlinear" + "\tbinary" + "\tlist" + "\tset");
                writer.WriteLine("n" + "\trep"  + "\tlinear" + "\tbinary" + "\tlist" + "\tset"); 

                for (int i = 0; i < ns; i++)
                {
                   
                    writer.WriteLine(storen[0, i] + "\t" + Convert.ToInt32(args[0]) + "\t" + time1store[0,i] + "\t" + time2store[0,i]  + "\t" + time3store[0,i]  + "\t" + time4store[0,i]);
                    Console.WriteLine(storen[0,i] + "\t" + Convert.ToInt32(args[0]) + "\t" + time1store[0,i] + "\t" + time2store[0,i]  + "\t" + time3store[0,i]  + "\t" + time4store[0,i]);
                   
                }

                writer.WriteLine();           
                writer.Close();
                Console.WriteLine();
                Console.ReadLine();
			
         
      }
   }
}
