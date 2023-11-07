// See https://aka.ms/new-console-template for more information


//* >>>>>>>>>> Practice On Compound Data Types <<<<<<<<<< //

//* Exercise - 1 : Problem of unary matrix evaluations.
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
//* Write a program that uses three one-dimensional arrays CURRENT, RESISTANCE, and VLOT to store the values of currents, resistors, and voltages, respectively.
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