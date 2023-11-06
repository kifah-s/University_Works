// See https://aka.ms/new-console-template for more information


//* >>>>>>>>>> Compound Data Types: Strings <<<<<<<<<< //

//! Note: A string can be viewed as a one-dimensional array.

//* Declare a character array:
// char[] Course;
// char[] Course = new char[20];
// char[] Course = { 'P', 'r', 'o', 'g', 'r', 'a', 'm', 'm', 'i', 'n', 'g' };


//* Accessing elements of a character array and operations on them:
//! Note: To access any item, you must know its index or directory number.

//* Examples ..

//* 1 - Navigate the character array - Course and print it on the screen:
// char[] Course = { 'P', 'r', 'o', 'g', 'r', 'a', 'm', 'm', 'i', 'n', 'g' };
// for (int i = 0; i < Course.Length; i++)
// {
//      Console.Write(Course[i]);
// }
// Console.WriteLine();



//* 2 - Replace each 'm' character with 'M' in the character array Course:
// char[] Course = { 'P', 'r', 'o', 'g', 'r', 'a', 'm', 'm', 'i', 'n', 'g' };
// for (int i = 0; i < Course.Length; i++)
// {
//     if (Course[i] == 'm')
//     {
//         Course[i] = 'M';
//     }
// }

// for (int i = 0; i < Course.Length; i++)
// {
//     Console.Write(Course[i]);
// }
// Console.WriteLine();


//* ----------------------------------------------------------------------------------------------


//* The String class and its methods:

//! Note: Values of type string can be treated programmatically just as any variable of a simple class is treated.

//* Examples ..

//* 1 - Declaration, input and output operations:
// string Course = "Programming";
// Console.WriteLine(Course);
// Course = Console.ReadLine();


//* 2 - Mergers and comparisons:
//* Mergers:
// string Course1 = "Programming";
// string Course2 = "Introduction To";
// string Course3 = Course2 + " " + Course1;
// Console.WriteLine(Course3);

//* comparisons:
// string Course1 = "Programming";
// string Course2 = "Introduction To";
// if (Course1 == Course2)
// {
//     Console.WriteLine("The words are identical");
// }
// else
// {
//     Console.WriteLine("The words are NOT identical");
// }


