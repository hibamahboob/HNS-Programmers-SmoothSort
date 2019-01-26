using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoothSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 19, 21, 156, 120, 12, 7 };
            int length = array.Length;

            SmoothSort smoothsort = new SmoothSort();
            smoothsort.sort(array);

            PrintSortedArray(array);
            


        }
    //to print in array
        static void PrintSortedArray(int[] array)
        {
            int len = array.Length;
            for (int i = 0; i < len; ++i)
                Console.WriteLine(array[i] + "");
            Console.Read();
        }
    }
    public class SmoothSort
    {

        //input array to sort
        public void sort(int[] InputArray)
        {
         
            int len = InputArray.Length;
            for (int i = len / 2 - 1; i >= 0; i--)
                LeonardHeap(InputArray, len, i);

            //create binary Heap
            for (int i = len - 1; i >= 0; i--)
            {
                int temp = InputArray[0];
                InputArray[0] = InputArray[i];
                InputArray[i] = temp;
                LeonardHeap(InputArray, i, 0);
            }


        }
        //to compare the childs with root to make the max-heap
        void LeonardHeap(int[] arr, int len, int index)
        {
            int lar = index;
            int l = 2 * index + 1;
            int r = 2 * index + 2;
            
            if (l < len && arr[l] > arr[lar])
                lar = l;

            if (r < len && arr[r] > arr[lar])
                lar = r;

            if (lar != index)
            {
                int swap = arr[index];
                arr[index] = arr[lar];
                arr[lar] = swap;

                LeonardHeap(arr, len, lar);
                
            }

        }

    }
}