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
        private Dictionary<int, int> _solutions = new();

        public int MinCostClimbingStairs(int[] costs)
        {
            _min = int.MaxValue;

            MinCost(costs, -1, 0);

            return _min;
            //return _solutions.MinBy(kvp => kvp.Value).Value;
        }

        private void MinCost(int[] costs, int index, int cost)
        {
            if (_solutions.ContainsKey(index))
            {
                cost += _solutions[index];
                index = costs.Count();
            }

            if (index >= costs.Length - 2)
            {
                if (cost < _min)
                    _min = cost;
                return;
            }

            index++;
            MinCost(costs, index, cost + costs[index]);
            index++;
            MinCost(costs, index, cost + costs[index]);

            //_solutions.TryAdd(index, cost);
            _solutions.TryAdd(index, cost);
        }
    }
}
