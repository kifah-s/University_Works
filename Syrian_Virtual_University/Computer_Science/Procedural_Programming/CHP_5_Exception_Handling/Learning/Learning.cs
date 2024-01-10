// See https://aka.ms/new-console-template for more information


//* >>>>> Exception Handling <<<<< *//

/*
//* Errors that can occur in a program written in C# can be classified into "three" categories:

//* 1. The first category is "syntax errors":
//*    These are errors that result from violating the rules of the language and the forms of its commands and formulas.
//*    These errors are always discovered by the compiler and do not move to the implementation stage unless these errors are addressed and corrected.

//* 2. The second category is "logical errors":
//*    These are errors that result from not properly analyzing the issue at hand and building the appropriate algorithm.
//*    Which leads to the program working, but it often gives inaccurate results or behaves undesirable.

//* 3. The third category is "runtime errors":
//*    These are errors that occur at the time of program execution and in some unexpected situations.
//*    Which leads to the program being aborted and stopping its execution.
*/


/*
//* What is the exception?

//* Exception:
//* It is an execution-time error.
//* It is launched as a result of an unexpected problem that causes the program to stop.
*/

/*
//* Example:

//* get numerator
Console.Write("Please enter an integer numerator: ");
int numerator = Convert.ToInt32(Console.ReadLine());

//* get denominator
Console.Write("Please enter an integer denominator: ");
int denominator = Convert.ToInt32(Console.ReadLine());

//* divide the two integers, then display the result
int result = numerator / denominator;
Console.WriteLine("\nResult: {0:D} / {1:D} = {2:D}", numerator, denominator, result);

//* Unexpected situations:
//* 1. If you try to enter a zero value for the denominator variable.
//*    Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.

//* 2. If you try to enter an incorrect value for one of the nominator or denominator variables.
//*    Unhandled exception. System.FormatException: The input string 'hello' was not in a correct format.
*/


