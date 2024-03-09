// See https://aka.ms/new-console-template for more information

using System.Linq;


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
/*
//* printing general welcome message.
static void GeneralWelcomeMsg()
{
    Console.WriteLine("Welcome to Methods in C#");
} //* end method GeneralWelcomeMsg.
*/

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


/*
* This type of calling of methods is called call by value and is summarized as follows:
*   ▪ In this case, a copy of the value of the variable passed as a parameter is passed to the method.
*   ▪ This variable will not be affected by any modifications made by the method to the parameter in the body of the method.
*/

/*
* - It sometimes happens that the nature of the issue requires that changes in the values of the mediators inside the method be reflected
*   in their values outside the method.

* - The call by reference method is summarized as follows:
*       ▪ In this case, the variable reference (address) passed as a parameter to the method.
*       ▪ This variable is affected by any modifications the method makes to the parameter in the body of the method.
*       ▪ The variable passed must be initialized (have a value).



* - The reference to a variable means the address of the memory location occupied by this variable,
*   The reference to a variable is expressed by placing the ref keyword before declaring this variable.

* - In the case of calling by reference, the memory address of the argument is passed to the method parameter,
*   and thus this is equivalent to giving the argument an alternative name, alias, which is the name of the parameter.
*/


//* Example:
/*
static int TestRefCall(ref int x)
{
    x++;
    
    Console.WriteLine("aValue during call :" + x);

    return x;
}

int aValue = 10;
Console.WriteLine("aValue before call :" + aValue);
int bValue = TestRefCall(ref aValue);
Console.WriteLine("aValue after call :" + aValue);
*/

/*
! Important Notes:
! - Call by value = Call by a "COPY" from variable value.
! - Call by reference = Call by variable "index".
*/

/*
* Many programmers prefer to use the call-by-reference method rather than the return-value method to obtain the result of method execution,
* (especially when there is a need for the method to calculate more than one result value).
* For this reason, in the C# language, a special case of calling by reference can be used, which is the case of using the output operator out.
* This can be summarized as follows:
*   ▪ In this case, the variable reference (address) passed as a parameter is passed to the method.
*   ▪ This variable is affected by any modifications the method makes to the parameter in the body of the method.
*   ▪ The passed variable can be uninitialized (have no value).
*/

/*
//* Example:

static void TestOutCall(int length, int width, out int circum, out int area)
{
    circum = 2 * (length + width);
    area = length * width;
}

int L = 10, W = 15, C, S;
TestOutCall(L, W, out C, out S);
Console.WriteLine("C = " + C);
Console.WriteLine("S = " + S);
*/




//* Example:
//* The following example shows various previous cases

/*
//* .............. Functions ..............


//* parameter x receives a copy of the value passed as an argument,
//* so this method cannot modify the caller's variable.
static void Square(int x)
{
    x = x * x;
} //* end method Square



//* uses reference parameter x to modify caller's variable.
static void SquareRef(ref int x)
{
    x = x * x; //* squares value of caller's variable.

} //* end method SquareRef.


//* uses output parameter x to assign a value to an uninitialized variable.
static void SquareOut(out int x)
{
    x = 6; //* assigns a value to caller's variable.
    x = x * x; //* squares value of caller's variable.
} //* end method SquareOut.


//* .............. End Functions ..............


//* call methods with value, reference and output parameters.
int y = 5; //* initialize y to 5.
int z; //* declares z, but does not initialize it.

//* --------------------------

//* display original values of y and z.
Console.WriteLine("Original value of y: {0}", y);
Console.WriteLine("Original value of z: uninitialized\n");

//* --------------------------

//* pass y and z by value.
Square(y);
//* Square(z); //* Error.

//* display values of y and z after they are passed to method Square,
//* to demonstrate arguments passed by value are not modified.
Console.WriteLine("Value of y after Square: {0}", y);
//* Console.WriteLine("Value of z after Square: {0}", z); //* Error.

System.Console.WriteLine(); //* --------------------------

//* pass y and z by reference.
SquareRef(ref y); //* must use keyword ref.
SquareOut(out z); //* must use keyword out.

//* display values of y and z after they are modified by,
//* methods SquareRef and SquareOut, respectively.
Console.WriteLine("Value of y after SquareRef: {0}", y);
Console.WriteLine("Value of z after SquareOut: {0}\n", z);
*/


//* --------------------------------------------------------------


//* >>>>>>>>>>>>>>>>>>>>> The array is a parameter of the method <<<<<<<<<<<<<<<<<<<<<<<<< *//

