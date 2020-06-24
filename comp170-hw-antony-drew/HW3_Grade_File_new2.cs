using System;
using System.IO;

namespace Comp170
{
    class HW3_Grade_File_new2
    {
        // Collect and LIST ALL FUNCTIONS UP HERE FOR CLARITY & CONSISTENCY...
        public static string InputLine(string prompt)                                              // prompt for input and read line function provided by TAs
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static int IntInput(string prompt)                                                  // return integer function provided by TAs 
        {
            string nStr = InputLine(prompt).Trim();                                                
            return int.Parse(nStr);
        }
        public static double DblInput(string prompt, int t)                                               // return double function provided by TAs
        {
            string nStr = InputLine(prompt).Trim();                                                // Trim removes enclosing blanks
            return double.Parse(nStr);
        }
        public static double DblInput(string prompt, double[] n)                                   // return double function of array by me
        {
            double sumss=0;double runs=0;
            for (int i = 0; i < n.Length; i++)
            {
                try
                {
                    Console.Write("\n{0}{1}: ", prompt, i + 1);
                    string input = Console.ReadLine();
                    n[i] = double.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Invalid - Don't type % Sign after number - try again...");
                    Console.Write("\n{0}{1}: ", prompt, i + 1);
                    string input = Console.ReadLine();
                    n[i] = double.Parse(input);
                }
                Console.WriteLine("\nYou entered {0} for grade {1}.", n[i],i+1);
                sumss = sumss + n[i];
                Console.WriteLine("\nThe total grade so far is {0}.", sumss);
                runs = FindAvg(i+1, sumss);
                Console.WriteLine("\nThe simple average of grades so far is {0}.", runs);

                
            }
            return runs;
        }

        public static double FindAvg(int aaa, double aaaa)                                          // calc simple average function by me
        {
            double gradeSimAvg1 = (aaaa) / aaa;
            return gradeSimAvg1;
        }
                    
        public static double CalcWAvg(int a, int b, int c, int d, int e, double aa, double bb, double cc, double dd, double ee) // calc grade average function by me
        {
            double gradeAvg = (a*aa+b*bb+c*cc+d*dd+e*ee)/100.00;
            return gradeAvg;
        }

        public static void Main()
        //public static void Main(string[] args)

