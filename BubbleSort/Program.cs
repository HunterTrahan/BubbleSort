using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayToSort = { 45, 6, 12, 51, 4, 23, 31 };
            //this is intitialization
            int number;
            //this is declaration
            

            
           void Print()
           {
                for (int i = 0; i < arrayToSort.Length; i++)
                {
                    Console.WriteLine(arrayToSort[i]);
                }
           }

            //nark that we need to sort
           bool Sorted = false;
            //while we need to sort
           while (!Sorted)
           {
                Sorted = true;
                //Iterate through array
                for (int i = 0; i < arrayToSort.Length-1; i++)
                {
                    //if current item and the next arem't in order
                    if (arrayToSort[i] > arrayToSort[i+1])
                    {
                        //swap them
                        number = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i+1];
                        arrayToSort[i + 1] = number;

                        //mark that we need to sort
                        Sorted = false;
                        
                    }

                }
           }
            Print();
            //while (!sorted)
            //{
            //    sorted = true;
            //    //loop through array
            //    {
            //        if (out of order)
            //            {
            //            //swap
            //            sorted = false;
            //            }
            //    }
            //}

            Console.ReadKey();

        }
    }
}
