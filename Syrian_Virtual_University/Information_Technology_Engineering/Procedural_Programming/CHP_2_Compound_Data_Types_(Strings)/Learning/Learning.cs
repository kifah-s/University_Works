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

// * comparisons:
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


//! Note: Only addition + (among arithmetic operations) and equality == (among comparison operations) can be used with Values of type string.

//* Below is a list of the most important pre-defined string class methods:
//* - Compare()
//* - Concat()
//* - Copy()
//* - Equals()
//* - Length
//* - EndsWith()
//* - Insert()
//* - IndexOf)()
//* - LastIndexOf()
//* - StartsWith()
//* - Substring()
//* - ToLower()
//* - ToUpper()
//* - Trim()
//* - TrimEnd()
//* - TrimStart()


//* Examples of using the String class method:
//* Example - 1 :
//* The following example shows the use of some string methods ..

// //* create some strings to work with.
// string s1 = "abcd";
// string s2 = "ABCD";
// string s3 = "Liberty Associates, Inc. provides custom .NET development, on-site Training and Consulting";


// int result; //* hold the results of comparisons.
// //* compare two strings, case sensitive.
// result = string.Compare(s1, s2);
// Console.WriteLine("compare s1: {0}, s2: {1}, result: {2}\n", s1, s2, result);


// result = string.Compare("Said", "Ahmad Said");
// Console.WriteLine("compare Said, Ahmad Said, result: {2}\n", s1, s2, result);


// //* overloaded compare, takes boolean "ignore case".
// //* (true = ignore case).
// result = string.Compare(s1, s2, true);
// Console.WriteLine("compare insensitive\n");
// Console.WriteLine("s4: {0}, s2: {1}, result: {2}\n", s1, s2, result);
// //* concatenation method.
// string s6 = string.Concat(s1, s2);
// Console.WriteLine("s6 concatenated from s1 and s2: {0}", s6);


// //* use the overloaded operator.
// string s7 = s1 + s2;
// Console.WriteLine("s7 concatenated from s1 + s2: {0}", s7);


// //* the string copy method.
// string s8 = string.Copy(s7);
// Console.WriteLine("s8 copied from s7: {0}", s8);


// //* use the overloaded operator.
// string s9 = s8;
// Console.WriteLine("s9 = s8: {0}", s9);


// //* three ways to compare.
// Console.WriteLine("\nDoes s9.Equals(s8)?: {0}", s9.Equals(s8));
// Console.WriteLine("Does Equals(s9,s8)?: {0}", string.Equals(s9, s8));
// Console.WriteLine("Does s9==s8?: {0}", s9 == s8);


// //* Tow useful properties: the index and the length.
// Console.WriteLine("\nString s9 is {0} characters long. ", s9.Length);

// Console.WriteLine("The 5th character is {0}\n", s9[4]);

// //* test whether a string ends with a set of characters.

// Console.WriteLine("s3:{0}\nEnds with Training?: {1}\n", s3, s3.EndsWith("Training"));
// Console.WriteLine("Ends with Consulting?: {0}", s3.EndsWith("Consulting"));
// //* return the index of the substring.
// Console.WriteLine("\nThe first occurrence of Training ");
// Console.WriteLine("in s3 is {0}\n", s3.IndexOf("Training"));
// //* insert the word excellent before "training".
// string s10 = s3.Insert(101, "excellent ");
// Console.WriteLine("s10: {0}\n", s10);
// //* you can combine the two as follows:
// string s11 = s3.Insert(s3.IndexOf("Training"), "excellent ");
// Console.WriteLine("s11: {0}\n", s11);




//* Example - 2 :
//* The following example shows ways to search within text strings ..

// string s1 = "One Two Three Four";
// int ix;
// //* get the index of the last space.
// ix = s1.LastIndexOf(" ");


// //* get the last word.
// string s2 = s1.Substring(ix + 1);


// //* set s1 to the substring starting at 0.
// //* and ending at ix (the start of the last word.
// //* thus s1 has one two three.
// s1 = s1.Substring(0, ix);


// //* find the last space in s1 (after two).
// ix = s1.LastIndexOf(" ");
// //* set s3 to the substring starting at.
// //* ix, the space after "two" plus one more.
// //* thus s3 = "three".
// string s3 = s1.Substring(ix + 1);


// Console.WriteLine("s2: {0}\ns3: {1}", s2, s3);
// //* reset s1 to the substring starting at 0.
// //* and ending at ix, thus the string "one two".
// s1 = s1.Substring(0, ix);


// //* reset ix to the space between "one" and "two".
// ix = s1.LastIndexOf(" ");


// //* set s4 to the substring starting one space after ix, thus the substring "two".
// string s4 = s1.Substring(ix + 1);


// //* reset s1 to the substring starting at 0 and ending at ix, thus "one".
// s1 = s1.Substring(0, ix);


// //* set ix to the last space, but there is none so ix now = -1.
// ix = s1.LastIndexOf(" ");


// //* set s5 to the substring at one past the last space.
// //* there was no last space so this sets s5 to the substring starting at zero.
// string s5 = s1.Substring(ix + 1);


// Console.WriteLine("s4: {0}\ns5: {1}\n", s4, s5);
// Console.WriteLine("s1: {0}\n", s1);