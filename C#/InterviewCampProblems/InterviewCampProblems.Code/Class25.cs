/*
Find the nth number in the Fibonacci series. Fibonacci series is as follows:1, 1, 2, 3, 5, 8, 13, 21, .. After the first two 1’s, each number is the sum of the previous two numbers.
*/
using System;
using System.Collections.Generic;

namespace InterviewCampProblems.Code {
    public class Class25 {

        private static Dictionary<int, int> dict = new Dictionary<int, int> ();

        public static int FibonacciSeries (int n) {

            if (n == 0) {
                return 0;
            }

            if (n == 1 || n == 2) {
                return 1;
            }

            if (dict.ContainsKey (n)) {
                return dict[n];
            }

            var output = FibonacciSeries (n - 1) + FibonacciSeries (n - 2);
            dict.Add (n, output);
            return output;

        }
    }
}