using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void BubbleSort(int[] array)
        {
            bool has_swapped;
            int n = array.Length;
            do
            {
                has_swapped = false;
                for (int i = 0; i < n-1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(ref array[i], ref array[i + 1]);
                        has_swapped = true;
                    }
                }
                n--;
            } while (has_swapped);
        }

        static void Swap(ref int i, ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }


        private static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] array = new int[50];
            Random random = new Random();
            // Fill with random numbers between 0 and 99
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }

            Print(array);
            Console.WriteLine("Bubble Sort: ");
            BubbleSort(array);
            Print(array);

            Console.ReadLine();
        }
    }
}
