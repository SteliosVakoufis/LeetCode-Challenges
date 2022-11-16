using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Stone_Weight
{
    public class Solution
    {
        public int LastStoneWeight(int[] stones)
        {
            PriorityQueue<int, int> priorityQueue = new(Comparer<int>.Create((a, b) => b.CompareTo(a)));

            foreach (int stone in stones)
                priorityQueue.Enqueue(stone, stone);

            while(priorityQueue.Count > 1)
            {
                int x = priorityQueue.Dequeue();
                int y = priorityQueue.Dequeue();

                int smashResult = Math.Abs(x - y);
                if (smashResult == 0)
                    continue;

                priorityQueue.Enqueue(smashResult, smashResult);
            }

            return priorityQueue.Count == 0 ? 0 : priorityQueue.Peek();
        }
    }
}
