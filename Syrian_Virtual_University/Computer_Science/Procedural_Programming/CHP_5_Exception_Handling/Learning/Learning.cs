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

//* Case 1: 100 / 7
//*     Result: 100 / 7 = 14

//* Case 2: 100 / 0
//*     Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.

//* Case 3: 100 / Hello
//*     Unhandled exception. System.FormatException: The input string 'hello' was not in a correct format.

//* Unexpected situations:
//* 1. If you try to enter a zero value for the denominator variable.
//*     DivideByZeroException

//* 2. If you try to enter an incorrect value for one of the nominator or denominator variables.
//*     FormatException
*/


/*
//* Catch and handle exceptions:

//* Exceptions must be handled to prevent the program from stopping unexpectedly,
//*     Record the error and "follow up" on the implementation of the rest of the tasks.

//* C# provides a solution to catch and handle exceptions,
//*     It is represented by the (try catch finally) structure, which has the following general form:

try
{
    //* put the code here that may raise exceptions
}
catch
{
    //* handle exception here
}
finally
{
    //* final cleanup code
}

//* try block: Any code that is suspected of potentially throwing an exception should be placed inside a try block.
//*     During execution, if an exception occurs, control flow jumps to the first matching catch block.

//* catch block: It is an exception handler block where you can perform some actions such as logging and auditing an exception.
//*     The catch block takes an exception type parameter from which you can get the details of an exception.

//* finally block: The finally block will always be executed whether an exception is raised or not. Normally,
//*     the finally block should be used to release resources, For example, to close any stream or files that were opened in the try block.

//* Note: The finally block is optional and can be omitted and must come after the try and catch blocks.
*/


/*
//* Example:

try
{
    //* get numerator
    Console.Write("Please enter an integer numerator: ");
    int numerator = Convert.ToInt32(Console.ReadLine());

    //* get denominator
    Console.Write("Please enter an integer denominator: ");
    int denominator = Convert.ToInt32(Console.ReadLine());

    //* divide the two integers, then display the result
    int result = numerator / denominator;
    Console.WriteLine("\nResult: {0:D} / {1:D} = {2:D}", numerator, denominator, result);
}
catch
{
    Console.WriteLine("Error occurred");
}
finally
{
    Console.WriteLine("Re - try with a different numbers");
}

//* Case 1: 100 / 7
//*     Result: 100 / 7 = 14
//*     Re - try with a different numbers

//* Case 2: 100 / 0
//*     Error occurred
//*     Re - try with a different numbers

//* Case 3: 100 / Hello
//*     Error occurred
//*     Re - try with a different numbers

//* Notes:
//* 1.  The finally block is executed in all cases.
//* 2.  The program went to the catch block and executed its contents every time an exception occurred.
*/


/*
//* In previous cases in which the exception occurred, we were not able to distinguish what the exception was,
//*     and we were satisfied with knowing that an error had occurred.
//*     Standardly, the catch block must include a parameter from the predefined exception class
//*     (or from a user-defined class) to get the details of the error.


//* Example:

try
{
    //* get numerator
    Console.Write("Please enter an integer numerator: ");
    int numerator = Convert.ToInt32(Console.ReadLine());

    //* get denominator
    Console.Write("Please enter an integer denominator: ");
    int denominator = Convert.ToInt32(Console.ReadLine());

    //* divide the two integers, then display the result
    int result = numerator / denominator;
    Console.WriteLine("\nResult: {0:D} / {1:D} = {2:D}", numerator, denominator, result);
}
catch(Exception ex)
{
    Console.WriteLine("Error occurred, " + ex.Message);
}
finally
{
    Console.WriteLine("Re - try with a different numbers");
}

//* Case 1: 100 / 7
//*     Result: 100 / 7 = 14
//*     Re - try with a different numbers

//* Case 2: 100 / 0
//*     Error occurred, Attempted to divide by zero.
//*     Re - try with a different numbers

//* Case 3: 100 / Hello
//*     Error occurred, The input string 'Hello' was not in a correct format.
//*     Re - try with a different numbers



//* By re-experiencing the previous exception cases,
//*     we notice that the output differed and each time we were
//*     presented with a description of the exception that was caught.

//* Here we used the Message attribute of the Exception class to display the exception description.
*/


/*
//* Looking at the last example, we note that the same handling will occur for all exceptions that are caught by the program,
//*     What if we wanted to write a different handler for each type of exception? In this case, we could write more than one
//*     catch and each block uses a parameter of a custom type of exception.

//* Example:

try
{
    //* get numerator
    Console.Write("Please enter an integer numerator: ");
    int numerator = Convert.ToInt32(Console.ReadLine());

    //* get denominator
    Console.Write("Please enter an integer denominator: ");
    int denominator = Convert.ToInt32(Console.ReadLine());

    //* divide the two integers, then display the result
    int result = numerator / denominator;
    Console.WriteLine("\nResult: {0:D} / {1:D} = {2:D}", numerator, denominator, result);
}
catch (DivideByZeroException divideByZeroException)
{
    Console.WriteLine("\n" + divideByZeroException.Message);
    Console.WriteLine("Zero is an invalid denominator. Please try again.");
}
catch (FormatException formatException)
{
    Console.WriteLine("\n" + formatException.Message);
    Console.WriteLine("You must enter two integers. Please try again.");
}
finally
{
    Console.WriteLine("Re - try with a different numbers");
}

//* Case 1: 100 / 7
//*     Result: 100 / 7 = 14
//*     Re - try with a different numbers

//* Case 2: 100 / 0
//*     Attempted to divide by zero.
//*     Zero is an invalid denominator. Please try again.
//*     Re - try with a different numbers

//* Case 3: 100 / Hello
//*     he input string 'Hello' was not in a correct format.
//*     You must enter two integers. Please try again.
//*     Re - try with a different numbers
*/
