using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondColl
{
    internal class Sorts
    {

        public int[] array;

        public List<string> iterations = new List<string>();
        public int counter = 0;


        public Sorts(int[] array) 
        {
            int[] destinationArray = new int[array.Length]; // Create destination array

            Array.Copy(array, destinationArray, array.Length);
            this.array = destinationArray;
        }

        public void reset(int[] array)
        {
            this.array = array;
            iterations = new List<string>();
            counter = 0;
        }
        public void GnomeSort()
        {
            int index = 0;
            int length = array.Length;

            while (index < length)
            {
                if (index == 0)
                    index++;
                if (array[index] >= array[index - 1])
                    index++;
                else
                {
                    int temp = array[index];
                    array[index] = array[index - 1];
                    array[index - 1] = temp;
                    string res = "[" + string.Join(", ", array) + "]";
                    iterations.Add(res);
                    counter++;
                    index--;
                }

            }
        }


        public void BitonicMerge(int[] arr, int low, int count, bool ascending)
        {
            if (count > 1)
            {
                int k = count / 2;
                for (int i = low; i < low + k; i++)
                {
                    if ((arr[i] > arr[i + k]) == ascending)
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + k];
                        arr[i + k] = temp;
                        string res = "[" + string.Join(", ", array) + "]";
                        iterations.Add(res);
                        counter++;
                    }
                }
                BitonicMerge(arr, low, k, ascending);
                BitonicMerge(arr, low + k, k, ascending);
            }
        }

        public void BitonicSortRec(int[] arr, int low, int count, bool ascending)
        {
            if (count > 1)
            {
                int k = count / 2;

                BitonicSortRec(arr, low, k, true);
                BitonicSortRec(arr, low + k, k, false);
                BitonicMerge(arr, low, count, ascending);
            }
        }

        public void BitonicSort( bool ascending)
        {
            BitonicSortRec(array, 0, array.Length, ascending);
        }



        public void OddEven_Sort()
        {
            int n = array.Length;
            bool sorted = false;

            while (!sorted)
            {
                sorted = true;

                for (int i = 1; i <= n - 2; i += 2)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        string res = "[" + string.Join(", ", this.array) + "]";
                        iterations.Add(res);
                        counter++;
                        sorted = false;
                    }

                }

                for (int i = 0; i <= n - 2; i += 2)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        string res = "[" + string.Join(", ", this.array) + "]";
                        iterations.Add(res);
                        sorted = false;
                    }
                    counter++;
                }
            }
        }
    }
}
