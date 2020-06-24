using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.IO;

namespace Comp170
{
    class GradeCalc6_10
    {

        public static string InputLine(string prompt)                                               // prompt for input and read line function provided by central planning
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static int IntInput(string prompt)                                                   // return integer function provided by central planning 
        {
            string nStr = InputLine(prompt).Trim();                                                 // Trim removes enclosing blanks
            return int.Parse(nStr);
        }

        public static double DblInput(string prompt)                                                // return double function provided by central planning 
        {
            string nStr = InputLine(prompt).Trim();                                                 // Trim removes enclosing blanks
            return double.Parse(nStr);
        }
                                    
        public static double CalcAvg(int a, int b, int c, int d, int e, double aa, double bb, double cc, double dd, double ee) // calc grade average function provided by the King
        {
            double gradeAvg = (a*aa+b*bb+c*cc+d*dd+e*ee)/100.00;
            return gradeAvg;
        }

        public static void Main()
        {
            int exam_weight, lab_weight, hw_weight, project_weight, participation_weight, totals;   //declare vars
            double exam_grade, lab_grade, homework_grade, project_grade, participation_grade;       //declare vars

            //StreamWriter writer;                                                                  //prep output text file so can have a record besides screen prompt
            //writer = new StreamWriter("grades.txt");
            
            //Console.WriteLine("Enter the INTEGER weight for exams: ");                    
            //string input = Console.ReadLine();
            //try
            //{
            //    exam_weight = int.Parse(input);
            //    Console.WriteLine("You entered {0} for exams.", exam_weight);
            //}
            //catch
            //{
            //    Console.WriteLine("Invalid - Don't type % Sign after number - try typing INTEGER again...");
            //    Console.WriteLine("Enter the INTEGER weight for exams: ");
            //    input = Console.ReadLine();
            //    exam_weight = int.Parse(input);
            //}

            //Console.WriteLine("Enter the INTEGER weight for labs: ");
            //string input2 = Console.ReadLine();
            //try
            //{
            //    lab_weight = int.Parse(input2);
            //    Console.WriteLine("You entered {0} for exams.", lab_weight);
            //}
            //catch
            //{
            //    Console.WriteLine("Invalid - Don't type % Sign after number - try typing INTEGER again...");
            //    Console.WriteLine("Enter the INTEGER weight for labs: ");
            //    input2 = Console.ReadLine();
            //    lab_weight = int.Parse(input2);
            //}

            //Console.WriteLine("Enter the INTEGER weight for homework: ");
            //string input3 = Console.ReadLine();
            //try
            //{
            //    hw_weight = int.Parse(input3);
            //    Console.WriteLine("You entered {0} for exams.", hw_weight);
            //}
            //catch
            //{
            //    Console.WriteLine("Invalid - Don't type % Sign after number - try typing INTEGER again...");
            //    Console.WriteLine("Enter the INTEGER weight for homework: ");
            //    input3 = Console.ReadLine();
            //    hw_weight = int.Parse(input3);
            //}

            //Console.WriteLine("Enter the INTEGER weight for projects: ");
            //string input4 = Console.ReadLine();
            //try
            //{
            //    project_weight = int.Parse(input4);
            //    Console.WriteLine("You entered {0} for exams.", project_weight);
            //}
            //catch
            //{
            //    Console.WriteLine("Invalid - Don't type % Sign after number - try typing INTEGER again...");
            //    Console.WriteLine("Enter the INTEGER weight for projects: ");
            //    input4 = Console.ReadLine();
            //    project_weight = int.Parse(input4);
            //}

            //Console.WriteLine("Enter the INTEGER weight for participation: ");
            //string input5 = Console.ReadLine();
            //try
            //{
            //    participation_weight = int.Parse(input5);
            //    Console.WriteLine("You entered {0} for exams.", participation_weight);
            //}
            //catch
            //{
            //    Console.WriteLine("Invalid - Don't type % Sign after number - try typing INTEGER again...");
            //    Console.WriteLine("Enter the INTEGER weight for projects: ");
            //    input5 = Console.ReadLine();
            //    participation_weight = int.Parse(input5);
            //}

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
                exam_weight = IntInput("Enter the INTEGER weight for exams: ");  
             
            }
            try
            {
                lab_weight = IntInput("Enter the INTEGER weight for labs: ");
                totals = exam_weight + lab_weight;
                Console.WriteLine("You entered {0} for labs and your total so far is {1}.", lab_weight, totals);
            }
            catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try typing INTEGER again...");
                lab_weight = IntInput("Enter the INTEGER weight for labs: ");

            }
            try
            {
                hw_weight = IntInput("Enter the INTEGER weight for homework: ");
                totals = exam_weight + lab_weight + hw_weight;
                Console.WriteLine("You entered {0} for homework and your total so far is {1}.", hw_weight, totals);
            }
            catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try typing INTEGER again...");
                hw_weight = IntInput("Enter the INTEGER weight for homework: ");

            }
            try
            {
                project_weight = IntInput("Enter the INTEGER weight for projects: ");
                totals = exam_weight + lab_weight + hw_weight + project_weight;
                Console.WriteLine("You entered {0} for projects and your total so far is {1}.", project_weight, totals);
            }
            catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try typing INTEGER again...");
                project_weight = IntInput("Enter the INTEGER weight for projects: ");

            }
            try
            {
                participation_weight = IntInput("Enter the INTEGER weight for participation: ");
                totals = exam_weight + lab_weight + hw_weight + project_weight + participation_weight;
                Console.WriteLine("You entered {0} for participation and your total so far is {1}.", participation_weight, totals);
            }
            catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try typing INTEGER again...");
                participation_weight = IntInput("Enter the INTEGER weight for participation: ");

            }        
                
                if (exam_weight + lab_weight + hw_weight + project_weight + participation_weight != 100)        // check that weights add up 100 in do while loop
                {
                    Console.WriteLine("Your weights do not add up to 100 - Pls Input all over again");
                }

            } while (exam_weight + lab_weight + hw_weight + project_weight + participation_weight != 100);    

            Console.WriteLine("Your weights add up to 100 - Proceed"); 
      
            do
            {
                                                                                                                // done with Do WHILE loop now - enter grades and check for right double input format via function call for input/parse                   
            try
            {
                exam_grade = DblInput("Enter the PERCENT (NO % SIGN after number) grade for exams: ");  
                Console.WriteLine("You entered {0} for exams.", exam_grade);
            }
            catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try again...");
                exam_grade = DblInput("Enter the PERCENT (NO % SIGN after number) grade for exams: ");  
             
            }
            try
            {
                lab_grade = DblInput("Enter the PERCENT (NO % SIGN after number) grade for labs: ");  
                Console.WriteLine("You entered {0} for labs.", lab_grade);
            }
            catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try again...");
                lab_grade = DblInput("Enter the PERCENT (NO % SIGN after number) grade for labs: ");  
             
            }
            try
            {
                homework_grade = DblInput("Enter the PERCENT (NO % SIGN after number) grade for homework: ");  
                Console.WriteLine("You entered {0} for homework.", homework_grade);
            }
            catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try again...");
                homework_grade = DblInput("Enter the PERCENT (NO % SIGN after number) grade for homework: ");  
             
            }
             try
            {
                project_grade = DblInput("Enter the PERCENT (NO % SIGN after number) grade for projects: ");  
                Console.WriteLine("You entered {0} for projects.", project_grade);
            }
            catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try again...");
                project_grade = DblInput("Enter the PERCENT (NO % SIGN after number) grade for projects: ");  
             
            }
            try
            {
                participation_grade = DblInput("Enter the PERCENT (NO % SIGN after number) grade for participation: ");  
                Console.WriteLine("You entered {0} for participation.", participation_grade);
            }
            catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try again...");
                participation_grade = DblInput("Enter the PERCENT (NO % SIGN after number) grade for participation: ");  
             
            }
                if (exam_grade + lab_grade + homework_grade + project_grade + participation_grade > 500)        // check that grades do NOT add up to more than 500 (5x100) in do while loop
                {
                    Console.WriteLine("Your grades add up to more than 500...You must really like this student! Try again");
                }

            } while (exam_grade + lab_grade + homework_grade + project_grade + participation_grade > 500);    

            //Console.WriteLine("Enter the PERCENT (NO % SIGN after number) grade for exams: ");                
            //string input6 = Console.ReadLine();
            //try {
            //     = double.Parse(input6);
            //    Console.WriteLine("You entered {0} for exams.", exam_grade); 
            //}
            //catch
            //{
            //    Console.WriteLine("Invalid - Don't type % Sign after number - try again...");
            //    Console.WriteLine("Enter the PERCENT (NO % SIGN after number) grade for exams: ");
            //    input6 = Console.ReadLine();
            //    exam_grade = double.Parse(input6);
            //}

            //Console.WriteLine("Enter the PERCENT (NO % SIGN after number) grade for labs: ");
            //string input7 = Console.ReadLine();
            //try
            //{
            //    lab_grade = double.Parse(input7);
            //    Console.WriteLine("You entered {0} for exams.", lab_grade);
            //}
            //catch
            //{
            //    Console.WriteLine("Invalid - Don't type % Sign after number - try again...");
            //    Console.WriteLine("Enter the PERCENT (NO % SIGN after number) grade for exams: ");
            //    input7 = Console.ReadLine();
            //    lab_grade = double.Parse(input7);
            //}

            //Console.WriteLine("Enter the PERCENT (NO % SIGN after number) grade for homework: ");
            //string input8 = Console.ReadLine();
            //try
            //{
            //    homework_grade = double.Parse(input8);
            //    Console.WriteLine("You entered {0} for exams.", homework_grade);
            //}
            //catch
            //{
            //    Console.WriteLine("Invalid - Don't type % Sign after number - try again...");
            //    Console.WriteLine("Enter the PERCENT (NO % SIGN after number) grade for exams: ");
            //    input8 = Console.ReadLine();
            //    homework_grade = double.Parse(input8);
            //}

            //Console.WriteLine("Enter the PERCENT (NO % SIGN after number) grade for projects: ");
            //string input9 = Console.ReadLine();
            //try
            //{
            //    project_grade = double.Parse(input9);
            //    Console.WriteLine("You entered {0} for exams.", project_grade);
            //}
            //catch
            //{
            //    Console.WriteLine("Invalid - Don't type % Sign after number - try again...");
            //    Console.WriteLine("Enter the PERCENT (NO % SIGN after number) grade for exams: ");
            //    input9 = Console.ReadLine();
            //    project_grade = double.Parse(input9);
            //}
            //Console.WriteLine("Enter the PERCENT (NO % SIGN after number) grade for participation: ");
            //string input10 = Console.ReadLine();
            //try
            //{
            //    participation_grade = double.Parse(input10);
            //    Console.WriteLine("You entered {0} for exams.", participation_grade);
            //}
            //catch
            //{
            //    Console.WriteLine("Invalid - Don't type % Sign after number - try again...");
            //    Console.WriteLine("Enter the PERCENT (NO % SIGN after number) grade for exams: ");
            //    input10 = Console.ReadLine();
            //    participation_grade = double.Parse(input10);
            //}

                                                                                                        
            //double grade = (exam_weight * exam_grade +
             //hw_weight* homework_grade +
             //lab_weight * lab_grade + project_weight * project_grade +
             //participation_weight * participation_grade) / 100.0;


                                                                                                                // call CalcAvg function above to get grade
            double grade=CalcAvg(exam_weight, lab_weight, hw_weight, project_weight, participation_weight, exam_grade, lab_grade, homework_grade, project_grade, participation_grade);
           

            Console.WriteLine("Your grade is {0}%", grade); ;

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