        {
            int nums, exam_weight, lab_weight, hw_weight, project_weight, participation_weight, totals;      //declare vars & initialize vars
            double runs,sumy,exam_grade, lab_grade, homework_grade, project_grade, participation_grade;       
            nums = 0; exam_weight = 0; lab_weight = 0; hw_weight = 0; project_weight = 0; participation_weight = 0; totals = 0;
            runs = 0; sumy = 0.0; exam_grade = 0.0; lab_grade = 0.0; homework_grade = 0.0; project_grade = 0.0; participation_grade = 0.0;

            // streamreader - MUSt open and close before streamwriter !!!!


            //StreamWriter writer;                                                                  //prep output text file so can have a record besides screen prompt
            //writer = new StreamWriter("grades.txt");
            
            

            do
            {
                                                                                                    // done with Do WHILE loop now - enter weights and check for right integer input format via function call for input/parse                   
            try
            {
                exam_weight = IntInput("Enter the INTEGER weight for exams: ");
                totals = exam_weight;
                Console.WriteLine("You entered {0} for exams and your total so far is {1}.", exam_weight, totals);
            }
            catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try typing INTEGER again...");
                exam_weight = IntInput("\nEnter the INTEGER weight for exams: ");  
             
            }
            try
            {
                lab_weight = IntInput("\nEnter the INTEGER weight for labs: ");
                totals = exam_weight + lab_weight;
                Console.WriteLine("You entered {0} for labs and your total so far is {1}.", lab_weight, totals);
            }
            catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try typing INTEGER again...");
                lab_weight = IntInput("\nEnter the INTEGER weight for labs: ");

            }
            try
            {
                hw_weight = IntInput("\nEnter the INTEGER weight for homework: ");
                totals = exam_weight + lab_weight + hw_weight;
                Console.WriteLine("You entered {0} for homework and your total so far is {1}.", hw_weight, totals);
            }
            catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try typing INTEGER again...");
                hw_weight = IntInput("\nEnter the INTEGER weight for homework: ");

            }
            try
            {
                project_weight = IntInput("\nEnter the INTEGER weight for projects: ");
                totals = exam_weight + lab_weight + hw_weight + project_weight;
                Console.WriteLine("You entered {0} for projects and your total so far is {1}.", project_weight, totals);
            }
            catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try typing INTEGER again...");
                project_weight = IntInput("\nEnter the INTEGER weight for projects: ");

            }
            try
            {
                participation_weight = IntInput("\nEnter the INTEGER weight for participation: ");
                totals = exam_weight + lab_weight + hw_weight + project_weight + participation_weight;
                Console.WriteLine("You entered {0} for participation and your total so far is {1}.", participation_weight, totals);
            }
            catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try typing INTEGER again...");
                participation_weight = IntInput("\nEnter the INTEGER weight for participation: ");

            }        
                
                if (exam_weight + lab_weight + hw_weight + project_weight + participation_weight != 100)        // check that weights add up 100 in do while loop
                {
                    Console.WriteLine("\nYour weights do not add up to 100 - Pls Input all over again!");
                }

            } while (exam_weight + lab_weight + hw_weight + project_weight + participation_weight != 100);    

            Console.WriteLine("\nYour weights add up to 100 - Proceed");

            
                                                                                                               // done with Do WHILE loop now - enter grades and check for right double input format via function call for input/parse      
                nums = 5;
                for (int i = 1; i <= nums-1; i++)
                {
                    do
                    {
                        try
                        {
                            nums = IntInput("\nEnter the INTEGER for the number of exams: ");
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input - try typing INTEGER again...");
                            nums = IntInput("\nEnter the INTEGER for the number of exams: ");
                        }
                        double[] sum2 = new double[nums];
                        try
                        {

                            runs=DblInput("Enter the PERCENT (NO % SIGN after number) grade for exam ",sum2);
                            exam_grade = runs;
                            
                        }
                        catch
                        {
                            Console.WriteLine("Invalid - Don't type % Sign after number - try again...");
                            runs = DblInput("Enter the PERCENT (NO % SIGN after number) grade for exam ", sum2);

                        }
                        i = 1;
                        try
                        {
                            nums = IntInput("\nEnter the INTEGER for the number of labs: ");
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input - try typing INTEGER again...");
                            nums = IntInput("\nEnter the INTEGER for the number of labs: ");
                        }
                        double[] sum3 = new double[nums];
                        try
                        {
                            runs=DblInput("Enter the PERCENT (NO % SIGN after number) grade for lab ",sum3);
                            lab_grade = runs;
                            
                        }
                        catch
                        {
                            Console.WriteLine("Invalid - Don't type % Sign after number - try again...");
                            runs = DblInput("Enter the PERCENT (NO % SIGN after number) grade for lab ", sum3);

                        }
                        i = 1;
                        try
                        {
                            nums = IntInput("\nEnter the INTEGER for the number of homework assigments: ");
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input - try typing INTEGER again...");
                            nums = IntInput("\nEnter the INTEGER for the number of homework assignments: ");
                        }
                        double[] sum4 = new double[nums];
                        try
                        {
                            runs=DblInput("Enter the PERCENT (NO % SIGN after number) grade for homework ",sum4);
                            homework_grade = runs;
                            
                        }
                        catch
                        {
                            Console.WriteLine("Invalid - Don't type % Sign after number - try again...");
                            runs = DblInput("Enter the PERCENT (NO % SIGN after number) grade for homework ", sum4);

                        }
                        i = 1;
                        try
                        {
                            nums = IntInput("\nEnter the INTEGER for the number of projects: ");
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input - try typing INTEGER again...");
                            nums = IntInput("\nEnter the INTEGER for the number of projets: ");
                        }
                        double[] sum5 = new double[nums];
                        try
                        {
                            runs=DblInput("Enter the PERCENT (NO % SIGN after number) grade for project ",sum5);
                            project_grade = runs;
                            
                        }
                        catch
                        {
                            Console.WriteLine("Invalid - Don't type % Sign after number - try again...");
                            runs = DblInput("Enter the PERCENT (NO % SIGN after number) grade for project ", sum5);

                        }
                        i = 1;
                        try
                        {
                            nums = IntInput("\nEnter the INTEGER for the number of participation/events: ");
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input - try typing INTEGER again...");
                            nums = IntInput("\nEnter the INTEGER for the number of participation/events: ");
                        }
                        double[] sum6 = new double[nums];
                        try
                        {
                            runs=DblInput("Enter the PERCENT (NO % SIGN after number) grade for participation/event ",sum6);
                            participation_grade = runs;
                            
                        }
                        catch
                        {
                            Console.WriteLine("Invalid - Don't type % Sign after number - try again...");
                            runs = DblInput("Enter the PERCENT (NO % SIGN after number) grade for participation/event ", sum6);

                        }
                        
                        sumy = exam_grade + lab_grade + homework_grade + project_grade + participation_grade;
                        if (sumy > 500)                                                                     // check that grades do NOT add up to more than 500 (5x100) in do while loop
                        {
                            Console.WriteLine("\nYour grades add up to more than 500...You must really like this student! Try again!");
                        }

                                            
                    } while (sumy > 500);
                    
                }
                    

            


                                                                                                              // call CalcAvg function above to get grade
                double grade = CalcWAvg(exam_weight, lab_weight, hw_weight, project_weight, participation_weight, exam_grade, lab_grade, homework_grade, project_grade, participation_grade);
           

            Console.WriteLine("\nYour grade is {0}%", grade); ;
            //Console.WriteLine("Your grade is {0}%", grade); writer.WriteLine(grade);

            //if (grade >= 93.0) { Console.WriteLine("A"); writer.WriteLine("A"); }
            //if ((grade >= 90.0) && (grade < 93.0)) { Console.WriteLine("A-"); writer.WriteLine("A-"); }

            if (grade >= 93.0) { Console.WriteLine("A"); }
            if ((grade >= 90.0) && (grade < 93.0)) { Console.WriteLine("A-");  }
            if ((grade >= 87.0) && (grade < 90.0)) { Console.WriteLine("B+"); }
            if ((grade >= 84.0) && (grade < 87.0)) { Console.WriteLine("B");  }
            if ((grade >= 80.0) && (grade < 84.0)) { Console.WriteLine("B-");  }
            if ((grade >= 77.0) && (grade < 80.0)) { Console.WriteLine("C+");  }
            if ((grade >= 74.0) && (grade < 77.0)) { Console.WriteLine("C");  }
            if ((grade >= 70.0) && (grade < 74.0)) { Console.WriteLine("C-");  }
            if ((grade >= 67.0) && (grade < 70.0)) { Console.WriteLine("D+");  }
            if ((grade >= 64.0) && (grade < 67.0)) { Console.WriteLine("D");  }
            if ((grade >= 60.0) && (grade < 64.0)) { Console.WriteLine("D-");  }
            if (grade < 60.0) { Console.WriteLine("FAIL - Back to Summer School - No more beer for you!");  }

            //writer.Close();
            Console.ReadLine();


        }
    }
}
