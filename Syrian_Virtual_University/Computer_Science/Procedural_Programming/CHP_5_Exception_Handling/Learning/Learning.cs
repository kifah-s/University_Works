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


/*
//* Invalid catch blocks:

//* When an exception is thrown within the try block, the compiler attempts to catch it with sequentially defined catch blocks
//*     Any repetition of catching and handling an exception more than once will mean that the duplicate
//*     catch block is meaningless and will never be executed.
//*     Therefore, the compiler gives an error message in this case.


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
catch //* can not have both catch and catch(Exception ex).
{
    Console.WriteLine("Exception occurred");
}
catch (Exception ex) //* can not have both catch and catch(Exception ex)
{
    Console.WriteLine("Exception occurred");
}

//* Error: Catch clauses cannot follow the general catch clause of a try statement.
//* It means:
//*     1.  The exceptions caught in both catch sections are the same.
//*     2.  The catch block must be without an Exception parameter or with a generic Exception parameter
//*         The last block because it means handling all possible exceptions...
//*         and therefore it must be placed as the last block to be processed
//*         Everything that was not captured by previous blocks.
*/
/*
//* The following example illustrates the last observation:

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
catch (Exception ex) //* can not have both catch and catch(Exception ex)
{
    Console.WriteLine("Exception occurred");
}
catch (FormatException formatException)
{
    Console.WriteLine(formatException.Message);
}
catch (DivideByZeroException divideByZeroException)
{
    Console.WriteLine(divideByZeroException.Message);
}
*/



/*
//*  Nesting try-catch:

//* C# allows writing nested try-catch blocks. When using nested blocks, the exception will be caught by the first catch block,
//*     Trap follows the try block in which the exception occurred.

//* Example:

int divider = 0;

try
{
    try
    {
        int result = 100 / divider;
    }
    catch
    {
        Console.WriteLine("Inner catch");
    }
}
catch
{
    Console.WriteLine("Outer catch");
}

//* Output: Inner catch
*/
/*
//* The following is the modified form of this program that includes this treatment:

int numerator = 1, denominator = 1;
try
{
    try
    {
        //* get numerator
        Console.Write("Please enter an integer numerator: ");
        numerator = Convert.ToInt32(Console.ReadLine());
    }
    catch (FormatException formatException)
    {
        Console.WriteLine("\n" + formatException.Message);
        Console.WriteLine("numerator must be integer. Please try again.\n");
    }

    try
    {
        //* get denominator
        Console.Write("Please enter an integer denominator: ");
        denominator = Convert.ToInt32(Console.ReadLine());
    }
    catch (FormatException formatException)
    {
        Console.WriteLine("\n" + formatException.Message);
        Console.WriteLine("denominator must be integer. Please try again.\n");
    }

    //* divide the two integers, then display the result
    int result = numerator / denominator;
    Console.WriteLine("\nResult: {0:D} / {1:D} = {2:D}", numerator, denominator, result);
}
catch (DivideByZeroException divideByZeroException)
{
    Console.WriteLine("\n" + divideByZeroException.Message);
    Console.WriteLine("Zero is an invalid denominator. Please try again.\n");
}
finally
{
    Console.WriteLine("Re-try with a different numbers.");
}

//* Case 1:
//* Please enter an integer numerator: Hello

//*     The input string 'Hello' was not in a correct format.
//*     numerator must be integer. Please try again.

//* Please enter an integer denominator: 0

//*     Attempted to divide by zero.
//*     Zero is an invalid denominator. Please try again.

//* Re-try with a different numbers.



//* Case 2:
//* Please enter an integer numerator: Hello

//* The input string 'Hello' was not in a correct format.
//* numerator must be integer. Please try again.

//* Please enter an integer denominator: Hello
//* 
//* The input string 'Hello' was not in a correct format.
//* denominator must be integer. Please try again.

//* Result: 1 / 1 = 1
//* Re-try with a different numbers.



//* Case 3:
//* Please enter an integer numerator: 0
//* Please enter an integer denominator: 0

//* Attempted to divide by zero.
//* Zero is an invalid denominator. Please try again.

//* Re-try with a different numbers.


//* Case 4:
//* Please enter an integer numerator: 100
//* Please enter an integer denominator: 7

//* Result: 100 / 7 = 14
//* Re-try with a different numbers.
*/



