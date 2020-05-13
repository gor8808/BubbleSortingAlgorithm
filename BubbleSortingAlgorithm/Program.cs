using System;

namespace BubbleSortingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {5,4,2,5,6,8 };
            //BubbleSort(arr);
            //InsertionSort(arr);
            SelectionSort(arr);
            
        }

        private static void SelectionSort(int[] arr)
        {
            int min = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if(min < i)
                {
                    min = i;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if(min+j < arr[i])
                    {
                        arr[i] = min + j;
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        private static void InsertionSort(int[] arr)
        {
            int n = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        n = arr[j - 1];
                        arr[j-1] = arr[j];
                        arr[j] = n;
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        private static void BubbleSort(int[] arr)
        {
            int n = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        n = arr[i];
                        arr[i] = arr[j];
                        arr[j] = n;
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
