/*
Implement a data structure for a Least Recently Used (LRU) cache.
*/

using System;
using System.Collections.Generic;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test
{
    public class UnitTest44
    {
        [Fact]
        public void Test1()
        {
            int[] expected = new int[] { 6, 2, 3, 4, 5 };
            LRUCache<int, int> lRUCache = new Code.LRUCache<int, int>(5);
            lRUCache.Write(1, 1);
            lRUCache.Write(2, 2);
            lRUCache.Write(3, 3);
            lRUCache.Write(4, 4);
            lRUCache.Write(5, 5);
            lRUCache.Write(6, 6);

            var result = lRUCache.ToArray();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            int[] expected = new int[] { 1 };
            LRUCache<int, int> lRUCache = new Code.LRUCache<int, int>(1);
            lRUCache.Write(1, 2);
            lRUCache.Write(2, 1);
            var result = lRUCache.ToArray();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            int[] expected = new int[] { 2 };
            LRUCache<int, int> lRUCache = new Code.LRUCache<int, int>(1);
            lRUCache.Write(1, 2);
            var result = lRUCache.ToArray();
            Assert.Equal(expected, result);
        }


    }
}