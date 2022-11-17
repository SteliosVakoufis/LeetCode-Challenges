using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_D_Dynamic_Programming
{
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            int count = 0;

            Climb(n, ref count);

            return count;
        }

        private void Climb(int steps, ref int count)
        {
            if (steps == 0)
            {
                count++;
                return;
            }

            Climb(steps - 1, ref count);
            if (steps >= 2)
                Climb(steps - 2, ref count);
        }
    }
}
