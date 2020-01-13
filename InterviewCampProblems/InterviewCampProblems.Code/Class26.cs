/*
Power Function: Implement a function to calculate X^N. Both X and N can be positive or negative. You can assume that overflow doesn't happen.(Try doing it in ​O(log(N))​ time)For example: 2 ^ 2  = 4  2 ^ -2 = 0.25 -2 ^ 3  = -8
*/
using System;
using System.Collections.Generic;

namespace InterviewCampProblems.Code {
    public class Class26 {

        public static double Power (int x, int power) {

            if (x == 0 && power <= 0) { throw new ArithmeticException ("undefined"); }
            double result = PositivePower (Math.Abs (x), Math.Abs (power));

            if (power < 0) result = 1 / result;

            if (x < 0 && power % 2 == 1) result = -1 * result;

            return result;

        }

        private static int PositivePower (int x, int power) {
            if (power == 0) return 1;
            if (power == 1) return x;

            int halfPower = PositivePower (x, power / 2);
            if (power % 2 == 0) {
                return halfPower * halfPower;
            } else {
                return x * halfPower * halfPower;
            }
        }
    }
}