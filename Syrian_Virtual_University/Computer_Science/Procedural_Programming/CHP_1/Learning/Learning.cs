// See https://aka.ms/new-console-template for more information


/*
* >>> .......... Compound Data Types: Arrays  .......... <<<




* Data types:
    - simple or fundamental.
    - compound.



* Simple data:
    - A simple data type variable is capable of storing a single value.



* Programming reflects solutions to real-world problems.



* From a data point of view, an array is a collection of data or a sequence of data elements of a fixed size that are all of the same type.
* From a memory point of view, an array is a group of consecutive and adjacent memory slots that have the same name and the same type.



* An array has a fixed number of elements,
* and they are numbered, so there is a first element, a second element, etc...
* Also, the elements of the matrix must be of the same type (an array of integers, an array of real numbers, an array of matrices)
* and therefore the matrix is considered very suitable for organizing homogeneous data sets.



*The array is characterized by the possibility of direct access or random access to any of its values..
* In other words, the time required to access any element within the array is the same regardless of its location within the array.



*Since the elements are numbered within the array,
* the process of determining the location of the element within the array is done through its number, or index.



* The location of the element in the array can be determined through one piece of evidence,
* and then we say that this array is one-dimensional... 
* Sometimes more than one piece of evidence is needed, we say that this array multi-dimensional.

*/

// __________________________________________________________________________________________________________________________________________________________




// __________________________________________________________________________________________________________________________________________________________

/*

* >>> .......... The array one-dimensional  .......... <<<



* A one-dimensional array is a sequence of values of the same type,
* of which accessing any value requires specifying a single directory to its location,
* where the locations are numbered starting from zero.



* A one-dimensional array can be declared in C# in three ways:
* 1 - Declare the array without specifying its size:
    int[] table1; // Table of integer.
    char[] table2; // Table of char.
    float[] table3; // Table of float.
    string[] tableStr;// Table of string.
* Note: The previous command does not create the array elements and reserve a place for them in memory.

* 2 - Declare the array and specify its size:
    int[] table1 = new int[5];
    char[] table2 = new char[12];
    float[] table3 = new float[8];
    string[] tableStr = new String[9];
* Note: The previous command creates the elements of the array, reserves a place for them in memory, and makes all the values of its elements zero.

* 3 - Declare the array and give it initial values:
    int [ ] table1 = {17,-9,4,3,57};
    char [ ] table2 = {'a','j','k','m','z'};
    float [ ] table3 = {-15.7f, 75, -22.03f, 3 ,57 };
    string [ ] tableStr = {"cat","dog","mouse","cow"};
* Note: The previous command creates the array elements, reserves a place for them in memory, and stores the passed values in these places.
* Note: The maximum size of the array in this case is the same number of values passed.
*/

// __________________________________________________________________________________________________________________________________________________________








// __________________________________________________________________________________________________________________________________________________________

// * >>> .......... Accessing array elements  .......... <<<

// * Create array of integer.
// int[] sales = { 10, 20, 30, 40, 50 };

// Print the values of the elements in the array.
// Console.WriteLine();
// Console.WriteLine("Index 0: " + sales[0]);
// Console.WriteLine("Index 1: " + sales[1]);
// Console.WriteLine("Index 2: " + sales[2]);
// Console.WriteLine("Index 3: " + sales[3]);
// Console.WriteLine("Index 4: " + sales[4]);
// Console.WriteLine();

// * Assign a new value to the first element in the array.
// sales[0] = 100;
// Console.WriteLine(sales[0]);
// Console.WriteLine();


// * Using array elements in arithmetic operations and expressions.
// sales[4] = sales[1] * 4;
// Console.WriteLine(sales[4]);
// Console.WriteLine();

// * Using array elements in arithmetic operations and expressions.
// int sum_sales = sales[0] + sales[1] + sales[2] + sales[3] + sales[4];
// Console.WriteLine("Sum sales = " + sum_sales);
// Console.WriteLine();


// * Error: System.IndexOutOfRangeException: Index was outside the bounds of the array.
// sales[10] = 500;

// __________________________________________________________________________________________________________________________________________________________






// __________________________________________________________________________________________________________________________________________________________

// * >>> .......... Wandering through array  .......... <<<

// * Arrays are characterized by direct access or random access,
// * which means that any element in the array can be accessed directly without going through the rest of the elements.
// * The random access feature is quite appropriate when we want to perform some manipulation by inserting, assigning,
// * using, comparing...etc. on the value of a specific element in the array.
// * However, if our desire is to perform some manipulation of the values of the array as a whole or a partial set of it,
// * then using The random or direct access feature is not feasible from a programming perspective.




// * Create array.
// int[] sales = { 10, 25, 33, 8, 11 };

// * Print array elements.
// Console.WriteLine(sales[0]);
// Console.WriteLine(sales[1]);
// Console.WriteLine(sales[2]);
// Console.WriteLine(sales[3]);
// Console.WriteLine(sales[4]);
// Console.WriteLine();

// * ----------------------------------------


// * Create array.
// int[] sales = { 10, 25, 33, 8, 11 };

// * Print array elements.
// for(int i = 0; i < 5; i++)
// {
//     Console.WriteLine(sales[i]);
// }
// Console.WriteLine();



// * ----------------------------------------


// * Create array.
// int[] sales = { 10, 25, 33, 8, 11 };


// * Create variable for storage array length.
// int arrLen = sales.Length;

// * Print array elements.
// for(int i = 0; i < arrLen; i++)
// {
//     Console.WriteLine(sales[i]);
// }
// Console.WriteLine();




// * ----------------------------------------




// * Create array.
// int[] sales = { 10, 25, 33, 8, 11 };

// * Print array elements.
// foreach (int i in sales)
// {
//     Console.WriteLine(i);
// }
// Console.WriteLine();


// * ----------------------------------------


// __________________________________________________________________________________________________________________________________________________________









// __________________________________________________________________________________________________________________________________________________________

// * >>> .......... Examples of using one-dimensional arrays  .......... <<<


// * Example - 1: Verifying that the elements of an array take the value 0 when they are created without initializing them.
// int[] array;
// array = new int[5];
// Console.WriteLine("{0}{1,8}", "Index", "Value");
// for (int counter = 0; counter < array.Length; ++counter)
// {
//     Console.WriteLine("{0}{1,8}", counter, array[counter]);
// }
// Console.WriteLine();


// * ----------------------------------------



// __________________________________________________________________________________________________________________________________________________________
