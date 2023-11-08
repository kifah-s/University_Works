// See https://aka.ms/new-console-template for more information


//* >>>>>>>>>> Practice On Compound Data Types <<<<<<<<<< //

//* Exercise - 1 : Problem of unary array evaluations.
//* The Meteorological Directorate wants to record daily rainfall rates over an entire year and make some assessments of them.
//* required is to write a program that allows the following:
//* - Recording daily rainfall.
//* - Calculating the total rainfall throughout the year.
//* - Calculate the percentage of rainy days.

// //* Declaring Storage structure.
// int[] rain_record = new int[365];

// //* Declaring other Variables.
// int sum = 0, count_rainy = 0;
// float rainyDaysAvg;

// //* Entering and Processing Values.
// Console.WriteLine("Enter Rain Records Day by Day");
// for (int i = 0; i < rain_record.Length; i++)
// {
//     rain_record[i] = Int32.Parse(Console.ReadLine());
//     sum += rain_record[i];
//     if (rain_record[i] > 0)
//     {
//         count_rainy++;
//     }
// }

// //* Printing Results.
// Console.WriteLine("Sum of Year Rain Quantities: " + sum);

// rainyDaysAvg = (float)((count_rainy * 100) / rain_record.Length);
// Console.WriteLine("Percent of Rainy Days: " + rainyDaysAvg);

//* -------------------------------------------------------------------------

//* Exercise - 2 : Ohm law problem.
//* Write a program that uses three one-dimensional arrays CURRENT, RESISTANCE, and VOLT to store the values of currents, resistors, and voltages, respectively.
//* Enter values for the two arrays CURRENT and RESISTANCE and then calculate the values of the VOLT array as: VOLT[i] = CURRENT[i] * RESISTANCE[i]
//* Print the values of the three arrays.

// //* Declaring Storage structure.
// float[] current = new float[10];
// float[] resistance = new float[10];
// float[] volt = new float[10];

// //* Entering and Processing Values.
// for (int i = 0; i < 10; i++)
// {
//     Console.Write("Current Value =");
//     current[i] = float.Parse(Console.ReadLine());
//     Console.Write("Resistance Value =");
//     resistance[i] = float.Parse(Console.ReadLine());

//     //* Calculating and storing volt value.
//     volt[i] = current[i] * resistance[i];
// }

// //* Printing Results.
// Console.Write("Resistances : ");
// foreach (float r in resistance)
// {
//     Console.Write(r + "\t");
// }
// Console.WriteLine();

// Console.Write("Currents : ");
// foreach (float c in current)
// {
//     Console.Write(c + "\t");
// }
// Console.WriteLine();


// Console.Write("Volts : ");
// foreach (float v in volt)
// {
//     Console.Write(v + "\t");
// }
// Console.WriteLine();


//* -------------------------------------------------------------------------


//* Exercise - 3 : Table of trigonometric ratios.
//* We want to create a table to store the trigonometric ratios of angles between 0 and 90 degrees,
//* and then print it on the screen.
//! Note: Make use of the methods of the predefined class Math.

// //* Declaring Storage structure.
// double[,] ratios = new double[91, 4];


// //* Calculating and storing ratios.
// for (int i = 0; i < 91; i++)
// {
//     ratios[i, 0] = i;
//     ratios[i, 1] = Math.Sin(i);
//     ratios[i, 2] = Math.Cos(i);
//     ratios[i, 3] = Math.Tan(i);
// }

// //* Displaying Stored Values.
// Console.WriteLine("x \t\t Sin(x) \t\t Cos(x) \t\t Tan(x)");
// for (int i = 0; i < 91; i++)
// {
//     Console.WriteLine("{0} \t\t {1} \t\t {2} \t\t {3}", ratios[i, 0], ratios[i, 1], ratios[i, 2], ratios[i, 3]);
// }


//* -------------------------------------------------------------------------


//* Exercise - 4 : Problem calculating the sum of two arrays.
//* Two arrays can be added by producing a array in which the value of each element is the sum of the two corresponding values.
//* Since the three arrays must have the same dimensions.
//* Write a program that enters the values of two arrays,
//* finds the array expressing the result of their addition,
//* and prints the results.