/*
//* - Arrays can be used as a parameter for methods,
//*   and in this case they exhibit distinct behavior both during the method declaration process and during the method call process.

//* - We summarize this method in the following points:
//*     ▪ When passing an array as an input parameter to a method,
//*       the passing is by reference, meaning that any modification to the elements of the array,
//*       within the method will affect the elements of the passed array.
//*     ▪ When an element of the array is passed as an input parameter to a method,
//*       this element is treated like any other variable, that is,
//*       it can be passed by value, by reference, or as an output variable.
*/


//* Example:
//* - In the following example, we declare the ModifyArray method,
//*   which has an array input parameter. Within the method, we rotate the elements of the matrix to multiply them by 2.
//* - Note that when you call the previous method and pass an array to it.
//*   The passed array elements will be affected after the call (multiply by 2).

//* - In the following example, we declare the ModifyElement method,
//*   which has an integer input parameter.
//*   Inside the method, we multiply the passed parameter by 2.
//* - Note that when you call the previous method and pass an element of the array as its parameter.
//*   Item will not be affected Array (parameter value).

/*
//* .............. Functions ..............

//* multiply each element of an array by 2.
static void ModifyArray(int[] array2)
{
    for (int counter = 0; counter < array2.Length; ++counter)
    {
        array2[counter] *= 2;
    }
} //* end method ModifyArray.

//* multiply argument by 2.
static void ModifyElement(int element)
{
    element *= 2;
    Console.WriteLine("Value of element in ModifyElement: {0}", element);
} //* end method ModifyElement.

//* .............. End Functions ..............



int[] array = { 1, 2, 3, 4, 5 };

Console.WriteLine("Effects of passing reference to entire array:\n" +
                    "The values of the original array are:");

//* output original array elements.
foreach (int value in array)
{
    Console.Write(" {0}", value);
}

ModifyArray(array); //* pass array reference.

Console.WriteLine("\n\nThe values of the modified array are:");

//* output modified array elements.
foreach (int value in array)
{
    Console.Write(" {0}", value);
}

System.Console.WriteLine();
System.Console.Write("-------------------------------------");

Console.WriteLine("\n\nEffects of passing array element value:\n" +
                  "array[3] before ModifyElement: {0}", array[3]);

ModifyElement(array[3]); //* attempt to modify array[3].

Console.WriteLine("array[3] after ModifyElement: {0}", array[3]);
*/


//! IMPORTANT NOTES:
//!     1. The default mode for passing "variables" in functions is: Call py "value".
//!     2. The default mode for passing "arrays" in functions is: Call py "reference".



//* --------------------------------------------------------------


//* >>>>>>>> List of parameters of variable length <<<<<<<<< *//

/*
//* A variable-length parameter list allows declaring methods that can have a variable number of parameters.
//* A list of variables of variable length is declared using a unary array as the parameter preceded by the keyword "params".
//*     ▪ In the following example, we declare the Average method using a single matrix as the input parameter with the keyword params.
//*     ▪ Note that we call this method with a variable number of parameters each time.
*/

//* Example:
/*
//* .............. Functions ..............

//* calculate average.
static double Average(params double[] numbers)
{
    double total = 0.0; //* initialize total

    //* calculate total using the foreach statement.
    foreach (double d in numbers)
    {
        total += d;
    }

    return total / numbers.Length;
} //* end method Average


//* .............. End Functions ..............


double d1 = 10.0;
double d2 = 20.0;
double d3 = 30.0;
double d4 = 40.0;

Console.WriteLine("d1 = {0:F1}\nd2 = {1:F1}\nd3 = {2:F1}\nd4 = {3:F1}\n", d1, d2, d3, d4);

Console.WriteLine("Average of d1 and d2 is {0:F1}", Average(d1, d2));
Console.WriteLine("Average of d1, d2 and d3 is {0:F1}", Average(d1, d2, d3));
Console.WriteLine("Average of d1, d2, d3 and d4 is {0:F1}", Average(d1, d2, d3, d4));

*/



//* .............................................


//* >>>>>>>>>>> Use virtual brokers <<<<<<<<<<<<<<<< *//

/*
//* - Giving default values to brokers during the method declaration process.

//* - In this case, if the calling method passes explicit values for these arguments during the calling process,
//*   the method uses that explicit value in execution.
//* - If an explicit value is not passed to these arguments, the method uses the default values passed during the declaration when executing the method.

//* - This makes it much easier for the programmer to call the method, as it allows him not to pass intermediate values for all parameters during the call,
//*   It can also reduce potential errors by passing unwanted values.
*/


