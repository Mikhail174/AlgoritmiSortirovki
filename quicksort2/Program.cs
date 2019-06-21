using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quicksort2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 51,95,66,72,38,39,41,15 };

            Console.WriteLine("Original array : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            Quick_Sort(arr, 0, arr.Length - 1);

            Console.WriteLine();
            Console.WriteLine("Sorted array : ");

            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
        }
        private static void Quick_Sort(int[] arr, int qs_left, int qs_right)
        {
             if (qs_left < qs_right)
            {
                int pivot = Partition(arr, qs_left, qs_right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, qs_left, pivot - 1);
                }
                if (pivot + 1 < qs_right)
                {
                    Quick_Sort(arr, pivot + 1, qs_right);
                }

                
            }

            Console.WriteLine("Промежуточное значение Quick_Sort ");

            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }

            Console.WriteLine();

        }
        private static int Partition(int[] arr, int p_left, int p_right)
        {
            int pivot = arr[p_left];
            

            while (true)
            {
                Console.WriteLine("Pivot=" + pivot);
                while (arr[p_left] < pivot)
                {
                    p_left++;
                }

                 while (arr[p_right] > pivot)
                {
                    p_right--;
                }

                if (p_left < p_right)
                {
                    if (arr[p_left] == arr[p_right]) return p_right;

                    int temp = arr[p_left];
                    arr[p_left] = arr[p_right];
                    arr[p_right] = temp;
                    

                }
                else
                {
                    return p_right;
                }

                Console.WriteLine("Промежуточное значение Partition ");

                foreach (var item in arr)
                {
                    Console.Write(" " + item);
                }
                Console.WriteLine();
                

            }
        }
    }
}
