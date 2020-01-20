/*
Phone Number Mnemonics: Given an N digit phone number, print all the strings that can be made from that phone number. Since 1 and 0 don't correspond to any characters, ignore them.
*/
using System;
using System.Collections.Generic;

namespace InterviewCampProblems.Code {
    public class Class28 {

        public static string[] PrintCombos (int[] arr) {
            if (arr == null || arr.Length == 0) {
                return null;
            }

            char[] buffer = new char[arr.Length];
            List<string> result = new List<string> ();
            PrintCombosHelper (arr, buffer, 0, 0, result);
            return result.ToArray ();
        }

        private static void PrintCombosHelper (int[] arr, char[] buffer, int startIndex, int bufferIndex, List<string> result) {
            if (bufferIndex >= buffer.Length || arr.Length <= startIndex) {
                result.Add (new string (buffer).Replace (char.MinValue.ToString (), string.Empty));
                return;
            }

            char[] letters = GetLetters (arr[startIndex]);

            if (letters.Length == 0) {
                PrintCombosHelper (arr, buffer, startIndex + 1, bufferIndex, result);
            }

            foreach (var letter in letters) {
                buffer[bufferIndex] = letter;
                PrintCombosHelper (arr, buffer, startIndex + 1, bufferIndex + 1, result);
            }

        }

        private static char[] GetLetters (int digit) {
            switch (digit) {
                case 0:
                    return new char[] { };
                case 1:
                    return new char[] { };
                case 2:
                    return new char[] { 'a', 'b', 'c' };
                case 3:
                    return new char[] { 'd', 'e', 'f' };
                case 4:
                    return new char[] { 'g', 'h', 'i' };
                case 5:
                    return new char[] { 'j', 'k', 'l' };
                case 6:
                    return new char[] { 'm', 'n', 'o' };
                case 7:
                    return new char[] { 'p', 'q', 'r', 's' };
                case 8:
                    return new char[] { 't', 'u', 'v' };
                case 9:
                    return new char[] { 'w', 'x', 'y', 'z' };
            }
            throw new ArgumentException ("Invalid Digit " + digit);
        }

        private static int ConvertToInt (int[] buffer) {
            int x = 0;
            int multipicator = 1;
            for (int i = buffer.Length - 1; i >= 0; i--) {
                x += buffer[i] * multipicator;
                multipicator *= 10;
            }

            return x;
        }
    }
}