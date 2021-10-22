/*
	Decision Making Program by Clemente, Eubie Jay using 2D Dimensional Array and For Loops
*/

using System;				
public class Program
{
	public static void Main()
	{
		/* Declaring for 2D Array about Grade Remarks*/
		
	 	string[,] arrRemarks =  new string[,] {
			/* Grade 	Percentage Score 	Remarks*/
            {"1.00", 	"94.8", "100", 		"Excellent"},
            {"1.25", 	"89.2", "94.7", 	"Superior"},
            {"1.50", 	"83.6", "89.1", 	"Very Good"},
            {"1.75", 	"78.0", "83.5", 	"Good"},
            {"2.00", 	"72.4", "77.9", 	"Very Satisfactory"},
            {"2.25", 	"66.8", "72.3", 	"Satisfactory"},
            {"2.50", 	"61.2", "66.7", 	"Average"},
            {"2.75", 	"55.6", "61.1", 	"Fair"},
            {"3.00", 	"50.0", "55.5", 	"Passed"},
            {"5.00", 	"0.0", "49.9", "	Failed"} 
		};
		
		
		// Declaring for userInput 
		double userInput = 0.0;
		
		// Program starts
		Console.Write("Enter Grade: ");
		while(true) // Loop the program incase of invalid inputs need to ask the user again
		{
			if(Double.TryParse(Console.ReadLine(), out userInput)) // Instead of try catch exception I used TryParse function of c# which is more convenient of filtering InputExceptions errors
			{
				// Validation of User Inputs if it's lower 0.0 and greater than 100 then continue
				if(userInput < Convert.ToDouble(arrRemarks[arrRemarks.GetLength(0) - 1, 1]) ^ userInput > Convert.ToDouble(arrRemarks[0, 2])) 
				{
					// Print the Invalid Input only 0.0 to 100 value allowed
					Console.Write("\nInvalid Input! Must be {0} to {1} only!\n\nPlease Enter the Grade again: ", arrRemarks[arrRemarks.GetLength(0) - 1, 1], arrRemarks[0, 2]);
					continue;
				}
				
				// Algorithm start to print the user input remarks
				for(int i = 0; i < arrRemarks.GetLength(0); i++)
				{
					if(userInput >= Convert.ToDouble(arrRemarks[i, 1]) && userInput <= Convert.ToDouble(arrRemarks[i, 2]))
					{
						// Print the output after right remarks
						Console.WriteLine("\n{0} Remarks: {1}", arrRemarks[i, 0], arrRemarks[i, 3]);
						break; // break the loop.
					}
				}
				break; // Stop the program
			}
			else Console.Write("\nInvalid Input!\n\n Please Enter the Grade again: "); // If invalid input loop the program
		}
        
	}
}