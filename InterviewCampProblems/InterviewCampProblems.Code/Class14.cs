/*
Given a String, find the longest substring with unique characters. For example: "whatwhywhere" --> "atwhy"
*/
using System;
using System.Collections.Generic;

namespace InterviewCampProblems.Code {
    public class Class14 {

        public static int[] SlidingSubArrayString (string input) {

            if (string.IsNullOrEmpty (input)) {
                System.Console.WriteLine ("Null, Empty or Invalid string.");
                return null;
            }
            int[] outputarr = new int[2] { 0, 0 };
            char[] arr = input.ToCharArray ();
            int startIndex = 0;
            int endIndex = 0;
            int longest = 1;
            Dictionary<char, int> dict = new Dictionary<char, int> ();
            dict.Add (arr[0], 0);
            while (endIndex < arr.Length - 1) {
                endIndex++;
                if (dict.ContainsKey (arr[endIndex]) && dict[arr[endIndex]] >= startIndex) {
                    startIndex = dict[arr[endIndex]] + 1;
                    dict[arr[endIndex]] = endIndex;
                } else {
                    dict.Add (arr[endIndex], endIndex);
                }

                if (endIndex - startIndex + 1 > longest) {
                    longest = endIndex - startIndex + 1;
                    outputarr[0] = startIndex;
                    outputarr[1] = endIndex;
                }
            }

            return outputarr;

        }
    }
}