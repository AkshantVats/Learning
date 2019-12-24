/*
You're given a list of Marbles. Each marble can have one of 3 colors (Red, White or Blue).Arrange the marbles in order of the colors (Red -> White -> Blue).Colors are represented as follows:0 - Red 1 - White 2 - Blue
*/
using System;

namespace InterviewCampProblems.Code {
    public class Class11 {

        public static int[] ShortMarbles (int[] arr) {

            if (arr == null || arr.Length == 0) {
                System.Console.WriteLine ("Null, Empty or Invalid array.");
                return arr;
            }

            int lowboundary = 0;
            int highboundary = arr.Length - 1;
            int i = 0;
            while (i <= highboundary) {
                if (arr[i] == 0) {
                    Swap (arr, i, lowboundary);
                    lowboundary++;
                    i++;
                } else if (arr[i] == 2) {
                    Swap (arr, i, highboundary);
                    highboundary--;
                } else {
                    i++;
                }
            }
            return arr;
        }

        private static void Swap (int[] arr, int i, int boundary) {
            int temp = arr[i];
            arr[i] = arr[boundary];
            arr[boundary] = temp;
        }
    }
}