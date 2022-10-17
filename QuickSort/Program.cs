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
    }
}
