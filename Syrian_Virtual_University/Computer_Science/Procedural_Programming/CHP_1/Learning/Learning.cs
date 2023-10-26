// See https://aka.ms/new-console-template for more information



//* >>> .......... Compound Data Types: Arrays  .......... <<<


//* >>> The array one-dimensional <<<

//* A one-dimensional array can be declared in C# in three ways:

//* 1 - Declare the array without specifying its size:
//  int[] table1; // Table of integer.
//  char[] table2; // Table of char.
//  float[] table3; // Table of float.
//  string[] tableStr;// Table of string.
//* Note: The previous command does not create the array elements and reserve a place for them in memory.

//* ----------------------------------------

//* 2 - Declare the array and specify its size:
//  int[] table1 = new int[5];
//  char[] table2 = new char[12];
//  float[] table3 = new float[8];
//  string[] tableStr = new String[9];
//* Note: The previous command creates the elements of the array, reserves a place for them in memory, and makes all the values of its elements zero.

//* ----------------------------------------

//* 3 - Declare the array and give it initial values:
//  int[] table1 = { 17, -9, 4, 3, 57 };
//  char[] table2 = { 'a', 'j', 'k', 'm', 'z' };
//  float[] table3 = { -15.7f, 75, -22.03f, 3, 57 };
//  string[] tableStr = { "cat", "dog", "mouse", "cow" };
//* Note: The previous command creates the array elements, reserves a place for them in memory, and stores the passed values in these places.
//* Note: The maximum size of the array in this case is the same number of values passed.

// __________________________________________________________________________________________________________________________________________________________

//* >>> Accessing array elements <<<

//* Create array of integer.
// int[] sales = { 10, 20, 30, 40, 50 };

//* Print the values of the elements in the array.
// Console.WriteLine();
// Console.WriteLine("Index 0: " + sales[0]);
// Console.WriteLine("Index 1: " + sales[1]);
// Console.WriteLine("Index 2: " + sales[2]);
// Console.WriteLine("Index 3: " + sales[3]);
// Console.WriteLine("Index 4: " + sales[4]);
// Console.WriteLine();

//* ----------------------------------------

//* Create array of integer.
// int[] sales = { 10, 20, 30, 40, 50 };

//* Assign a new value to the first element in the array.
// sales[0] = 100;
// Console.WriteLine(sales[0]);
// Console.WriteLine();

//* ----------------------------------------

//* Create array of integer.
// int[] sales = { 10, 20, 30, 40, 50 };

//* Using array elements in arithmetic operations and expressions.
// sales[4] = sales[1] * 4;
// Console.WriteLine(sales[4]);
// Console.WriteLine();

//* ----------------------------------------

//* Create array of integer.
// int[] sales = { 10, 20, 30, 40, 50 };

//* Using array elements in arithmetic operations and expressions.
// int sum_sales = sales[0] + sales[1] + sales[2] + sales[3] + sales[4];
// Console.WriteLine("Sum sales = " + sum_sales);
// Console.WriteLine();

//* ----------------------------------------

//* Error: System.IndexOutOfRangeException: Index was outside the bounds of the array.
// sales[10] = 500;

// __________________________________________________________________________________________________________________________________________________________


//* >>> Wandering through array <<<


//* Create array of integer.
// int[] sales = { 10, 25, 33, 8, 11 };

//* Print array elements.
// Console.WriteLine(sales[0]);
// Console.WriteLine(sales[1]);
// Console.WriteLine(sales[2]);
// Console.WriteLine(sales[3]);
// Console.WriteLine(sales[4]);
// Console.WriteLine();

//* ----------------------------------------

//* Create array of integer.
// int[] sales = { 10, 25, 33, 8, 11 };

//* Print array elements.
// for(int i = 0; i < 5; i++)
// {
//     Console.WriteLine(sales[i]);
// }
// Console.WriteLine();

//* ----------------------------------------

//* Create array of integer.
// int[] sales = { 10, 25, 33, 8, 11 };

//* Create variable for storage array length.
// int arrLen = sales.Length;

//* Print array elements.
// for(int i = 0; i < arrLen; i++)
// {
//     Console.WriteLine(sales[i]);
// }
// Console.WriteLine();

//* ----------------------------------------

//* Create array of integer.
// int[] sales = { 10, 25, 33, 8, 11 };

//* Print array elements.
// foreach (int i in sales)
// {
//     Console.WriteLine(i);
// }
// Console.WriteLine();

// __________________________________________________________________________________________________________________________________________________________

//* >>> Examples of using one-dimensional arrays <<<

//* Example - 1: Verifying that the elements of an array take the value 0 when they are created without initializing them.
// int[] array;
// array = new int[5];
// Console.WriteLine("{0}{1,8}", "Index", "Value");
// for (int counter = 0; counter < array.Length; ++counter)
// {
//     Console.WriteLine("{0}{1,8}", counter, array[counter]);
// }
// Console.WriteLine();

//* ----------------------------------------

//* Example - 2: Entering student grades in an Introduction to Programming course,
//* then finding the lowest grade, the highest grade, and the arithmetic average of the class grades.

//* Create variables.
// int n, max, min, sum, avg;
// Console.Write("Enter Students Count: ");
// n = Int32.Parse(Console.ReadLine());

