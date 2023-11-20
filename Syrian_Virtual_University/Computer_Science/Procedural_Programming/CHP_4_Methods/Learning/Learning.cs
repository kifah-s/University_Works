// See https://aka.ms/new-console-template for more information




//* >>>>>>>>>>>>>>>>>>>>>>>> Methods <<<<<<<<<<<<<<<<<<<<<<<<<<<< *//


//! " divide and conquer ".

//* Dividing the issue at hand into a number of partial issues.

//* pre-defined methods ... AND  ... user-defined methods.

//* Function -> A locked box.


//* --------------------------------------------------------------


//* >>>>>>>>>>> pre-defined methods <<<<<<<<<<<<<< *//

//* Examples: ReadLine, WriteLine, Parse ..... etc.

//* >>>> Category Math <<<< *//

//* Example 1:
/*
const double C = 900.0;
double x = 16.0;
double c = 13.0, d = 3.0, f = 4.0;
Console.WriteLine(Math.Sqrt(C));
Console.WriteLine(Math.Sqrt(x));
Console.WriteLine(Math.Sqrt(c + d * f));
*/


//* Example 2:
/*
double x, y, min, max;
Console.WriteLine("Please enter two numbers: ");
x = double.Parse(Console.ReadLine());
y = double.Parse(Console.ReadLine());
max = Math.Max(x, y);
min = Math.Min(x, y);
Console.WriteLine("Max of {0} and {1} is {2}", x, y, max);
Console.WriteLine("Min of {0} and {1} is {2}", x, y, min);
*/



//* The most important methods of the Math class:

//! Abs(x)
//* The absolute value of x.
//* Examples:
//* Abs( 23.7 ) is 23.7
//* Abs( 0 ) is 0
//* Abs( -23.7 ) is 23.7


//! Ceiling(x)
//* Rounding to the smallest natural number not smaller than x.
//* Examples:
//* Cos(0.0) is 1.0


//! Floor(x)
//* Round to the largest natural number not greater than x.
//* Examples:
//* Floor( 9.2 ) is 9.0
//* Floor( -9.8 ) is -10.0


//! Cos(x)
//* Examples:
//* Cos( 0.0 ) is 1.0


//! Sin(x)
//* Examples:
//* Sin( 0.0 ) is 0.0


//! Exp(x)
//* Raising to the power of number e.
//* Examples:
//* Exp( 1.0 ) is approximately .. 2.7182818284590451
//* Exp( 2.0 ) is approximately .. 7.3890560989306504


//! Log(x)
//* The natural logarithm of x (base e).
//* Examples:
//* Log( 2.7182818284590451 ) .. is approximately 1.0
//* Log( 7.3890560989306504 ) .. is approximately 2.0


//! Max(x, y)
//* Largest value.
//* Examples:
//* Max( 2.3, 12.7 ) is 12.7
//* Max( -2.3, -12.7 ) is -2.3


//! Min(x, y)
//* Smallest value.
//* Examples:
//* Min( 2.3, 12.7 ) is 2.3
//* Min( -2.3, -12.7 ) is -12.7


//! Pow(x, y)
//* x raised to the power y.
//* Examples:
//* Pow( 2.0, 7.0 ) is 128.0
//* Pow( 9.0, .5 ) is 3.0


//! Sqrt(x)
//* The square root of x.
//* Examples:
//* Sqrt( 900.0 ) is 30.0
//* Sqrt( 9.0 ) is 3.0


//* --------------------------------------------------------------


//* >>>>>>>>> Definition of methods <<<<<<<<< *//

//* The concept of method (function or procedure) in the C# language is derived from the concept of method in mathematics.
//* The function can be defined mathematically as a relationship that links one or more elements of the source set to one element of the destination set.

//* The method can be defined using the following general formula:

/*
access_qualifier return_type method_name(parameter_declaration_list)
{
    statement_list
    return return_value;
}
*/

//* where:
//* Access_qualifier: expresses the method of calling the method and the permission to access it.
//* return_type: is the type of value returned or returned by the method.
//* method_name: is an identifier that identifies the name of the method.
//* Parameter_declaration_list: is a list of method parameter declarations separated by commas.
//* statement_list: A sequence of statements and commands that describe the behavior of a method.
//* return_value: The value that the method returns.
//* return is a keyword whose function is to terminate the method and return the resulting value.



//* A collection of examples of defining methods in different forms:

//* Example 1: Defining a method that has a return value and has one or more parameters:
/*
//* returns the maximum of its three integer parameters.
static int Maximum(int x, int y, int z)
{
    int maximumValue = x; //* assume x is the largest to start

    //* determine whether y is greater than maximumValue.
    if (y > maximumValue)
    {
        maximumValue = y;
    }

    //* determine whether z is greater than maximumValue.
    if (z > maximumValue)
    {
        maximumValue = z;
    }

    return maximumValue;

} // end method Maximum

Console.WriteLine("The Maximum number is: " + Maximum(10, 5, 2));
*/


//* ...............................


//* Example 2: Defining a method that has a return value and no parameters.
/*
//* returns the sum of values within range 1 to 50.
static int SumInterval()
{
    int sum = 0;
    for (int i = 1; i < 50; i++)
    {
        sum += i;
    }

    return sum;
} //* end method SumInterval.

Console.WriteLine("Sum = " + SumInterval());
Console.WriteLine($"Sum = {SumInterval()}");
*/


//* ...............................


//* Example 3: Defining a method that has no return value and has one or more parameters
/*
//* printing welcome message.
static void WelcomeMsg(string name)
{
    Console.WriteLine("Welcome {0} to Methods in C# ", name);
} //* end method WelcomeMsg.

WelcomeMsg("kifah");
*/


//* printing welcome message.
/*
static void WelcomeMsg(string name)
{
    Console.WriteLine($"Welcome {name} to Methods in C# ");
} //* end method WelcomeMsg.

WelcomeMsg("kifah");
*/

//* ...............................
