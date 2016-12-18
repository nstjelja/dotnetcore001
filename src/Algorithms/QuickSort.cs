using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class QuickSort
    {
        public List<int> Sort(List<int> numbersToSort)
        {    
            if (numbersToSort.Count < 2)
                return numbersToSort;

            var pivot = numbersToSort[0];
            var left = new List<int>();
            var right = new List<int>();

            numbersToSort.RemoveAt(0);

            numbersToSort.ForEach((i)=>{
                if (i<=pivot) {
                    left.Add(i);
                }

                right.Add(i);
            });

            var result = new List<int>();
            result.AddRange(Sort(left));
            result.Add(pivot);
            result.AddRange(Sort(right));

            return result;
            
        }
    }
}
