using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_D_Dynamic_Programming
{
    public class SolutionTests
    {
        private Solution _solution;

        [SetUp]
        public void SetUp()
        {
            _solution = new Solution();
        }

        [Test]
        public void Case1()
        {
            int n = 2;
            int expected = 2;

            Assert.AreEqual(expected, _solution.ClimbStairs(n));
        }

        [Test]
        public void Case2()
        {
            int n = 3;
            int expected = 3;

            Assert.AreEqual(expected, _solution.ClimbStairs(n));
        }

        [Test]
        public void Case3()
        {
            int n = 4;
            int expected = 5;

            Assert.AreEqual(expected, _solution.ClimbStairs(n));
        }

        [Test]
        public void Case4()
        {
            int n = 44;
            int expected = 1134903170;

            Assert.AreEqual(expected, _solution.ClimbStairs(n));
        }
    }
}
