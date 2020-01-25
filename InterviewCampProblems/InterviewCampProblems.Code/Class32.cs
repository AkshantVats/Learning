/*
Maze Problem: You are given a 2D array that represents a maze. It can have 2 values - 0 and 1. 1 represents a wall and 0 represents a path.The objective is to reach the bottom right corner, i.e, A[A.length-1][A.length-1]. You start fromA[0][0]. You can move in 4 directions - up, down, left and right. Find if a path exists to the bottom right of the maze. For example, a path exists in the following maze:0 1 1 1 0 1 1 1 0 0 0 0 1 1 1 0

Solution:
Core Idea:        From every ​a[i][j]​, check if there is a path to the end.
Steps/Splits:     Check from left element, right element, up and down.
Converge/Collect: If any of the checks returns ​true​, return ​true​.
Memoization:      Can we memoize? Yes, for every element, we cansave three states: ​UNVISITED​, ​VISITING​,NO_PATH_FOUND​.
Base Cases:       a[i][j]​ is Out of Bounds, Wall,or the  last element

*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewCampProblems.Code {

    public class Class32 {

        public static bool PathExists (int[, ] arr) {
            if (arr == null || arr.Length == 0) {
                return false;
            }

            State[, ] memo = new State[arr.GetLength (0), arr.GetLength (1)];
            List<int[, ]> result = new List<int[, ]> ();
            return PathExists (arr, 0, 0, memo, result);
        }

        private static bool PathExists (int[, ] arr, int i, int j, State[, ] memo, List<int[, ]> result) {

            if (oob (arr, i, j) || arr[i, j] == 1) {
                return false;
            }

            if (memo[i, j] != State.UNVISITED) {
                return false;
            }

            if (i == (arr.GetLength (0) - 1) && j == (arr.GetLength (1) - 1)) {
                return true;
            }

            memo[i, j] = State.VISITING;

            KeyValuePair<int, int>[] pairs = new KeyValuePair<int, int>[4] {
                new KeyValuePair<int, int> (i + 1, j),
                new KeyValuePair<int, int> (i - 1, j),
                new KeyValuePair<int, int> (i, j + 1),
                new KeyValuePair<int, int> (i, j - 1)
            };

            foreach (var item in pairs) {

                if (PathExists (arr, item.Key, item.Value, memo, result)) {
                    return true;
                }

            }

            memo[i, j] = State.NO_PATH_FOUND;
            return false;

        }

        private static bool oob (int[, ] arr, int i, int j) {

            return i < 0 || i >= arr.GetLength (0) || j < 0 || j >= arr.GetLength (1);

        }

        enum State {
            UNVISITED​ = 0,
            VISITING​ = 1,
            NO_PATH_FOUND​ = 2
        }
    }
}