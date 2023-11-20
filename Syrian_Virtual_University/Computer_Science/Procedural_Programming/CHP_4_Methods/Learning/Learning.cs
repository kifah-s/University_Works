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

//! Notes:
//* 1 - The method included three parameters,
//* where the parameters were defined within the method header enclosed in parentheses ( )
//* and the definition of each parameter included specifying its type and name,
//* and the parameters were separated by regular commas.

//* 2 - The value returned by the method is of type int.

//* 3 - All method commands after declaring them are enclosed in block brackets {}.

//* 4 - ▪ The return keyword was used to return the result of the method’s execution (here it is the largest value among three given values).

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

//! Notes:
//* 1 - The method definition did not include any parameter, so the parentheses were left empty,
//* It is never permissible to delete the parentheses when there is no parameter for the method.


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

//! Notes:
//* 1 - This method does not have a return value, so the keyword void is used to indicate this.

//* 2 - deleted the return statement from the method because there is no value resulting from this method to be returned.


//* ...............................


//* Example 4: Defining a method that has no return value and does not have a parameter.

//* printing general welcome message.
static void GeneralWelcomeMsg()
{
    Console.WriteLine("Welcome to Methods in C#");
} //* end method GeneralWelcomeMsg.


//* --------------------------------------------------------------


//* >>>>>>>>>>>>>>>>>>>>> Using functions (calling) <<<<<<<<<<<<<<<<<<<<<<<<<<<<< *//

/*
* 1. The method code is not executed once we define it, but in order for it to be executed, the method must be used,
* which is done by calling it in the place where we want to apply its effect and by using the values on which we want to achieve this effect.

* 2. The method can be called anywhere in the program, whether by the main() method or by any other user-defined method.
*/


/*
* Proper function calling requires focusing on three components:
*   1. The first component is the method name: The method name is used as an identifier to call (call) this method.
*   2. The second component is the parameters: where the values of the method’s parameters are passed so that the following is taken into account:
*       - The number of values passed must be equal to the number of parameters.
*       - The types of values passed must match the types of method parameters.
*       - The order of the values passed must match the order of the method parameters.
*   3. The third component is the return value: we distinguish here between two cases:
*       - In the case of a method that does not return a value (the type of the return value is void),
*         in this case it is sufficient to mention the name of the method and pass values to its parameter correctly,
*         (and it is not permissible to assign it or use it within an arithmetic expression...(etc.)
*       - If a method returns a value (the type of the return value is not void), in this case the call must be made with
*         Proportional to the returned value, i.e. within an assignment expression, an arithmetic or logical expression, or an output instruction.
*/

/*
* - Values can be passed to parameters directly, Maximum(50, 20, 12) or via Maximum(a, b, c) arguments.
* - Calls of this type are called call by value. In this case, copies of the values of the passed arguments are created and given to the method parameter.
*/


//* --------------------------------------------------------------


//* >>>>>>>>>>>>>>>>>>>>> Call methods by reference (by title) <<<<<<<<<<<<<<<<<<<<<<<<<<<<< *//

/*
* - The process of passing the values of the arguments to the method parameters is nothing,
*   but the process of copying the values of these arguments to the method parameters,
*   and therefore any changes that occur to the values of these arguments within the method are not reflected in their values within the calling method.
*/

//* Example:
/*
static int TestValCall(int x)
{
    x++;
    Console.WriteLine("aValue during call : " + x);
    return x;
}

int aValue = 10;
Console.WriteLine("aValue before call : " + aValue);

int bValue = TestValCall(aValue);

Console.WriteLine("aValue after call : " + aValue);
*/

/*
* - We note that the value of the variable aValue remained the same before and after calling the method,
*   noting that this value was increased by 1 within the method. The reason for this is that when called,
*   the value of the parameter aValue is copied to the parameter x,
*   and therefore the changes that occur affect the value of x only and do not The value of aValue is reflected out of the method.
*/


