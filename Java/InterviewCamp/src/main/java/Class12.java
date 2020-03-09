//Given an array of integers that can be both +ve and -ve, find the contiguous subarray with the largest sum.For example: [1,2,-1,2,-3,2,-5] -> first 4 elements have the largest sum. Return (0,3)

public class Class12 {

    public static int continuousSubArray(int[] arr)
    {
        if(arr == null || arr.length == 0) {
            return 0;
        }

        int maxSum = arr[0], maxEnding = arr[0];

        for (int i = 1; i < arr.length; i++) {

            maxEnding = Math.max(maxEnding+arr[i] , arr[i]);
            maxSum = Math.max(maxSum,maxEnding);
        }
        return  maxSum;
    }
}
