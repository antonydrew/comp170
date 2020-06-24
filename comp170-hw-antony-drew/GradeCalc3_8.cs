using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.IO;

namespace GradeCalc3_8
{
    class GradeCalc3_8
    {
        public static void Main()
        {
            int exam_weight, lab_weight, hw_weight, project_weight, participation_weight;           //declare vars
            double exam_grade, lab_grade, homework_grade, project_grade, participation_grade;       //declare vars


            Console.WriteLine("Enter the INTEGER weight for exams: ");                              //enter weights and check for right integer input format
            string input = Console.ReadLine();
            try
            {
                exam_weight = int.Parse(input);
                Console.WriteLine("You entered {0} for exams.", exam_weight);
            }
            catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try typing INTEGER again...");
                Console.WriteLine("Enter the INTEGER weight for exams: ");
                input = Console.ReadLine();
                exam_weight = int.Parse(input);
            }

            Console.WriteLine("Enter the INTEGER weight for labs: ");
            string input2 = Console.ReadLine();
            try
            {
                lab_weight = int.Parse(input2);
                Console.WriteLine("You entered {0} for exams.", lab_weight);
            }
            catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try typing INTEGER again...");
                Console.WriteLine("Enter the INTEGER weight for labs: ");
                input2 = Console.ReadLine();
                lab_weight = int.Parse(input2);
            }

            Console.WriteLine("Enter the INTEGER weight for homework: ");
            string input3 = Console.ReadLine();
            try
            {
                hw_weight = int.Parse(input3);
                Console.WriteLine("You entered {0} for exams.", hw_weight);
            }
            catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try typing INTEGER again...");
                Console.WriteLine("Enter the INTEGER weight for homework: ");
                input3 = Console.ReadLine();
                hw_weight = int.Parse(input3);
            }

            Console.WriteLine("Enter the INTEGER weight for projects: ");
            string input4 = Console.ReadLine();
            try
            {
                project_weight = int.Parse(input4);
                Console.WriteLine("You entered {0} for exams.", project_weight);
            }
            catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try typing INTEGER again...");
                Console.WriteLine("Enter the INTEGER weight for projects: ");
                input4 = Console.ReadLine();
                project_weight = int.Parse(input4);
            }

            Console.WriteLine("Enter the INTEGER weight for participation: ");
            string input5 = Console.ReadLine();
            try
            {
                participation_weight = int.Parse(input5);
                Console.WriteLine("You entered {0} for exams.", participation_weight);
            }
            catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try typing INTEGER again...");
                Console.WriteLine("Enter the INTEGER weight for projects: ");
                input5 = Console.ReadLine();
                participation_weight = int.Parse(input5);
            }


                if (exam_weight+lab_weight+hw_weight+project_weight+participation_weight != 100)    //check that weights add up 100
                    { 
                    Console.WriteLine("Your weights do not add up to 100 - Pls Input again"); 
                    Console.WriteLine("Enter the INTEGER weight for exams: ");
                    input = Console.ReadLine();
                    exam_weight = int.Parse(input);
                    Console.WriteLine("You entered {0} for exams.", exam_weight);

                    Console.WriteLine("Enter the INTEGER weight for labs: ");
                    input2 = Console.ReadLine();
                    lab_weight = int.Parse(input2);
                    Console.WriteLine("You entered {0} for exams.", lab_weight);

                    Console.WriteLine("Enter the INTEGER weight for homework: ");
                    input3 = Console.ReadLine();
                    hw_weight = int.Parse(input3);
                    Console.WriteLine("You entered {0} for exams.", hw_weight);

                    Console.WriteLine("Enter the INTEGER weight for projects: ");
                    input4 = Console.ReadLine();
                    project_weight = int.Parse(input4);
                    Console.WriteLine("You entered {0} for exams.", project_weight);

                    Console.WriteLine("Enter the INTEGER weight for participation: ");
                    input5 = Console.ReadLine();
                    participation_weight = int.Parse(input5);
                    Console.WriteLine("You entered {0} for exams.", participation_weight); 
                    }
                else 
                    {   
                    Console.WriteLine("Your weights add up to 100 - Proceed"); 
                    }

            Console.WriteLine("Enter the PERCENT (NO % SIGN after number) grade for exams: ");      //begin to enter grades and check for right input format
            string input6 = Console.ReadLine();
            try {
                exam_grade = double.Parse(input6);
                Console.WriteLine("You entered {0} for exams.", exam_grade); 
            }
            catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try again...");
                Console.WriteLine("Enter the PERCENT (NO % SIGN after number) grade for exams: ");
                input6 = Console.ReadLine();
                exam_grade = double.Parse(input6);
            }

            Console.WriteLine("Enter the PERCENT (NO % SIGN after number) grade for labs: ");
            string input7 = Console.ReadLine();
            try
            {
                lab_grade = double.Parse(input7);
                Console.WriteLine("You entered {0} for exams.", lab_grade);
            }
            catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try again...");
                Console.WriteLine("Enter the PERCENT (NO % SIGN after number) grade for exams: ");
                input7 = Console.ReadLine();
                lab_grade = double.Parse(input7);
            }

            Console.WriteLine("Enter the PERCENT (NO % SIGN after number) grade for homework: ");
            string input8 = Console.ReadLine();
            try
            {
                homework_grade = double.Parse(input8);
                Console.WriteLine("You entered {0} for exams.", homework_grade);
            }
            catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try again...");
                Console.WriteLine("Enter the PERCENT (NO % SIGN after number) grade for exams: ");
                input8 = Console.ReadLine();
                homework_grade = double.Parse(input8);
            }

            Console.WriteLine("Enter the PERCENT (NO % SIGN after number) grade for projects: ");
            string input9 = Console.ReadLine();
            try
            {
                project_grade = double.Parse(input9);
                Console.WriteLine("You entered {0} for exams.", project_grade);
            }
            catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try again...");
                Console.WriteLine("Enter the PERCENT (NO % SIGN after number) grade for exams: ");
                input9 = Console.ReadLine();
                project_grade = double.Parse(input9);
            }
            Console.WriteLine("Enter the PERCENT (NO % SIGN after number) grade for participation: ");
            string input10 = Console.ReadLine();
            try
            {
                participation_grade = double.Parse(input10);
                Console.WriteLine("You entered {0} for exams.", participation_grade);
            }
            catch
            {
                Console.WriteLine("Invalid - Don't type % Sign after number - try again...");
                Console.WriteLine("Enter the PERCENT (NO % SIGN after number) grade for exams: ");
                input10 = Console.ReadLine();
                participation_grade = double.Parse(input10);
            }

                                                                                                    //calc grades
            double grade = (exam_weight * exam_grade +
             hw_weight* homework_grade +
             lab_weight * lab_grade + project_weight * project_grade +
             participation_weight * participation_grade) / 100.0;

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
            //Console.ReadLine();


        }
    }
}
