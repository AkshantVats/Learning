//2 Sum Problem: Given a sorted array of integers, find two numbers in the array that sum to a given integer target.For example, if a = [1,2,3,5,6,7] and target = 11, the answer will be 5 and 6.

public class Class5 {

    public static int[] TwoSumProblem(int[] arr,int target)
    {
        if(arr == null || arr.length == 0 || target == 0) {
            return null;
        }

        int startIndex = 0;
        int endIndex = arr.length-1;
        int sum = 0;
       while (startIndex < endIndex)
       {
           sum = arr[startIndex]+ arr[endIndex];

           if(sum > target)
           {
               endIndex--;
           }
           else if(sum < target)
           {
               startIndex++;
           }
           else
           {
               return  new int[]{ arr[startIndex], arr[endIndex] };
           }
       }
       return null;
    }
}
