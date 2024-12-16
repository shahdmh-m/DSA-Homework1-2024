using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Homework1
{
    public class Searcher
    {
        public int TernarySearch(int[] array, int target, int left, int right)
        {
            if (left > right)
            {
                return -1; // ÇáÚäÕÑ ÛíÑ ãæÌæÏ İí ÇáãÕİæİÉ
            }

            // ÍÓÇÈ ÇáäŞØÊíä ÇáæÓØíÊíä
            int mid1 = left + (right - left) / 3;
            int mid2 = right - (right - left) / 3 * 2;

            if (array[mid1] == target)
            {
                return mid1;
            }

            if (array[mid2] == target)
            {
                return mid2;
            }

            if (target < array[mid1])
            {
                // ÇáÈÍË İí ÇáäØÇŞ ÇáÃæá
                return TernarySearch(array, target, left, mid1 - 1);
            }
            else if (target > array[mid2])
            {
                // ÇáÈÍË İí ÇáäØÇŞ ÇáËÇáË
                return TernarySearch(array, target, mid2 + 1, right);
            }
            else
            {
                // ÇáÈÍË İí ÇáäØÇŞ ÇáËÇäí
                return TernarySearch(array, target, mid1 + 1, mid2 - 1);
            }
        }  
    }
}