// //* Declaring Storage structure.
// int[,] mat1 = new int[4, 3];
// int[,] mat2 = new int[4, 3];
// int[,] mat3 = new int[4, 3];

// //* Entering the 2 arrays and calculating sum.
// for (int i = 0; i < 4; i++)
// {
//     for (int j = 0; j < 3; j++)
//     {
//         Console.Write("mat1[ " + i + " , " + j + " ]= ");
//         mat1[i, j] = Int32.Parse(Console.ReadLine());

//         Console.Write("mat2[ " + i + " , " + j + " ]= ");
//         mat2[i, j] = Int32.Parse(Console.ReadLine());

//         mat3[i, j] = mat1[i, j] + mat2[i, j];
//     }
// }

// //* printing arrays.
// Console.WriteLine("Mat1 =");
// foreach (int row in mat1)
// {
//     Console.Write(row + " ");
// }
// Console.WriteLine();

// Console.WriteLine("Mat2 =");
// foreach (int row in mat2)
// {
//     Console.Write(row + " ");
// }
// Console.WriteLine();

// Console.WriteLine("Mat3 =");
// foreach (int row in mat3)
// {
//     Console.Write(row + " ");
// }
// Console.WriteLine();


//* -------------------------------------------------------------------------

//* Exercise - 5 : The problem of square arrays.
//* This problem assumes the existence of a square array of integer values of a certain size,
//* where the following operations are required to be performed:
//* 1 - Enter values for array elements.
//* 2 - Prints the values of array elements line by line.
//* 3 - Calculate the sum of the values of the main diagonal elements.
//* 4 - Find the array value in the secondary diagonal.
//* 5 - Test whether a array is symmetric.

//! Solution notes:
//! A square array is a two-dimensional array with equal numbers of lines and columns. 
//! If we have a square array with dimensions n × n, then:
//!     - Major diagonal elements are elements in which the line index is equal to the column index.
//!     - Secondary diagonal elements are elements in which the sum of the line and column index values equals n-1.
//!     - A square matrix is symmetrical if the values of every two opposite elements with respect to the main diagonal are equal,
//!       that is: x[i, j] = x[j, i].

//* Declaring Variables.
int[,] MAT = new int[4, 4];
int i, j;


// *Entering Array Elements.
for (i = 0; i < 4; i++)
{
    for (j = 0; j < 4; j++)
    {
        Console.Write("MAT( " + i + " , " + j + " )=");
        MAT[i, j] = Int32.Parse(Console.ReadLine());
    }
}


//* Printing Array Elements.
for (i = 0; i < 4; i++)
{
    for (j = 0; j < 4; j++)
    {
        Console.Write(MAT[i, j] + " ");
    }
    Console.WriteLine();
}


//* Finding Sum.
int sum_diag = 0;
for (i = 0; i < 4; i++)
{
    for (j = 0; j < 4; j++)
    {
        if (i == j)
        {
            sum_diag += MAT[i, j];
        }
    }
}
Console.WriteLine("MAIN DIAG SUM IS : " + sum_diag);


//* Finding Max.
int max = 0;
for (i = 0; i < 4; i++)
{
    for (j = 0; j < 4; j++)
    {
        if (i + j == 3)
        {
            if (MAT[i, j] > max)
            {
                max = MAT[i, j];
            }
        }
    }
}
Console.WriteLine("SECOND DIAG MAX IS : " + max);


//* Testing Symmetric.
bool symmetric = true;
for (i = 0; i < 4; i++)
{
    for (j = 0; j < 4; j++)
    {
        if (MAT[i, j] != MAT[j, i])
        {
            symmetric = false;
        }
    }
}
if (symmetric == true)
{
    Console.WriteLine("ARRAY IS SYMMETRIC");
}
else
{
    Console.WriteLine("ARRAY IS NOT SYMMETRIC");
}


//* -------------------------------------------------------------------------


