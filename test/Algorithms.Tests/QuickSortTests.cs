using System;
using Xunit;
using Algorithms;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void SimpleSort() 
        {
            var data = new List<int>(){1,5,2,5,3,8,4,4,5,7,6};
            var sorted = new List<int>(){1,2,3,4,4,5,5,5,6,7,8};

            var quickSort = new QuickSort();
            var result = quickSort.Sort(data);

            for(var i=0;i<data.Count;i++){
                Assert.Equal(sorted[i],result[i]);
            }
        }
    }
}