//* Example 1: Calculating the volume of a rectangular prism.

//* Assuming that we have a group of cement blocks in the form of rectangular parallelepipeds,
//* most of which are 40 cm high, and that a construction worker uses these blocks to build a wall,
//* He first calculates the size of the cement block in his hands to determine where on the wall he will place it.

//* We would like to help him calculate the volume of the cement block.

/*
//* .............. Functions ..............

//* calculate volume
static int block_vol(int length, int width, int height = 40)
{
    return length * width * height;
} //* end method block_vol


//* .............. End Functions ..............


//* length = 10, width=20, height = 40.
Console.WriteLine(block_vol(10, 20));

//* length = 10, width=20, height = 30 (not 40).
Console.WriteLine(block_vol(10, 20, 30));
*/

//! Note 1: The order of parameters in the method definition is very important if there are default values for some arguments.
//! Note 2:Parameters with default values (if they exist) must be included at the end of the method parameters so that if they are deleted during the call,
//!        the compiler does not have any confusion in the order of the values passed.

//* .............................................


//* A method can contain any number of parameters with default values.

//* Example: 
/*
//* .............. Functions ..............

//* calculate volume.
static int block_vol(int length = 60, int width = 50, int height = 40)
{
    return length * width * height;
} //* // end method block_vol

//* .............. End Functions ..............

//* length = 60, width = 50, height = 40.
Console.WriteLine(block_vol());

//* length = 30 (not 60), width = 50, height = 40.
Console.WriteLine(block_vol(30));

//* length = 30 (not 60), width = 10 (not 50), height = 40.
Console.WriteLine(block_vol(30, 10));

//* length = 10 (not 60), width = 20 (not 50), height = 30 (not 40).
Console.WriteLine(block_vol(10, 20, 30));
*/

//! Note: If we wanted "width" to be the default value,
//!       in these cases, it is necessary to resort to "naming the transactions during the call".
//!       as follows:

// Console.WriteLine(block_vol(length: 30, height: 10));


//* .............................................



//* Example 2: Calculating raising a number to an integer power.
//* We want to calculate the result of raising a number to a power,
//* so the most common case is to calculate the square of the number.

/*
//* .............. Functions ..............

//* use iteration to calculate power
static int Power(int baseValue, int exponentValue = 2)
{
    int result = 1; //* initialize total.

    for (int i = 1; i <= exponentValue; i++)
    {
        result *= baseValue;
    }

    return result;
}

//* .............. End Functions ..............

//* call Power with and without optional arguments.
Console.WriteLine("Power(10) = {0}", Power(10));
Console.WriteLine("Power(2, 10) = {0}", Power(2, 10));
*/

//* .............................................

//* -------------------------------------------------------------------

//* .......... Field of view (Scope) ......... *//

/*
* Each variable has a scope, that is, the set of instructions that can manipulate this variable.

* The following rules explain the basics of the scope of declaration:
*   - The scope of method "parameters" is only the "body" of the method itself.
*   - The scope of a local variable is declared within the method, the block of instructions.
*   - The scope of variables declared within the initialization section "of" the for statement,
*     is the body of the "for" statement and any expressions used in its header.
*   - The scope of a method declared within a class, is the entire body of that class.
*   - The static method can only handle static class fields.
*   - Each block can declare its variables.
*   - The variable declared in the closest block is returned.
*/


//* Example ..
/*
//* .......... Function ..........

//* create and initialize local variable x during each call.
static void UseLocalVariable()
{
    int x = 25; //* initialized each time UseLocalVariable is called.
    Console.WriteLine("local x on entering method UseLocalVariable is {0}", x);

    x++; //* modifies this method's local variable x.
    Console.WriteLine("local x before exiting method UseLocalVariable is {0}", x);
}
//* end method UseLocalVariable.

//* .......... End Function ..........

int x = 5; //* method's local variable x hides static variable x.
Console.WriteLine("local x in method ( Main ) is {0}", x);

//* UseLocalVariable has its own local x.
UseLocalVariable();

Console.WriteLine("local x in method ( Main ) is {0}", x);
*/

//* -------------------------------------------------------------------

//* >>>>>>>>>> Overloading methods <<<<<<<<<< //

