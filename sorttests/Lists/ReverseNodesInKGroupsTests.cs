using System;
using Algo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests
{
    [TestClass]
    public class ReverseNodesInKGroupsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algo = new ReverseNodesInKGroups();

            var l = Utils.CreateLinkedList(new [] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11});
            var k = 3;
            var result = algo.reverseNodesInKGroups2(l, k);
            // [3, 2, 1, 6, 5, 4, 9, 8, 7, 10, 11]

            l = Utils.CreateLinkedList(new[] {1, 2, 3, 4, 5});
            k = 2;
            result = algo.reverseNodesInKGroups(l, k);
            //= [2, 1, 4, 3, 5];
            
            l = Utils.CreateLinkedList(new[] {1, 2, 3, 4, 5});
            k = 1;
            result = algo.reverseNodesInKGroups(l, k);
            //= [1, 2, 3, 4, 5];

            l = Utils.CreateLinkedList(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11});
            k = 3;
            result = algo.reverseNodesInKGroups(l, k);
            //= [3, 2, 1, 6, 5, 4, 9, 8, 7, 10, 11].
        }
    }
}
