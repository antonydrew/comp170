using System;

namespace PerfFuncs
{
	public class BinarySearching
   {

      // chunk-binarysearch-begin
      public static int IntArrayBinarySearch(int[] data, int item) {

         int min = 0;
         int N=data.Length;
         int max= N-1;
         do {
            int mid = (min+max) / 2;
            if (item > data[mid])
               min = mid + 1;
            else
               max = mid - 1;
            if (data[mid] == item)
               return mid;
            //if (min > max)
            //   break;
         } while(min <= max);
         return -1;
      }
      // chunk-binarysearch-end

      // chunk-binarysearch-printing-begin
      public static void IntArrayPrint(int[] data, int min, int max) {
         for (int i=0; i < data.Length; i++) {
            if (i >= min && i <= max) {
               string number = data[i] + "";
               for (int j=number.Length; j < 5; j++)
                  number = number + " ";
               Console.Write(number);
            } else
               Console.Write("     ");
         }
         Console.WriteLine();
      }

      public static int IntArrayBinarySearchPrinted(int[] data, int item) {
         int min = 0;
         int N=data.Length;
         int max= N-1;
         IntArrayPrint(data, min, max);
         do {
            int mid = (min+max) / 2;
            Console.WriteLine("min={0} max={1} mid={2}", min, max, mid);
            if (item > data[mid])
               min = mid + 1;
            else
               max = mid - 1;
            IntArrayPrint(data, min, max);
            if (data[mid] == item)
               return mid;
            //if (min > max)
            //   break;
         } while(min <= max);
         return -1;
      }
      // chunk-binarysearch-printing-end


      // chunk-driver-begin
		
	}
}

