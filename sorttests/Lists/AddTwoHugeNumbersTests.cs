using System;
using Algo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests
{
    [TestClass]
    public class AddTwoHugeNumbersTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = new ListNode<int>
            {
                value = 9876,
                next = new ListNode<int>()
                {
                    value = 5432,
                    next = new ListNode<int>()
                    {
                        value = 1999,
                        next = null
                    }
                }
            };
            
            var b = new ListNode<int>
            {
                value = 1,
                next = new ListNode<int>()
                {
                    value = 8001,
                    next = null
                }
            };

            var algo = new AddTwoHugeNumbers();

            var c = algo.addTwoHugeNumbers(a, b);


            a = new ListNode<int>()
            {
                value = 123,
                next = new ListNode<int>()
                {
                    value = 4,
                    next = new ListNode<int>()
                    {
                        value = 5,
                        next = null
                    }
                }
            };

            b = new ListNode<int>()
            {
                value = 100,
                next = new ListNode<int>()
                {
                    value = 100,
                    next = new ListNode<int>()
                    {
                        value = 100,
                        next = null
                    }
                }
            };

            a = new ListNode<int>()
            {
                value = 1
            };

            b = new ListNode<int>()
            {
                value = 9999,
                next = new ListNode<int>()
                {
                    value = 9999,
                    next = new ListNode<int>()
                    {
                        value = 9999
                    }
                }
            };

            var e = algo.addTwoHugeNumbers(a, b);
        }
    }
}
