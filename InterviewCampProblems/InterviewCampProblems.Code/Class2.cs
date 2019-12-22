/*
Given an array of numbers, move each zero number at the end of the array. e.g, [1,0,5,0,8] -> [1,5,8,0,0].
*/
namespace InterviewCampProblems.Code {
    public class Class2 {

        public static int[] MoveZerosToEnd (int[] arr) {

            if (arr == null || arr.Length == 0) {
                System.Console.WriteLine ("Null or Empty array");
                return arr;
            }

            int j = arr.Length - 1;
            for (int i = j; i >= 0; i--) {
                if (arr[i] == 0) {
                    for (int k = i; k < j; k++) {
                        arr[k] = arr[k + 1];
                    }
                    arr[j] = 0;
                }
            }
            return arr;
        }

    }
}