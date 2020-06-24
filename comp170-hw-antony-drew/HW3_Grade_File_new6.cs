using System;
using System.IO;

namespace Comp170
{
    public class HW3_Grade_File
    {
        // LIST ALL FUNCTIONS UP HERE FOR CLARITY & CONSISTENCY...
        public static int[] GetIntArray(string input)                                              // get INT array from Professor + I added TRIM()
        {
            string nStr = input.Trim(); 
            string[] parts = nStr.Split(',');
            int[] intparts = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
                intparts[i] = int.Parse(parts[i]);
            return intparts;
        }
        public static string[] GetStringArray(string input)                                        // get string array from Professor + I added TRIM()
        {
            string nStr = input.Trim(); 
            string[] parts = nStr.Split(',');
            return parts;
        }
        public static string[] GetStringArrays(string[,] input, int y, int x)                      // get string array by me - input is now a 2D array (Y x X) & then TRIMMED()
        {
                string stripper = input[y,x];
                string nStr = stripper.Trim();
                string[] parts = nStr.Split(',');
                return parts;
        }
        public static string GetGrade(double[,,] input, int y, int x, int z)                      // get letter grade from 3D double array by me for EXTRA CREDIT #2
        {
            double score = input[y, x, z];
            string[] letter = new string[14] { "A", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F", "F" };
            double[] numeral = new double[14] {200.0,93.0,90.0,87.0,84.0,80.0,77.0,74.0,70.0,67.0,64.0,60.0,59.99,0.0};
            double[] numeral2 = new double[14] { 200.0, 93.0, 90.0, 87.0, 84.0, 80.0, 77.0, 74.0, 70.0, 67.0, 64.0, 60.0, 59.99, 0.0 };
            string grade = "";

            for (int i = 0; i <= 14-2; i++)                                                       // array length - 2 since last row (grade "F") is duplicated anyway  
            {
                if ((score >= numeral2[i + 1]) && (score < numeral[i])) { grade = letter[i + 1]; }
            }
            return grade;
        }
        public static string[,] OneDimTo2Darray(string[] input, int lens1, int lens2)             // 2 for-next loops in same scope to get student info into a 2D array [X x X] matrix so can step diagonally thru duped records and parse/split in subsuquent for loop - this takes longer and more memory so I went with easier solution
        {
             string[,] study = new string[lens2,lens1];
                for (int i = 0; i <= lens1-1; i++) for (int j=0;j<=lens2-1;j++)                    
                {
                    string names = input[i];
                    study[j,i]= names;
                }
            return study;
        }
        public static double FindAvg(double[,,] input, int y, int x, int z, int lens)             // calc simple average from 3D double array input by me
        {
            double score = input[y, x, z];
            double gradeSimAvg1 = score / lens;
            return gradeSimAvg1;
        }
        public static string InputLine(string prompt)                                             // prompt for input and read line function provided by TAs
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
       
                 
        public static void Main(string[] args)
        {
                string course = InputLine("Please type the abbreviated name of the course: ");     // prompt user for course name abbreviation to pass to args[0]
                args = new string[] {course};                                                       
                string line;                                                                        
                                           
                    string[] lines = new string[4];                                                // add 1 to array since always blank row at end of data file in do-while loop via streamreader so [3+1] = 4...Number of rows/columns (for data) could be a dynamic variable via Prompt as well...
                    int counter = 0;

                    try
                    {
                        StreamReader file = new StreamReader("Categories" + args[0] + ".txt");     // get Categories.txt file...test for missing file...
                        try
                        {
                            line = file.ReadLine();
                            do
                            {
                                lines[counter] = line;
                                counter++;

                            } while ((line = file.ReadLine()) != null);

                            file.Close();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            file.Close();
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                Console.WriteLine();
                string cat = lines[0];
                string[] cats = GetStringArray(cat);

                for (int i = 0; i < cats.Length; i++)
                {
                    Console.WriteLine("category at position {0} = {1}", i, cats[i]);
                }

                string wgt = lines[1];
                int[] wgts = GetIntArray(wgt);
                string num = lines[2];
                int[] numi = GetIntArray(num);
                int numic = numi.Length;
                int sumi = 0;

                foreach (int x in numi)                                                                  // "sumi" equals the total number of grades or records
                {
                    sumi = sumi + x;
                }
                
                int lens = cats.Length;
                int counter1 = 0;

                try
                {
                    StreamReader file1 = new StreamReader("Students" + args[0] + ".txt");                // get length of Students.txt file for new array by using counter1...test for missing file...
                    try
                    {
                        line = file1.ReadLine();
                        do
                        {

                            counter1++;

                        } while ((line = file1.ReadLine()) != null);

                        file1.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        file1.Close();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine();
                int lens0 = counter1;
                int col = 3;                                                                          // number columns of student id data provided by professor - this could be dynamic input from user
                int mem = lens0 - 1;                                                                  // number of students as looped thru and counted in .txt file - subtract 1 for blank row at end  
                StreamReader file2 = new StreamReader("Students" + args[0] + ".txt");                 // use number of students (mem) for new array 
                string[,] lines11 = new string[1, mem];
                string[,] student = new string[col, mem];
                int counter2 = 0;

                try                                                                                   // get Student.txt in one-shot: read data into 2D array, store, parse/split and store again in 2D array
                {
                    line = file2.ReadLine();
                    do
                    {

                        lines11[0, counter2] = line;
                        string[] namess = GetStringArrays(lines11, 0, counter2);
                            for (int j = 0; j <= col - 1; j++)
                            {
                                student[j, counter2] = namess[j];
                                Console.WriteLine(student[j, counter2]);
                            }
                        
                        counter2++;
                        
                    } while ((line = file2.ReadLine()) != null && counter2 < mem); 

                    file2.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    file2.Close();
                }

                int lens2 = lines11.Length;
                Console.WriteLine();
                int lens3 = student.Length;
                string[,] lines111 = new string[col, sumi];
                string[,,] grades = new string[col, sumi, mem];
                double[, ,] scores = new double[col, sumi, mem];
                double score = 0.0;
                double[, ,] sumEE = new double[col,sumi,mem] ;
                double[, ,] sumLL = new double[col, sumi, mem];
                double[, ,] sumHH = new double[col, sumi, mem];
                double[, ,] sumPP = new double[col, sumi, mem];
                double[, ,] sumCC = new double[col, sumi, mem];
                               
                try
                {
                    for (int l = 0; l <= mem - 1; l++)                                                          // get Student Grades.txt in one-shot: read data into 2D array, store, parse/split and store again in 3D array...test for missing file
                    {
                        string FileName = student[0, l];
                        StreamReader file3 = new StreamReader(FileName + args[0] + ".dat");
                        int counter3 = 0;
                        try
                        {

                            line = file3.ReadLine();
                            do
                            {

                                lines111[0, counter3] = line;
                                string[] namesss = GetStringArrays(lines111, 0, counter3);
                                for (int j = 0; j <= col - 1; j++)
                                {
                                    grades[j, counter3, l] = namesss[j];
                                    Console.WriteLine(grades[j, counter3, l]);
                                }
                                        if (grades[col-col, counter3, l] == "E")
                                        {
                                            scores[col-col, counter3, l] = 0;
                                            scores[col-2, counter3, l] = 1;
                                            score = Convert.ToDouble(grades[col-1, counter3, l]);
                                            scores[col-1, counter3, l] = (score/numi[0]) * (wgts[0]/100.0);
                                            sumEE[1,counter3, l] = score;
                                        }
                                        else if (grades[col-col, counter3, l] == "L")
                                        {
                                            scores[col-col, counter3, l] = 1;
                                            scores[col-2, counter3, l] = 1;
                                            score = Convert.ToDouble(grades[col-1, counter3, l]);
                                            scores[col-1, counter3, l] = (score / numi[1]) * (wgts[1]/100.0);
                                            sumLL[1, counter3, l] = score;
                                        }
                                        else if (grades[col-col, counter3, l] == "H")
                                        {
                                            scores[col-col, counter3, l] = 2;
                                            scores[col-2, counter3, l] = 1;
                                            score = Convert.ToDouble(grades[col-1, counter3, l]);
                                            scores[col-1, counter3, l] = (score / numi[2]) * (wgts[2]/100.0);
                                            sumHH[1, counter3, l] = score;
                                        }
                                        else if (grades[col-col, counter3, l] == "P")
                                        {
                                            scores[col-col, counter3, l] = 3;
                                            scores[col-2, counter3, l] = 1;
                                            score = Convert.ToDouble(grades[col-1, counter3, l]);
                                            scores[col-1, counter3, l] = (score / numi[3]) * (wgts[3]/100.0);
                                            sumPP[1, counter3, l] = score;
                                        }
                                        else if (grades[col-col, counter3, l] == "C")
                                        {
                                            scores[col-col, counter3, l] = 4;
                                            scores[col-2, counter3, l] = 1;
                                            score = Convert.ToDouble(grades[col-1, counter3, l]);
                                            scores[col-1, counter3, l] = (score / numi[4]) * (wgts[4]/100.0);
                                            sumCC[1, counter3, l] = score;
                                        }
                                
                                counter3++;

                            } while ((line = file3.ReadLine()) != null && counter3 < sumi);

                            file3.Close();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            file3.Close();
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            Console.WriteLine();
            int len6 = scores.Length;
            double summer = 0.0;
            double summer1 = 0.0;
            double summer2 = 0.0;
            double sumE = 0.0;
            double sumL = 0.0;
            double sumH = 0.0;
            double sumP = 0.0;
            double sumC = 0.0;
            double[, ,] summary = new double[col, sumi, mem];
            double[, ,] summarycat = new double[numic, sumi, mem];

            try
            {
                for (int k = 0; k <= mem - 1; k++)                                                      // get sums of each column of grades per student via 2 for/next loops & sums of caetgory of grades for EXTRA CREDIT #1
                {
                    for (int i = 0; i <= sumi - 1; i++)
                    {
                        summer = summer + scores[col - col, i, k];
                        summary[col - col, i, k] = summer;
                        summer1 = summer1 + scores[col - 2, i, k];
                        summary[col - 2, i, k] = summer1;
                        summer2 = summer2 + scores[col - 1, i, k];
                        summary[col - 1, i, k] = summer2;
                        sumE = sumE + sumEE[1, i, k];
                        summarycat[numic - numic, i, k] = sumE;
                        sumL = sumL + sumLL[1, i, k];
                        summarycat[numic - 4, i, k] = sumL;
                        sumH = sumH + sumHH[1, i, k];
                        summarycat[numic - 3, i, k] = sumH;
                        sumP = sumP + sumPP[1, i, k];
                        summarycat[numic - 2, i, k] = sumP;
                        sumC = sumC + sumCC[1, i, k];
                        summarycat[numic - 1, i, k] = sumC;

                    }

                    summer = 0.0;
                    summer1 = 0.0;
                    summer2 = 0.0;
                    sumE = 0.0;
                    sumL = 0.0;
                    sumH = 0.0;
                    sumP = 0.0;
                    sumC = 0.0;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           

                StreamWriter writer;                                                               // prep output text file so can have a record besides screen prompt + EXTRA CREDIT #1 format
                writer = new StreamWriter(args[0] + "Summary" + ".txt");
                Console.WriteLine("Name: Last, First" + "\tAvg" + "  Gr " + "\tE" + "\tL" + "\tH" + "\tP" + "\tC");
                writer.WriteLine("Name: Last, First" + "\tAvg" + "  Gr " + "\tE" + "\tL" + "\tH" + "\tP" + "\tC"); 

                for (int i = 0; i < mem; i++)
                {
                    double exam = FindAvg(summarycat, numic - numic, sumi - 1, i, numi[0]);
                    string rounde = string.Format("{0:0.0}", exam);
                    double lab = FindAvg(summarycat, numic - 4, sumi - 1, i, numi[1]);
                    string roundl = string.Format("{0:0.0}", lab);
                    double homey = FindAvg(summarycat, numic - 3, sumi - 1, i, numi[2]);
                    string roundh = string.Format("{0:0.0}", homey);
                    double part = FindAvg(summarycat, numic - 2, sumi - 1, i, numi[3]);
                    string roundp = string.Format("{0:0.0}", part);
                    double cls = FindAvg(summarycat, numic - 1, sumi - 1, i, numi[4]);
                    string roundc = string.Format("{0:0.0}", cls);
                    string grade = GetGrade(summary, col - 1, sumi - 1, i);
                    string round = string.Format("{0:0.0}", summary[col - 1, sumi - 1, i]);
                    writer.WriteLine(student[col - 2, i] + ", " + student[col - 1, i] + "\t" + round + " " + grade + "\t" + "\t" + rounde + "\t" + roundl + "\t" + roundh + "\t" + roundp + "\t" + roundc);
                    Console.WriteLine(student[col - 2, i] + ", " + student[col - 1, i] + "\t" + round + " " + grade + "\t" + "\t" + rounde + "\t" + roundl + "\t" + roundh + "\t" + roundp + "\t" + roundc);
                   
                }

                writer.WriteLine();           
                writer.Close();
                Console.WriteLine();
                Console.ReadLine();

        }
    }
}