/*
*   - In a single class, it is possible to declare multiple methods with the same name as long as each one has a different set of parameters (number of parameters and transaction types)..
*     This feature is called method overloading.

*   - When a loaded method is called, the compiler selects the corresponding method by examining the number patterns, and order of arguments.

*   - Overloading is usually used when we need to accomplish the same task in different ways..
*     For example, the Max method in the Math class has about 11 instances (which vary depending on the parameter types). 
*/

//* Example ..
/*
//* .......... Function ..........

//* square method with int argument.
static int Square(int intValue)
{
    Console.WriteLine("Called square with int argument: {0}", intValue);
    return intValue * intValue;
}
//* end method Square with int argument.

//* square method with double argument.
static double Square(double doubleValue)
{
    Console.WriteLine("Called square with double argument: {0}", doubleValue);
    return doubleValue * doubleValue;
}
//* // end method Square with double argument.

//* .......... End Function ..........

Console.WriteLine("Square of integer 7 is {0}", Square(7));
Console.WriteLine("Square of double 7.5 is {0}", Square(7.5));
*/

//! Note: Methods cannot be differentiated by the return value pattern alone..
//!       That is, it is not allowed to define two methods that have the same name and the same parameters, but rather differ in the return value.

//* -------------------------------------------------------------------

//* >>>>>>>>>> Recursion methods <<<<<<<<<< *//

/*
*    - We say that a function is recursive if its definition includes two basic components:

*      1. The first component: is the primitive anchor value of the function,
*         meaning the value or values it takes in its initial state.

*      2. The second component: is the induction step (or recursive step),
*         which is the expression of a value for the function in terms of a previous value (or values) for it.
*/

//* Example ..
//* One of the famous problems about recursive functions is the integer factorial problem.
/*
//* ............. Function .............
static long Factorial(long number)
{
    //* base case.
    if (number <= 1)
    {
        return 1;
        //* recursion step.
    }
    else
    {
        return number * Factorial(number - 1);
    }
}
//* end method Factorial.
//* ............. End Function .............

//* calculate the factorials of 0 through 10.
for (long counter = 0; counter <= 10; ++counter)
{
    Console.WriteLine("{0}! = {1}", counter, Factorial(counter));
}
*/

//* Example 2 ..
//* One of the famous problems about recursive functions is the problem of calculating the terms of the Fibonacci series.
/*
//* ............. Function .............
static int Fib(int number)
{
    //* base case.
    if (number == 0 || number == 1)
    {
        return number;
        //* recursion step.
    }
    else
    {
        return Fib(number - 1) + Fib(number - 2);
    }
}
//* end method Factorial.
//* ............. End Function .............

//* calculate the factorials of 0 through 10.
for (int counter = 0; counter <= 10; ++counter)
{
    Console.Write("{0} ", Fib(counter));
}
Console.WriteLine();
*/

//* -------------------------------------------------------------------

//* >>>>>>>>> Examples of methods <<<<<<<<<

//* Example 1:

//* Write a program in C# to calculate the greatest common divisor of two integers in two different ways:
//* 1. Euclid's algorithm method assigns the value of the remainder of the division of the largest number by the smallest to the largest number all the way to zero.
//* 2. Algorithmic method of successive subtraction of the smallest from the largest until the two numbers are equal.
/*
//* 1:
//* ............. Functions .............
static int mgcd1(int a, int b)
{
    int r;
    while ((a != 0) && (b != 0))
    {
        if (a > b)
        {
            a = a % b;
        }
        else
        {
            b = b % a;
        }
    }
    r = (a != 0) ? a : b; return r;
}
static int mgcd2(int p, int q)
{
    while (p != q)
    {
        if (p > q)
        {
            p -= q;
        }
        else
        {
            q -= p;
        }
    }
    return p;
}
//* ............. End Functions .............

Console.Write("First Number : ");
int p = Int32.Parse(Console.ReadLine());

Console.Write("Second Number : ");
int q = Int32.Parse(Console.ReadLine());

if (p * q != 0)
{
    Console.WriteLine("mgcd of " + p + " and " + q + " = " + mgcd1(p, q));
    Console.WriteLine("mgcd of " + p + " and " + q + " = " + mgcd2(p, q));
}
else
{
    Console.WriteLine("One of the numbers is null !");
}
*/

