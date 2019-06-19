using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int vspom;
            int[] array = new int[10];
            Console.WriteLine("Введите элементы массива ");
            for (int i=0;i< array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Введенный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");

            }

            Console.WriteLine();

            for (int i=0;i< array.Length; i++)
            {
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        vspom = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = vspom;

                    }
                }
            }

            Console.WriteLine("Отсортированный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");

            }
        }
    }
}
