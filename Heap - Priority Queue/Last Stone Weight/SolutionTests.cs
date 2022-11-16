using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Stone_Weight
{
    public class SolutionTests
    {
        private Solution? _solution;

        [SetUp]
        public void SetUp()
        {
            _solution = new();
        }

        [Test]
        public void Case1()
        {
            int[] input = { 2, 7, 4, 1, 8, 1 };

            Assert.AreEqual(1, _solution?.LastStoneWeight(input));
        }

        [Test]
        public void Case2()
        {
            int[] input = { 1 };

            Assert.AreEqual(1, _solution?.LastStoneWeight(input));
        }

    }
}
