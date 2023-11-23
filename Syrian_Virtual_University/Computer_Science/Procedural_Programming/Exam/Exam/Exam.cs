// See https://aka.ms/new-console-template for more information
Console.WriteLine("\nHello Doctor Hwaida");
Console.WriteLine("I'm kifah (ID: kifah_134765), and this is my HW:\n");


//* >>>>>>>>>> Functions <<<<<<<<<< *//

// Function to create random array.
static int[] CreateRandomArray()
{
    // Setting up the random number generator.
    Random random = new Random();

    // Array size.
    int arraySize = 100;

    // Creating the array.
    int[] randomArray = new int[arraySize];

    // Filling the array with random numbers.
    for (int i = 0; i < arraySize; i++)
    {
        randomArray[i] = random.Next(1, 100); // Random number in the entire number range.
    }

    return randomArray;
}


// Function to print an array.
static void PrintArray(int[] arr)
{
    foreach (var element in arr)
    {
        Console.Write(element + ",  ");
    }
    Console.WriteLine();
}


//* ........... Algorithms Functions ...........


// Bubble Sort function.
static void BubbleSort(int[] arr)
{
    int n = arr.Length;

    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            // Compare adjacent elements.
            if (arr[j] > arr[j + 1])
            {
                // Swap them if they are in the wrong order.
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}





//* >>>>>>>>>> End Functions <<<<<<<<<< *//

// Create random array.
int[] randomArray1 = CreateRandomArray();

// Print original array - (Print array before sorted by bubble sort algorithm).
Console.WriteLine("Original Array:");
PrintArray(randomArray1);

// Call the Bubble Sort function
BubbleSort(randomArray1);

// Print array after sorted by bubble sort algorithm
Console.WriteLine("\nSorted Array By Bubble Sort Algorithm:");
PrintArray(randomArray1);


Console.WriteLine("\n-------------------------------------------\n");







