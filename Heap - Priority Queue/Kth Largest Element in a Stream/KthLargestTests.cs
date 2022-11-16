using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kth_Largest_Element_in_a_Stream
{
    class KthLargestTests
    {
        private KthLargest? Mock;

        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void Case1()
        {
            int kth = 3;
            int[] stream = { 4, 5, 8, 2 };

            this.Mock = new(kth, stream);

            Assert.AreEqual(Mock.Add(3), 4);
            Assert.AreEqual(Mock.Add(5), 5);
            Assert.AreEqual(Mock.Add(10), 5);
            Assert.AreEqual(Mock.Add(9), 8);
            Assert.AreEqual(Mock.Add(4), 8);
        }
    }
}
