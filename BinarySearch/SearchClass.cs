using System;

namespace Prova
{
    public class SearchClass
    {
        public static int BinarySearch(int[] arr, int first, int last, int key)
        {
            if (last >= first)
            {
                int mid = first + (last - first) / 2;
                if (arr[mid] == key)
                {
                    return mid;
                }
                if (arr[mid] > key)
                {
                    return BinarySearch(arr, first, mid - 1, key);//cerca en el subarray esquerre
                }
                else
                {
                    return BinarySearch(arr, mid + 1, last, key);//cerca en el subarray dret
                }
            }
            return -1;
        }
    }
}