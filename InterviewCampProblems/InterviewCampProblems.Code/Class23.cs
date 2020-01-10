/*
Find the square root of an integer X. For example, squareRoot(4) = 2.If X is not a perfect square, find the integer floor of the square root. For example,squareRoot(5) & squareRoot(8) will return 2. squareRoot(9) will return 3.
*/
using System;
using System.Collections.Generic;

namespace InterviewCampProblems.Code {
    public class Class23 {

        public static int FloorSquareRoot (int x) {

            if (x == 0) return 0;
            if (x == 1) return 1;

            int low = 0;
            int high = x / 2;
            while (low <= high) {
                int mid = low + (high - low) / 2;
                if (mid * mid > x) {
                    high = mid - 1;
                } else if (mid * mid < x) {
                    if ((mid + 1) * (mid + 1) > x) {
                        return mid;
                    }
                    low = mid + 1;
                } else {
                    return mid;
                }
            }

            return -1;
        }
    }
}