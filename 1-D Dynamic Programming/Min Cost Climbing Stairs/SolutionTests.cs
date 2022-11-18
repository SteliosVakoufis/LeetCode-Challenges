using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Cost_Climbing_Stairs
{
    public class SolutionTests
    {
        private Solution _solution;

        [SetUp]
        public void SetUp()
        {
            _solution = new();
        }

        [Test]
        public void Case1()
        {
            int[] costs = { 10, 15, 20 };

            Assert.AreEqual(15, _solution.MinCostClimbingStairs(costs));
        }

        [Test]
        public void Case2()
        {
            int[] costs = { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };

            Assert.AreEqual(6, _solution.MinCostClimbingStairs(costs));
        }
    }
}
