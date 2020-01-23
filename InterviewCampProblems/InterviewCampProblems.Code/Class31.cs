/*
Coin Change Problem: Given a set of coin denominations, print out the different ways you can make a target amount. You can use as many coins of each denomination as you like.For example: If coins are [1,2,5] and the target is 5, output will be:[1,1,1,1,1][1,1,1,2][1,2,2][5]
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewCampProblems.Code {
    public class Class31 {

        public static List<int[]> PrintCoins (int[] arr, int x) {
            if (arr == null || arr.Length == 0 || x <= 0) {
                return null;
            }

            List<int[]> result = new List<int[]> ();
            PrintCoinsHelper (arr, x, 0, new Stack<int> (), 0, result);
            return result;
        }

        private static void PrintCoinsHelper (int[] arr, int target, int startIndex, Stack<int> buffer, int sum, List<int[]> result) {

            if (sum > target) {
                return;
            }

            if (sum == target) {
                result.Add (buffer.ToArray ());
                return;
            }

            for (int i = startIndex; i < arr.Length; i++) {
                buffer.Push (arr[i]);
                PrintCoinsHelper (arr, target, i, buffer, arr[i] + sum, result);
                buffer.Pop ();
            }
        }

    }
}