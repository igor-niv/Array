using BubbleSort_Solution;

const int count = 10;

bool isSorted;
for (int i = 0; i < count; i++)
{
    List<int> array = Utils.GenerateRandomArray(1, 200, 10);
    Utils.PrintArray("Unsorted array", array);

    Utils.Sort(array);
    Utils.PrintArray("Sorted array", array);

    isSorted = Utils.IsSorted(array);
    Console.WriteLine("Array is sorted: {0}", isSorted.ToString().ToUpper());
    Console.WriteLine();
}