using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        //this is intitialization
        static int swaps = 0;
        static int loops = 0;

        static void Main(string[] args)
        {
            //int[] arrayToSort = { 45, 6, 12, 51, 4, 23, 31 };

            int[] arrayToSort = { 14, 65, 63, 1, 54, 89, 84, 9, 98, 57,
                                  71, 18, 21, 84, 69, 28, 11, 83, 13, 42,
                                  64, 58, 78, 82, 13, 9, 96, 14, 39, 89,
                                  40, 32, 51, 85, 48, 40, 23, 15, 94, 93,
                                  35, 81, 1, 9, 43, 39, 15, 17, 97, 52
            };


           //this is declaration
           void Print()
           {
               for (int i = 0; i < arrayToSort.Length; i++)
               {
                   Console.WriteLine(arrayToSort[i]);
               }
           }

            //BubbleSort(arrayToSort);
            Console.WriteLine("");
            //OptimizedBubbleSort(arrayToSort);
            Console.WriteLine("");
            CocktailShakerSort(arrayToSort);
            Print();

            Console.WriteLine("");
            Console.WriteLine("Loops: " + loops);
            Console.WriteLine("Swaps: " + swaps);
            Console.ReadKey();
        }

        //public static void BubbleSort(int[] arrayToSort)
        //{

        //    int number;

        //    //nark that we need to sort
        //    bool Sorted = false;
        //    //while we need to sort
        //    while (!Sorted)
        //    {
        //        Sorted = true;
        //        //Iterate through array
        //        for (int i = 0; i < arrayToSort.Length - 1; i++)
        //        {
        //            //if current item and the next aren't in order
        //            if (arrayToSort[i] > arrayToSort[i + 1])
        //            {
        //                //swap them
        //                number = arrayToSort[i];
        //                arrayToSort[i] = arrayToSort[i + 1];
        //                arrayToSort[i + 1] = number;

        //                //mark that we need to sort
        //                Sorted = false;
        //                swaps++;
        //                //i = 0;

        //            }
        //            loops++;

        //        }

        //    }
        //}


        //public static void OptimizedBubbleSort(int[] arrayToSort)
        //{
        //    int number1 = 1;
        //    int number;

        //    //nark that we need to sort
        //    bool Sorted = false;
        //    //while we need to sort
        //    while (!Sorted)
        //    {
        //        Sorted = true;
        //        //Iterate through array
        //        for (int i = 0; i < arrayToSort.Length - number1; i++)
        //        {
        //            //if current item and the next aren't in order
        //            if (arrayToSort[i] > arrayToSort[i + 1])
        //            {
        //                //swap them
        //                number = arrayToSort[i];
        //                arrayToSort[i] = arrayToSort[i + 1];
        //                arrayToSort[i + 1] = number;

        //                //mark that we need to sort
        //                Sorted = false;
        //                swaps++;
        //                //i = 0;

        //            }
                    
        //            loops++;
        //        }
        //        number1++;
        //    }
        //}

        public static void CocktailShakerSort(int[] arrayToSort)
        {
            int start = 0;
            int end = arrayToSort.Length - 1;
            int number;

            //nark that we need to sort
            bool Sorted = false;
            //while we need to sort
            while (!Sorted)
            {
                Sorted = true;
                //Iterate through array
                for (int i = start; i < end; i++)
                {
                    //if current item and the next aren't in order
                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        //swap them
                        number = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i + 1];
                        arrayToSort[i + 1] = number;

                        //mark that we need to sort
                        Sorted = false;
                        swaps++;
                        //i = 0;

                    }

                    loops++;
                }
                end--;
                

                for (int i = end; i > start; i--)
                {
                    //if current item and the next aren't in order
                    if (arrayToSort[i] < arrayToSort[i - 1])
                    {
                        //swap them
                        number = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i - 1];
                        arrayToSort[i - 1] = number;

                        //mark that we need to sort
                        Sorted = false;
                        swaps++;
                        //i = 0;

                    }

                    loops++;
                }
                start++;
            }
        }

    }
}
