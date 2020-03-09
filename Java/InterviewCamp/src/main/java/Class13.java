//Given an array of positive integers, find a subarray that sums to a given number X.For e.g, input = [1,2,3,5,2] and X=8, Result = [3,5] (indexes 2,3)

public class Class13 {

    public static int[] continuousSubArray(int[] arr, int  target)
    {
        if(arr == null || arr.length == 0) {
            return null;
        }

        int start = 0, end = 0, sum = arr[0];
        while (start < arr.length)
        {
            if(start > end)
            {
                end = start;
                sum = arr[start];
            }

            if(sum < target)
            {
                if(end == arr.length-1)
                {
                    break;
                }

                end++;
                sum = sum + arr[end];
            }
            else if(sum > target)
            {
                sum = sum - arr[start];
                start++;
            }
            else
            {
                return new int[] {arr[start], arr[end]};
            }
        }
        return  null;
    }
}
