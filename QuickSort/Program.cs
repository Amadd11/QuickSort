using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        //array of interger to hold values
        private int[] arr = new int[20];
        private int cmp_count = 0;
        private int mov_count = 0;

        //Number od elements in array
        private int n;

        void read()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 30 elements \n");
            }
            Console.WriteLine("\n====================");
            Console.WriteLine(" Enter Array Elements");
            Console.WriteLine("\n====================");

            // get array elements
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
    
        }
        //swap the elements at index x with the element at index y
        void swap(int x,int y)
        {
            int temp;

            temp =arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        public void q_sort(int low,int high)
        {
            int pivot, i, j;
            if (low > high)
                return;
            //partition the list into two parts :
            //one containing element less that or equal to pivot
            //oither containing elemets greather than pivot

            i = low + 1;
            j = high;

            pivot = arr[low];

            while(i <= j)
            {
                //Search for an elements greather than pivot
                while ((arr[i] <= pivot) && (arr[j] <= high))
                {
                    i++;
                    cmp_count++;
                }
            }

        }
    }
}
