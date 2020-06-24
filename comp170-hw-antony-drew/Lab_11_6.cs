using System;
using System.IO;

namespace Comp170
{
    class Lab_11_6
    {
        public static void PrintInts(string label, int[] a)
        {

            string label2;
            label2= (label+" "+a[0]+" "+a[1]+" "+a[2]);
			Console.WriteLine("{0}\n",label2);
           

        }

        public static int[] ReadInts(string prompt, int n)
        {

            Console.WriteLine("{0} {1}", prompt,n);
            
            int[] test1 = new int[n];
            for (int i = 0; i < test1.Length; i++)
            {
                string input = Console.ReadLine();
                test1[i] = int.Parse(input);
                
            }
            Console.WriteLine("Your array contains:");
            for (int i = 0; i < test1.Length; i++)
                {
                    Console.WriteLine("{0}",test1[i]);
                }
            return test1;
        }

        public static int Minimum(int[] a)
        {

            int min = a[0];
            
            for (int i = 0; i < a.Length; i++)
            {
                int x = a[i];
                if (x < min)
                {
                    min = x;
                }
                
            }
            Console.WriteLine("\nThe min is: {0}", min);
            return min;

        }

        public static int CountEven(int[] a)
        {

            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                int x = a[i] % 2;
                if (x == 0)
                {
                    
                    count = count +1;
                   
                }

            }
            Console.WriteLine("\nThe number of even numbers in the array is: {0}", count);
            return count;

        }

        public static void PairwiseAdd(int[] a, int[] b, int[] sum)
        {
            Console.WriteLine("\nThe sum of the two arrays is:");
            for (int i = 0; i < a.Length; i++)
            {
                sum[i] = a[i] + b[i];
                Console.WriteLine("{0}", sum[i]);
            }
            

        }

        public static int[] NewPairwiseAdd(int[] a, int[] b, int[] sum)
        {
            Console.WriteLine("\nEnter a new 3-element array:");

            int[] test3 = new int[3];
            for (int i = 0; i < test3.Length; i++)
            {
                string input = Console.ReadLine();
                test3[i] = int.Parse(input);

            }
            b = test3;
            Console.WriteLine("The new sum of the two arrays is:");
            for (int i = 0; i < a.Length; i++)
            {
                sum[i] = a[i] + b[i];
                Console.WriteLine("{0}", sum[i]);
            }

            return sum;
        }

        public static bool IsAscending(int[] a)
        {

            int count=0;

            for (int i = 0; i < a.Length-1; i++)
            {
                
                if (a[i+1] >= a[i])
                {

                    count=count+1;
                    
                }
                
            }
            if (count == a.Length-1){
            Console.WriteLine("\nThis series IS in ascending order!");
            }
            else
            {
                Console.WriteLine("\nThis series is NOT in ascending order!");
            }

            return false;

        }

        public static void PrintAscendingValues(int[] a)
        {

            Console.WriteLine("\nThe parsed series in ascending order is:");
            if (a[0] <= a[1])
            {
                Console.WriteLine("{0}", a[0]);
            }
            for (int i = 0; i < a.Length - 1; i++)
            {

                if (a[i + 1] >= a[i])
                {
                    
                    Console.WriteLine("{0}",a[i+1]);

                }

            }
            
        }

        public static void PrintRuns(int[] a)
        {

            Console.WriteLine("\nThe parsed series of runs in ascending order is:");
            if (a[0] <= a[1])
            {
                Console.WriteLine("{0}", a[0]);
            }
            for (int i = 0; i < a.Length - 1; i++)
            {

                if (a[i + 1] >= a[i])
                {

                    Console.WriteLine("{0}", a[i + 1]);

                }

            }

        }

        public static void VectorDotProduct(double[] a, double[] b, double[] sum)
        {
            double[] sums = new double[3] {0.0, 0.0, 0.0};
            Console.WriteLine("\nThe vector dot product of the two arrays is:");
            for (int i = 0; i < a.Length; i++)
            {
                sum[i] = a[i] * b[i] + sums[i];
                Console.WriteLine("{0}", sum[i]);
                sums[i] = a[i] * b[i];
            }
            Console.WriteLine("The grand total vector dot product of the two arrays is: {0}",sum[0]+sum[1]+sum[2]);

        }

        public static int DigitsToInteger(int[] a)
        {
            int digtoint = 0;
            int conc = 0;
            string add="";
            for (int i = 0; i < a.Length-1; i++)
            {
                add = add + a[i];
                
            }
            conc = int.Parse(add);
            digtoint = 10 * conc + a[a.Length-1];
            Console.WriteLine("\nDigits (of array) to integer is: {0}", digtoint);
            return digtoint;
        }

        public static int DigitsToIntegerBase(int[] a)
        {
            int digtoint = 0;
            int conc = 0;
            string add = "";
            for (int i = 0; i < a.Length - 1; i++)
            {
                add = add + a[i];

            }
            conc = int.Parse(add);
            int max = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                int x = a[i];
                if (x > max)
                {
                    max = x;
                }
            }

            
            digtoint = (max+1) * conc + a[a.Length - 1];
            Console.WriteLine("\nDigits (of array) to integer with base is: {0}", digtoint);
            return digtoint;
        }


        public static void Main()
        {

            int[] test0 = new int[3] {1, 2, 3};
            int[] test2 = new int[3] {2, 3, 4};
            int[] test4 = new int[3];
            int[] sum1 = new int[3];
            int[] test6 = new int[6] {1, 2, 3, 0, 5, 0};
            double[] test7 = new double[3] {1, 2, 3};
            double[] test8 = new double[3] {2, 3, 4};
            double[] sum2 = new double[3];

            PrintInts("Nums:", test0);
            ReadInts("Enter values", 3);
            Minimum(test0);
            CountEven(test0);
            PairwiseAdd(test0, test2, sum1);
            NewPairwiseAdd(test0, test4, sum1);
            IsAscending(test0);
            PrintAscendingValues(test6);
            PrintRuns(test6);
            VectorDotProduct(test7, test8, sum2);
            DigitsToInteger(test0);
            DigitsToIntegerBase(test0);


            Console.ReadLine();

        }
}
}