/*
//* Keyword "throw":

//* C# allows you to define your own exceptions and restrictions and throw exceptions if they are violated.
//* Exceptions can be thrown manually using the throw keyword,
//*     Therefore, any exception derived from the Exception class can be thrown manually using this keyword.

//* Example:

//* Functions ..
static void PrintMark(int m)
{
    if (m < 0)
    {
        throw new Exception("Mark must be positive");
        //* When the "throw keyword" is executed,
        //*     the function is stopped from executing the rest of the commands that follow it.
    }

    Console.WriteLine(m);

}
//* End Functions ..

int mark = -10;
try
{
    PrintMark(mark);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

//* Output: Mark must be positive
*/



/*
//* Predefined exception classes:


//* Exception Class:                                Description:
//* ArgumentException                               Raised when a non-null argument that is passed to a method is invalid.

//* ArgumentNullException                           Raised when null argument is passed to a method.

//* ArgumentOutOfRangeException                     Raised when the value of an argument is outside the range of valid values.

//* DivideByZeroException                           Raised when an integer value is divide by zero.

//* FileNotFoundException                           Raised when a physical file does not exist at the specified location.

//* FormatException                                 Raised when a value is not in an appropriate format to be converted from,
//*                                                 a string by a conversion method such as Parse.

//* IndexOutOfRangeException                        Raised when an array index is outside the lower or upper bounds of an array or collection.

//* InvalidOperationException                       Raised when a method call is invalid in an object's current state.

//* KeyNotFoundException                            Raised when the specified key for accessing a member in a collection is not exists.

//* NotSupportedException                           Raised when a method or operation is not supported.

//* NullReferenceException                          Raised when program access members of null object.

//* OverflowException                               Raised when an arithmetic, casting, or conversion operation results in an overflow.

//* OutOfMemoryException                            Raised when a program does not get enough memory to execute the code.

//* StackOverflowException                          Raised when a stack in memory overflows.

//* TimeoutException                                The time interval allotted to an operation has expired.

//* https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/compiler-generated-exceptions
*/



//* Exercises and activities:

//* 1. Write a program to solve a quadratic equation:
//*    A x2 + B x + C = 0

//* The program asks the user to enter the values A, B, C.
//* The program then shows the roots of the equation, if any, or the phrase “no real roots”.
//* The program must display appropriate messages if the user enters unacceptable values (for example, text instead of numbers).
//* If any problem occurs in the entry, the program will ask the user again about the values so that they can be entered again.
/*
//* Functions ..
static void solveQuadraticEquationFun(double a, double b, double c)
{
    double sel_1 = 0;
    double sel_2 = 0;

    //* Calculate delta value.    
    double delta = b * b - 4 * a * c;
    Console.WriteLine("\nDelta = {0}\n", delta);


    //* Check delta value.    
    if (delta > 0)
    {
        Console.WriteLine("The equation has \"Two Different Solutions ..\"");
        sel_1 = (-b - Math.Sqrt(delta)) / (2 * a);
        sel_2 = (-b + Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine("X = {0}, {1}\n\n", sel_1, sel_2);
    }
    else if (delta == 0)
    {
        Console.WriteLine("The equation has \"Two Similar Solutions ..\"");
        sel_1 = (-b - Math.Sqrt(delta)) / (2 * a);
        sel_2 = (-b + Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine("X = {0}, {1}\n\n", sel_1, sel_2);
    }
    else
    {
        Console.WriteLine("There are \"No Solutions\" to the equation\n\n");
    }


}
//* End Functions ..

//* Welcome massage.
Console.WriteLine("\nWelcome to the program for solving a quadratic equation\n");
Console.WriteLine("Please enter values (A, B, C) ..");

//* Declare variables.
double a = 0, b = 0, c = 0;
bool numOrSen = false;

while (numOrSen == false)
{
    //* Use try-catch. 
    try
    {
        //* Receive value from user.
        Console.Write("A: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("B: ");
        b = double.Parse(Console.ReadLine());

        Console.Write("C: ");
        c = double.Parse(Console.ReadLine());

        numOrSen = true;
    }
    catch
    {
        Console.WriteLine("Please enter a numerical value ..");

        numOrSen = false;
    }
}

solveQuadraticEquationFun(a, b, c);
*/


//* ----------------------------------------------------------


