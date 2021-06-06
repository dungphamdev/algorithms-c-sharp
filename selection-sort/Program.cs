using System;

namespace selection_sort
{
    class Program
    {
        // O(n^2)
        static void selectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                int min_index = i; //flag to save the min index in array

                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_index]) min_index = j;

                //swap i with min index
                int temp = arr[i];
                arr[i] = arr[min_index];
                arr[min_index] = temp;

            }
        }

        // Prints the array
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] arr = { 5, 1, 6, 10, 3, 8, 6 };

            selectionSort(arr);

            printArray(arr);

            Console.WriteLine();

        }
    }
}