//* 2:
//* The following is a re-solution of the same previous problem, but using recursive methods:
/*
//* ............. Functions .............
static int mgcd1(int a, int b)
{
    if (a % b == 0)
    {
        return b;
    }
    else if (b % a == 0)
    {
        return a;
    }
    else if (a > b)
    {
        return mgcd1(a % b, b);
    }
    else
    {
        return mgcd1(a, b % a);
    }
}
static int mgcd2(int p, int q)
{
    if (p == q)
    {
        return p;
    }
    else if (p > q)
    {
        return mgcd2(p - q, q);
    }
    else
    {
        return mgcd2(p, q - p);
    }
}
//* ............. End Functions .............

Console.Write("First Number : ");
int p = Int32.Parse(Console.ReadLine());

Console.Write("Second Number : ");
int q = Int32.Parse(Console.ReadLine());

if (p * q != 0)
{
    Console.WriteLine("mgcd of " + p + " and " + q + " = " + mgcd1(p, q));
    Console.WriteLine("mgcd of " + p + " and " + q + " = " + mgcd2(p, q));
}
else
{
    Console.WriteLine("One of the numbers is null !");
}
*/

//* _____________________________________________________________________________________

//* Example 2:
//* Write a program in C# to display the first n prime number from the set of positive integers.
/*
//* ............. Functions .............
static bool is_perm(int x)
{
    bool result = true;
    int i = 2;

    do
    {
        if (x % i == 0)
        {
            result = false;
        }
        else
        {
            i++;
        }
    }
    while ((i <= x / 2) && (result == true));
    return result;
}
//* ............. End Functions .............

int n, count = 0, number = 3;

Console.Write("How much numbers to Display ? ");
n = Int32.Parse(Console.ReadLine());

while (count <= n)
{
    if (is_perm(number) == true)
    {
        Console.WriteLine(number);
        count++;
    }
    number++;
}
*/

//* _____________________________________________________________________________________

//* Example 3 ..

//* Write a program in C# to verify that a string of characters has the property of “palindrome”,
//* meaning that it remains the same whether we read it from right to left or from left to right.
//* for example: abcddcba, acca.

/*
//* ............. Functions .............
static string inverse(string s)
{
    string r = "";
    int L = s.Length;
    for (int i = 0; i <= L - 1; i++)
    {
        r = r + s[L - 1 - i];
    }
    return r;
}
//* ............. End Functions .............

string s;

Console.Write("Enter String: ");
s = Console.ReadLine();

string invs = inverse(s);

Console.WriteLine("Your string : " + s);
Console.WriteLine("Invers string : " + invs);

if (s == invs)
{
    Console.WriteLine("palindrome !");
}
else
{
    Console.WriteLine("Not palindrome !");
}
*/

//* _____________________________________________________________________________________


//* Example 4:

//* Write a method to swap the values of two passed numbers.
//! Note: Use the concept of "overloading "and the concept of "calling by reference" to write two versions of this function,
//!       noting the difference.

/*
//* ............. Functions .............
static void swapByVal(int n, int m)
{
    int k;
    k = n;
    n = m;
    m = k;
}
static void swapByRef(ref int n, ref int m)
{
    int k;
    k = n;
    n = m;
    m = k;
}
//* ............. End Functions .............

int x = 1, y = 10;

Console.WriteLine("Before swap x= {0}, y= {1}", x, y);

swapByVal(x, y);

Console.WriteLine("After swap(Passing values) x= {0}, y= {1}", x, y);

swapByRef(ref x, ref y);

Console.WriteLine("After swap(Passing references) x= {0}, y= {1}", x, y);
*/

//* _____________________________________________________________________________________


//* Example 5 ..

//* Write a method to find the largest number, the smallest number, and the median of two values.
/*
//* ............. Functions .............
//* Max, Min and Avg Function.
static void MaxMinAvg(double x, double y, out double max, out double min, out double avg)
{
    if (x > y)
    {
        max = x;
        min = y;
    }
    else
    {
        max = y;
        min = x;
    }

    avg = (x + y) / 2;
}
//* End Max, Min and Avg Function.
//* ............. End Functions .............

//* Declare variable.
double a = 10, b = 20, max = 0, min = 0, avg = 0;

//* Call Max, Min and Avg Function.
MaxMinAvg(a, b, out max, out min, out avg);

//* Print Max, Min, Avg.
Console.WriteLine("Max: {0}, Min: {1}, Avg: {2} ", max, min, avg);
*/

//* _____________________________________________________________________________________


//* >>>>>>>>>>>>>>> Exercises and activities <<<<<<<<<<<<<< *//

