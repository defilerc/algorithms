using System;
using Algo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTests
{
    [TestClass]
    public class IsListPalindromeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var l = new ListNode<int>()
            {
                value = 0,
                next = new ListNode<int>()
                {
                    value = 1,
                    next = new ListNode<int>()
                    {
                        value = 0,
                        next = null
                    }
                }
            };

            l = new ListNode<int>()
            {
                value = 1,
                next = new ListNode<int>()
                {
                    value = 2,
                    next = new ListNode<int>()
                    {
                        value = 3,
                        next = new ListNode<int>()
                        {
                            value = 10,
                            next = new ListNode<int>()
                            {
                                value = 3,
                                next = new ListNode<int>()
                                {
                                    value = 2,
                                    next = new ListNode<int>()
                                    {
                                        value = 1,
                                        next = null
                                    }
                                }
                            }
                        }
                    }
                }
            };

            var algo = new IsListPalindrome();
            var result = algo.isListPalindrome(l);
            Assert.IsTrue(result);
        }
    }
}
