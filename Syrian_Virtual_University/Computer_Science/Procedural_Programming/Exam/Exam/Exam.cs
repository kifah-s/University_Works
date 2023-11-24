// See https://aka.ms/new-console-template for more information
Console.WriteLine("\nHello Doctor Hwaida\n");
Console.WriteLine("I'm kifah (ID: kifah_134765), and this is my HW:\n");
Console.WriteLine("........ The first problem: sorting and arranging arrays ........\n");


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


//! ........... Algorithms Functions ...........

// 1 - Bubble Sort function.
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
// End Bubble Sort function.

// 2 - Merge Sort function.
static void MergeSort(int[] array)
{
    if (array.Length <= 1)
        return;

    int middle = array.Length / 2;
    int[] left = new int[middle];
    int[] right = new int[array.Length - middle];

    // Copy data to temporary arrays left[] and right[]
    Array.Copy(array, 0, left, 0, middle);
    Array.Copy(array, middle, right, 0, array.Length - middle);

    // Recursively sort the sub-arrays
    MergeSort(left);
    MergeSort(right);

    // Merge the sorted halves
    Merge(array, left, right);
}

static void Merge(int[] array, int[] left, int[] right)
{
    int leftIndex = 0, rightIndex = 0, mergedIndex = 0;

    // Compare elements from left and right arrays and merge them
    while (leftIndex < left.Length && rightIndex < right.Length)
    {
        if (left[leftIndex] <= right[rightIndex])
        {
            array[mergedIndex] = left[leftIndex];
            leftIndex++;
        }
        else
        {
            array[mergedIndex] = right[rightIndex];
            rightIndex++;
        }
        mergedIndex++;
    }

    // Copy remaining elements from left, if any
    while (leftIndex < left.Length)
    {
        array[mergedIndex] = left[leftIndex];
        leftIndex++;
        mergedIndex++;
    }

    // Copy remaining elements from right, if any
    while (rightIndex < right.Length)
    {
        array[mergedIndex] = right[rightIndex];
        rightIndex++;
        mergedIndex++;
    }
}
// End Merge Sort function.

//! ........... End Algorithms Functions ...........

//* >>>>>>>>>> End Functions <<<<<<<<<< *//



Console.WriteLine("1 - Bubble Sort Algorithm ..\n");

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


Console.WriteLine("2 - Merge Sort Algorithm ..\n");

// Create random array.
int[] randomArray2 = CreateRandomArray();

// Print original array - (Print array before sorted by merge sort algorithm).
Console.WriteLine("Original Array:");
PrintArray(randomArray2);

// Call the merge Sort function
MergeSort(randomArray2);

// Print array after sorted by merge sort algorithm
Console.WriteLine("\nSorted Array By Merge Sort Algorithm:");
PrintArray(randomArray2);


Console.WriteLine("\n-------------------------------------------\n");