//* Exercise 1:
//* Write the LCM method to calculate the simple common multiple of two integers,
//* and then use it in an application that asks the user to enter two integers and then displays the simple common multiple for them.
/*
//* ............. Functions .............
//* LCM Function.
static int LcmFun(int x, int y)
{
    //* 1. Find multiples of numbers.
    //* Declare arrays for storage multiples of numbers.
    int[] num1 = new int[50];
    int[] num2 = new int[50];
    //* Declare variable for calculating multiples of numbers.
    int mulNum1 = 0;
    int mulNum2 = 0;
    //* Calculating multiples of numbers.
    for (int i = 0; i < 50; i++)
    {
        mulNum1 = mulNum1 + x;
        num1[i] = mulNum1;

        mulNum2 = mulNum2 + y;
        num2[i] = mulNum2;

    }

    //* 2. Find the simple common multiple.
    int simpleMultiple = 0;
    for (int i = 0; i < num1.Length; i++)
    {
        for (int k = 0; k < num2.Length; k++)
        {
            if (num1[i] == num2[k])
            {
                simpleMultiple = num1[i];
                return simpleMultiple;
            }
        }
    }

    return simpleMultiple;
}
//* End LCM Function.
//* ............. End Functions .............

//* Declare variable.
int x = 0, y = 0;

Console.WriteLine("\n\nProgram calculate the simple common multiple of two integers ..\n");

//* Receive value from user.
Console.Write("Please enter first number: ");
x = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter first number: ");
y = Convert.ToInt32(Console.ReadLine());

//* Call Lcm function. 
Console.WriteLine("\nThe simple common multiple for {0} and {1} is: {2}\n\n", x, y, LcmFun(x, y));
*/

//* _____________________________________________________________________________________

//* Exercise 2:
//* Write several copies of the Average method so that the method accepts three numbers of the type int,
//* long, or double and returns the arithmetic mean for them.
/*
//* ............. Functions .............
int AverageInt(int a, int b, int c)
{
    int avg = 0;
    avg = (a + b + c) / 3;
    return avg;
}

long AverageLong(long a, long b, long c)
{
    long avg = 0;
    avg = (a + b + c) / 3;
    return avg;
}

double AverageDouble(double a, double b, double c)
{
    double avg = 0;
    avg = (a + b + c) / 3;
    return avg;
}
//* ............. End Functions .............

Console.WriteLine("\n\nAverage Int= {0}", AverageInt(1, 2, 3));
Console.WriteLine("Average Long = {0}", AverageLong(1000, 2000, 3000));
Console.WriteLine("Average Double = {0}\n\n", AverageDouble(1.1, 2.2, 3.3));
*/

//* _____________________________________________________________________________________

//* Exercise 3:
//* Modify the previous methods for calculating the arithmetic mean..
//* So one parameter, two parameters, or three parameters can be passed to the method.
/*
//* ............. Functions .............
int AverageInt(int a, int b = 0, int c = 0)
{
    int avg = 0;
    avg = (a + b + c) / 3;
    return avg;
}

long AverageLong(long a, long b = 0, long c = 0)
{
    long avg = 0;
    avg = (a + b + c) / 3;
    return avg;
}

double AverageDouble(double a, double b = 0, double c = 0)
{
    double avg = 0;
    avg = (a + b + c) / 3;
    return avg;
}
//* Important note: Optional parameters must appear after all required parameters.
//* ............. End Functions .............

Console.WriteLine("\n\nAverage Int= {0}", AverageInt(1, 2, 3));
Console.WriteLine("Average Long = {0}", AverageLong(1000, 2000));
Console.WriteLine("Average Double = {0}\n\n", AverageDouble(1.1));
*/

//* _____________________________________________________________________________________


//* Exercise 4:
//* Write a method that takes an integer as the input parameter and returns the inverse of that number..
//* For example, if the number is 7631, the method returns 1367.
/*
//* ............. Functions .............
static int inverseNumber(int x)
{
    //* Convert the number into string.
    string originalString = x.ToString();

    //* Convert a string to an array of characters and reverse it.
    char[] reversedArray = originalString.ToCharArray().Reverse().ToArray();

    //* Convert the inverted array to a string.
    string reversedString = new string(reversedArray);

    //* Convert the string to int.
    int reversedNumber = int.Parse(reversedString);

    return reversedNumber;
}
//* ............. End Functions .............

Console.WriteLine("\n\nInverse number: {0}\n\n", inverseNumber(123));
*/

//* _____________________________________________________________________________________


//* Exercise 5: