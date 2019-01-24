using System;
using System.Collections.Generic;
using System.Text;
using test11.Models;

namespace test11.QuickSort
{
    class QS
    {

        /* This function takes last element as pivot, 
    places the pivot element at its correct 
    position in sorted array, and places all 
    smaller (smaller than pivot) to left of 
    pivot and all greater elements to right 
    of pivot */
        private static int Partition(IList<Product> product, int low, int high)
        {
            var pivot = product[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than or equal to pivot 
                if (string.Compare(product[j].Name, pivot.Name) <= 0)
                {
                    i++;

                    // swap product[i] and product[j] 
                    var temp = product[i];
                    product[i] = product[j];
                    product[j] = temp;
                }
            }

            // swap product[i+1] and product[high] (or pivot) 
            var temp1 = product[i + 1];
            product[i + 1] = product[high];
            product[high] = temp1;

            return i + 1;
        }


        /* The main function that implements QuickSort() 
        product[] --> List to be sorted, 
        low --> Starting index, 
        high --> Ending index */
        public static void QuickSort(IList<Product> product, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, product[pi] is  
                now at right place */
                int pi = Partition(product, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                QuickSort(product, low, pi - 1);
                QuickSort(product, pi + 1, high);
            }
        }



    }
}
