using System.Text;

namespace BubbleSort_Solution
{
    internal class Utils
    {
        public static List<int> GenerateRandomArray(int min, int max, int size)
        {
            List<int> array = new List<int>();

            Random randNum = new Random();
            int number;
            for (int i = 0; i < size; i++)
            {
                number = randNum.Next(min, max);
                array.Add(number);
            }
            return array;
        }

        public static void Sort(List<int> array)
        {
            int temp = 0;
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array.Count - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        public static bool IsSorted(List<int> array)
        {
            for (int i = 1; i < array.Count; i++)
            {
                if (array[i] < array[i - 1])
                    return false;
            }
            return true;
        }

        public static string ToString(List<int> array)
        {
            StringBuilder sb = new StringBuilder();
            bool isFirst = true;
            for (int i = 0; i < array.Count; i++)
            {
                if (isFirst)
                {
                    isFirst = false;
                } 
                else
                {
                    sb.Append(' ');
                }
                sb.Append(array[i]);
            } 
            return sb.ToString();
        }

        public static void PrintArray(string msg, List<int> array)
        {
            Console.WriteLine("{0}: {1}", msg, ToString(array));
        }
    }
}
