using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kth_Largest_Element_in_a_Stream
{
    public class KthLargest
    {
        private PriorityQueue<int, int> Stream;
        private int Kth;

        public KthLargest(int k, int[] nums)
        {
            Stream = new();
            Kth = k;

            foreach(int num in nums)
            {
                Add(num);
            }

        }

        public int Add(int value)
        {
            this.Stream.Enqueue(value, value);
            
            while (this.Stream.Count > Kth)
                this.Stream.Dequeue();

            return this.Stream.Peek();
        }
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */
