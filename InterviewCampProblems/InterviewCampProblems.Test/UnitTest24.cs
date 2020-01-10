/*
A peak element in an array A is an A[i] where its neighboring elements are less than A[i].So, A[i - 1] < A[i] and A[i + 1] < A[i].Assume there are no duplicates. Also, assume that A[-1] and A[length] are negative infinity (-∞).So A[0] can be a peak if A[1] < A[0].A = [1,3,4,5,2] => Peak = 5 A = [5,3,1] => Peak = 5 A = [1,3,5] => Peak = 5
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest24 {
        [Fact]
        public void Test1 () {
            int expected = 3; //index
            int[] arr = new int[] { 1, 3, 4, 5, 2 };
            var actual = Class24.FindPeak (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {
            int expected = 1;
            int[] arr = new int[] {-1, 3, -4, -5, 2 };
            var actual = Class24.FindPeak (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {
            int expected = 0;
            int[] arr = new int[] {-1 };
            var actual = Class24.FindPeak (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test4 () {
            int expected = -1;
            int[] arr = null;
            var actual = Class24.FindPeak (arr);
            Assert.Equal (expected, actual);
        }
    }
}