// Console.WriteLine();

//* dynamically define students count.
// int[] grades = new int[n];

//* read students grades.
// Console.WriteLine("Enter Students Grades: ");
// for (int index = 0; index < grades.Length; index++)
// {
//     Console.Write("Student " + (index + 1) + ": ");
//     grades[index] = Int32.Parse(Console.ReadLine());
// }

//* finding max,min,average.
// max = min = sum = grades[0];
// for (int index = 1; index < grades.Length; index++)
// {
//     if (grades[index] > max)
//     {
//         max = grades[index];
//     }
//     if (grades[index] < min)
//     {
//         min = grades[index];
//     }
//     sum += grades[index];
// }
// avg = sum / n;

// Console.WriteLine();

//* printing students grades.
// Console.WriteLine("Students Grades:");
// foreach (int grad in grades)
// {
//     Console.Write(grad + " ");
// }

// Console.WriteLine();

//* printing max,min,average
// Console.WriteLine("max = {0} \t min= {1} \t avg= {2}", max, min, avg);

//* Note: In this example, we defined the number of elements of an array dynamically,
//* and we also used more than one formula to navigate through the elements of the array and perform operations on them.

// __________________________________________________________________________________________________________________________________________________________

//* >>> Multidimensional arrays <<<

//* Examples:
// int[ , ] arr2d; // two-dimensional array.
// int[ , , ] arr3d; // three-dimensional array.
// int[ , , , ] arr4d; // four-dimensional array.
// int[ , , , , ] arr5d; // five-dimensional array.
//* Note: The number of dimensions of an array is equal to the number of separators plus one.

//* ----------------------------------------

//* >>> Two-dimensional array <<<

//* C# supports two types of binary arrays:
//   - Rectangular or square arrays.
//   - Jagged arrays.

//* 1 - Rectangular or square arrays:

//* All lines of a array are of equal length (and so are all columns),
//* so...Represent it in the form of a table.

//* Examples:
//* declaring and initializing 2-d array.
// int[,] arr2d = new int[3, 2] {{1, 2},
//                               {3, 4},
//                               {5, 6}};

//* OR ..
// int[,] arr2d2 = {{1, 2},
//                  {3, 4},
//                  {5, 6}};

//* ----------------------------------------

//* Accessing any element in an array requires knowing the line index and the column index to which it belongs.
// int[,] arr2d = new int[3, 2] {{ 1, 2 },
//                               { 3, 4 },
//                               { 5, 6 } };

// int ele0 = arr2d[0, 0]; //returns 1
// Console.WriteLine(ele0);

// int ele1 = arr2d[0, 1]; //returns 2
// Console.WriteLine(ele1);

// int ele2 = arr2d[1, 0]; //returns 3
// Console.WriteLine(ele2);

// int ele3 = arr2d[1, 1]; //returns 4
// Console.WriteLine(ele3);

// int ele4 = arr2d[2, 0]; //returns 5
// Console.WriteLine(ele4);

// int ele5 = arr2d[2, 1]; //returns 6
// Console.WriteLine(ele5);

//! Note: In a special case, if the number of lines and columns are equal, the array is said to be square.

//* ----------------------------------------

//* 2 - Jagged arrays:

//* In this type of array, the lines of the array are of varying length,
//* meaning each line has a different number of columns.

//* Examples:
//* Exa_1:
// int[][] jagged = { new int[] { 1, 2 },
//                    new int[] { 3 },
//                    new int[] { 4, 5, 6 } };



//* Exa_2:
// int[][] c;
// c = new int[2][]; // create 2 rows
// c[0] = new int[5]; // create 5 columns for row 0
// c[1] = new int[3]; // create 3 columns for row 1


//* ----------------------------------------

//* Examples of using a two-dimensional array:

//* Example_1:
//* In the following example we do the following:
//*     - Declare a rectangular array and a jagged array.
//*     - And give them initial values.
//*     - We then loop through these two arrays and print their values
//!     Note: The for and foreach commands are used to illustrate how each can be used to navigate a binary array.

//* Declaring and Initializing Rectangular Array.
// int[,] rectangular = { { 1, 2, 3 },
//                        { 4, 5, 6 } };

//* Declaring and Initializing jagged Array.
// int[][] jagged = { new int[] { 1, 2 },
//                    new int[] { 3 },
//                    new int[] { 4, 5, 6 } };

//* displays array rectangular by row.
// Console.WriteLine("Values in the rectangular array by row are");

//* loop through array's rows.
// for (int row = 0; row < 2; ++row)
// {
//     //* loop through columns of current row.
//     for (int column = 0; column < 3; ++column)
//     {
//         Console.Write("{0} ", rectangular[row, column]);
//     }
//     Console.WriteLine(); //* start new line of output.
// } //* end outer for.


// Console.WriteLine(); //* output a blank line.


//* displays array jagged by row.
// Console.WriteLine("Values in the jagged array by row are");

//* loop through each row.
// foreach (int[] row in jagged)
// {
//     //* loop through each element in current row.
//     foreach (int element in row)
//     {
//         Console.Write("{0} ", element);
//     }
//     Console.WriteLine(); //* start new line of output
// } //* end outer foreach


//* ----------------------------------------


