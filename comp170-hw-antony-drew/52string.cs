using System;

namespace Comp170 {
   class Lab52 {
      public static void getLength() {
          // Prompt the user for the numerator using
          // Console.WriteLine().

	Console.WriteLine("Enter a string so we can test length");
            string input = Console.ReadLine();

	int l=input.Length;
	

	Console.WriteLine("The length of the string is {0} .", l);

          // Convert this text into int numerator using
          // int.Parse().




          // Do the same for the denominator.





          // Calculate quotient and remainder (as integers)
          // Use Console.WriteLine() to make the results pretty as
          // above.




          // Do the same but using floating point division and not
          // doing the remainder calculation.

      }


	public static void typeSentence() {
          // Prompt the user for the numerator using
          // Console.WriteLine().

	Console.WriteLine("Write a sentence with ");
            string input = Console.ReadLine();

	int l=input.Length;
	char last = input[l-1];

		if (last == '?')
		{
		Console.WriteLine("This sentence is a question "); 
		}
	
		if (last == '!')
		{
		Console.WriteLine("This sentence is an exclamation "); 
		}

		if (last == '.')
		{
		Console.WriteLine("This sentence is a sentence "); 
		}

	//Console.WriteLine("The length of the string is {0} .", l);

          // Convert this text into int numerator using
          // int.Parse().




          // Do the same for the denominator.





          // Calculate quotient and remainder (as integers)
          // Use Console.WriteLine() to make the results pretty as
          // above.




          // Do the same but using floating point division and not
          // doing the remainder calculation.

      }



public static void main() {
          // Prompt the user for the numerator using
          // Console.WriteLine().

	

	Console.WriteLine("You entered for exams.");
	
   }
}
