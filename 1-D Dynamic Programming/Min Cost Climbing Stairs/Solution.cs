using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Cost_Climbing_Stairs
{
    public class Solution
    {
        private int _min;

        public int MinCostClimbingStairs(int[] costs)
        {
            _min = int.MaxValue;

            MinCost(costs, 0, 0);

            return _min;
        }

        private void MinCost(int[] costs, int index, int cost)
        {
            if (cost >= _min)
                return;

            if (index >= costs.Length - 1)
            {
                if (cost < _min)
                    _min = cost;
                return;
            }

            MinCost(costs, index + 1, cost + costs[index]);
            index++;
            MinCost(costs, index + 1, cost + costs[index]);
        }
    }
}
