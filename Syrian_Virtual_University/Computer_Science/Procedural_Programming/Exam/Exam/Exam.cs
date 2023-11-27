// See https://aka.ms/new-console-template for more information


Console.WriteLine("\nHello, \"Doctor Hwaida\"\n");
Console.WriteLine("I'm kifah (ID: kifah_134765), and this is my HW:\n");

Console.WriteLine("-------------------------------------------\n");

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

//! ........... The First Problem : Algorithms Functions ...........

Console.WriteLine("........ The first problem: sorting and arranging arrays ........\n");

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

// 2 - Merge Sort function.
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
// End Merge Sort function.

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

// 3 - Insertion Sort function.
static void InsertionSort(int[] array)
{
    int n = array.Length;
    for (int i = 1; i < n; ++i)
    {
        int key = array[i];
        int j = i - 1;


        while (j >= 0 && array[j] > key)
        {
            array[j + 1] = array[j];
            j = j - 1;
        }

        array[j + 1] = key;
    }
}
// End Insertion Sort function.

Console.WriteLine("3 - Insertion Sort Algorithm ..\n");

// Create random array.
int[] randomArray3 = CreateRandomArray();

// Print original array - (Print array before sorted by Insertion sort algorithm).
Console.WriteLine("Original Array:");
PrintArray(randomArray3);

// Call the Insertion Sort function
InsertionSort(randomArray3);

// Print array after sorted by Insertion sort algorithm
Console.WriteLine("\nSorted Array By Insertion Sort Algorithm:");
PrintArray(randomArray3);

Console.WriteLine("\n-------------------------------------------\n");

// 4 - Bucket Sort function.
static void BucketSort(int[] arr)
{
    int n = arr.Length;
    List<int>[] buckets = new List<int>[n];

    // Create buckets
    for (int i = 0; i < n; i++)
    {
        buckets[i] = new List<int>();
    }

    // Place elements into appropriate buckets
    for (int i = 0; i < n; i++)
    {
        int bucketIndex = arr[i] / 10; // Adjust as needed based on the range of your integers
        buckets[bucketIndex].Add(arr[i]);
    }

    // Sort each bucket using a simple sorting algorithm (another sorting algorithm can be used)
    for (int i = 0; i < n; i++)
    {
        buckets[i].Sort();
    }

    // Collect the sorted elements from the buckets
    int index = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < buckets[i].Count; j++)
        {
            arr[index++] = buckets[i][j];
        }
    }
}
// End Bucket Sort function.

Console.WriteLine("4 - Bucket Sort Algorithm ..\n");

// Create random array.
int[] randomArray4 = CreateRandomArray();

// Print original array - (Print array before sorted by Bucket sort algorithm).
Console.WriteLine("Original Array:");
PrintArray(randomArray4);

// Call the Bucket Sort function
BucketSort(randomArray4);

// Print array after sorted by Bucket sort algorithm
Console.WriteLine("\nSorted Array By Bucket Sort Algorithm:");
PrintArray(randomArray4);

Console.WriteLine("\n-------------------------------------------\n");

// 5 - Quick Sort function.
// Function to get the pivot position.
static int Partition(int[] array, int low, int high)
{
    int pivot = array[high];
    int i = low - 1;

    for (int j = low; j < high; j++)
    {
        if (array[j] <= pivot)
        {
            i++;
            Swap(array, i, j);
        }
    }

    Swap(array, i + 1, high);
    return i + 1;
}

// Function to swap two values in the array.
static void Swap(int[] array, int i, int j)
{
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}

// Quick Sort function
static void QuickSort(int[] array, int low, int high)
{
    if (low < high)
    {
        // Get the pivot position and sort elements around it.
        int pivotIndex = Partition(array, low, high);

        // Recursively sort the sub arrays.
        QuickSort(array, low, pivotIndex - 1);
        QuickSort(array, pivotIndex + 1, high);
    }
}
// End Quick Sort function.

Console.WriteLine("5 - Quick Sort Algorithm ..\n");

// Create random array.
int[] randomArray5 = CreateRandomArray();

// Print original array - (Print array before sorted by Quick sort algorithm).
Console.WriteLine("Original Array:");
PrintArray(randomArray5);

// Call the Quick Sort function
BucketSort(randomArray5);

// Print array after sorted by Quick sort algorithm
Console.WriteLine("\nSorted Array By Quick Sort Algorithm:");
PrintArray(randomArray5);

Console.WriteLine("\n-------------------------------------------\n");

//! ........... End The First Problem : End Algorithms Functions ...........


//! ........... The Second Problem : encryption and decryption of texts ...........
Console.WriteLine("........ The second problem: encryption and decryption of texts ........\n");

Console.WriteLine("1 - Encryption process:\n");

/*
// 1 - Encryption process:

// دالة لقراءة النص من ملف
static string ReadFromFile(string filePath)
{
    try
    {
        // قراءة النص من الملف
        return File.ReadAllText(filePath);
    }
    catch (IOException e)
    {
        Console.WriteLine($"حدث خطأ أثناء قراءة الملف: {e.Message}");
        return string.Empty;
    }
}

// دالة لكتابة النص إلى ملف
static void WriteToFile(string filePath, string text)
{
    try
    {
        // كتابة النص إلى الملف
        File.WriteAllText(filePath, text);
        Console.WriteLine("تمت كتابة النص المشفر إلى الملف بنجاح.");
    }
    catch (IOException e)
    {
        Console.WriteLine($"حدث خطأ أثناء كتابة الملف: {e.Message}");
    }
}

// دالة لتشفير النص بواسطة تشفير قيصر
static string CaesarCipherEncrypt(string input, int shift)
{
    char[] result = input.ToCharArray();

    for (int i = 0; i < result.Length; i++)
    {
        // تحقق من أن الحرف هو حرف أبجدي
        if (char.IsLetter(result[i]))
        {
            // تحويل الحرف بمقدار التحريك
            result[i] = CaesarCipherShiftCharacter(result[i], shift);
        }
    }

    return new string(result);
}

// دالة لتحويل حرف واحد بواسطة تشفير قيصر
static char CaesarCipherShiftCharacter(char character, int shift)
{
    // التحويل بحسب التحريك والحفاظ على حالة الحرف
    char baseChar = char.IsUpper(character) ? 'A' : 'a';
    return (char)(((character - baseChar + shift + 26) % 26) + baseChar);
}

*/



/*



// اسم الملف الذي يحتوي على النص الأصلي (يفترض أن يكون في نفس الدليل)
string inputFilePath = @"D:\input_txt.txt";

// اسم الملف الذي سيتم كتابة النص المشفر إليه (يفترض أن يكون في نفس الدليل)
string outputFilePath = @"D:\output_txt.txt";

// مقدار التحريك (يمكن تغييره إلى أي قيمة أخرى)
int shiftAmount = 3;

// قراءة النص من الملف
string originalText = ReadFromFile(inputFilePath);

// تشفير النص
string encryptedText = CaesarCipherEncrypt(originalText, shiftAmount);

// كتابة النص المشفر إلى ملف آخر
WriteToFile(outputFilePath, encryptedText);

// عرض النتائج
Console.WriteLine("Original Text: " + originalText);
Console.WriteLine("Encrypted Text: " + encryptedText);

*/

//! ........... End The Second Problem : encryption and decryption of texts ...........
