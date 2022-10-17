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
                    Console.WriteLine("\nArray can have maximum 20 elements \n");
            }
            Console.WriteLine("\n====================");
            Console.WriteLine(" Enter Array Elements");
            Console.WriteLine("\n====================");

            // get array elements
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }

        }
        //swap the elements at index x with the element at index y
        void swap(int x, int y)
        {
            int temp;

            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        public void q_sort(int low, int high)
        {
            int pivot, i, j;
            if (low > high)
                return;

            //Partition the list into two parts
            //One containing elements less that or equal to pivot
            //Outher conntainning elements greather than pivot

            i = low + 1;
            j = high;

            pivot = arr[low];

            while (i <= j)
            {
                //search for an element gretate than pivot
                while ((arr[i] <= pivot) && (i <= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;

                //Search for an element less than or equal to pivot
                while ((arr[j] > pivot) && (j >= low))
                {
                    j--;
                    cmp_count++;
                }

                if (i < j) //if the greater element is on the left of the element
                {
                    //swap the element at index i with the element at index j
                    swap(i, j);
                    mov_count++;
                }
            }
            //j now contains the index of the last element in the sorted list

            if (low < j)
            {
                //move the pivot to it's correct position in the list
                swap(low, j);
                mov_count++;
            }
            //sort the list on the left of the pivot using quick sort
            q_sort(low, j - 1);

            //sort the list on the right of the pivot using quick sort
            q_sort(j + 1, high);
        }

        void display()
        {
            Console.WriteLine("\n------------------");
            Console.WriteLine(" Sorted Array Elements ");
            Console.WriteLine("--------------------");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(arr[j]);
            }
            Console.WriteLine("\nNumber of comparisons " + cmp_count);
            Console.WriteLine("\nNumber of data movements: " + mov_count);
        }
        int getsize()
        {
            return n;
        }
        static void Main(string[] args)
        {
            //declaring the object of the class
            Program mylist = new Program();
            //Accept array elements
            mylist.read();
            //calling the sorting function
            //frist call to quick sort alogarithm
            mylist.q_sort(0, mylist.getsize() - 1);
            //Display sorted array
            mylist.display();
            //to exit from the console
            Console.WriteLine("\n\nPress enter to exit. ");
            Console.Read();
        }
    }
}