using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.IO;

namespace Comp170
{
    class Lab7_10
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
                                    
        

        public static void Main()
        {
            int guess, big, count;   //declare vars
            //double exam_grade, lab_grade, homework_grade, project_grade, participation_grade;       //declare vars

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
			big = 100;
			count=0;
			Random r = new Random();
			int secret = r.Next(1, big);

            do
            {
                                                                                                            // done with Do WHILE loop now - enter weights and check for right integer input format via function call for input/parse                   
           
                guess = IntInput("Guess a number from 1 to 100");
                count=count+1;
                Console.WriteLine("You entered {0}.", guess);
           
                if (guess > secret)        // check that grades do NOT add up to more than 500 (5x100) in do while loop
                {
                    Console.WriteLine("You guessed too high - try again goofy!");
                }
				else if (guess < secret)
				{
					Console.WriteLine("You guessed too low - try again goofy!");
                }	
				else
				{
					Console.WriteLine("You guessed correct - you do have some brain cells left after all! Thank God!");
                }		
            } while (guess != secret);    

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


              
            Console.ReadLine();


        }
    }
}
