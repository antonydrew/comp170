using System;

namespace PerfFuncs
{
	public class Searching
   {

      // chunk-linearsearch-begin
      public static int IntArrayLinearSearch(int[] data, int item) {
         int N=data.Length;
         for (int i=0; i < N; i++)
            if (data[i] == item)
               return i;
         return -1;
      }
      // chunk-linearsearch-end

      // chunk-linearsearchfrom-begin
      public static int IntArrayLinearSearch(int[] data, int item, int start) {
         int N=data.Length;
         if (start < 0)
            return -1;
         for (int i=start; i < N; i++)
            if (data[i] == item)
               return i;
         return -1;
      }
      // chunk-linearsearchfrom-end

      // chunk-driver-begin
		
		
	}
}

