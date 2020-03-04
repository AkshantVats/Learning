//Given an array of integers, find the shortest sub array, that if sorted, results in the entire array being sorted.For example:[1,2,4,5,3,5,6,7] --> [4,5,3] - If you sort from indices 2 to 4, the entire array is sorted.[1,3,5,2,6,4,7,8,9] --> [3,5,2,6,4] - If you sort from indices 1 to 5, the entire array is sorted.

public class Class7 {

    public static int[] shortestSubArray(int[] arr)
    {
        if(arr == null || arr.length == 0) {
            return null;
        }

        //find first dip
        int firstDip = 0, firstBump = arr.length-1;
        for (int i = 0; i < arr.length-1; i++) {

            if(arr[i] > arr[i+1])
            {
                firstDip = i;
                break;
            }
        }

        if(firstDip == arr.length-1)
        {
            return  null;
        }

        for (int i = arr.length-1; i > 0 ; i--) {

            if(arr[i] < arr[i-1])
            {
                firstBump = i;
                break;
            }
        }

        int smallestNumber = Integer.MAX_VALUE;
        int largestNumber = Integer.MIN_VALUE;
        for (int i = firstDip; i <= firstBump; i++) {

            if(arr[i] > largestNumber)
            {
                largestNumber = arr[i];
            }

            if(arr[i] < smallestNumber)
            {
                smallestNumber = arr[i];
            }
        }

        while (firstDip > 0 && arr[firstDip-1] > smallestNumber)
        {
            firstDip--;
        }

        while (firstBump < (arr.length-1) && arr[firstBump + 1] < largestNumber)
        {
            firstBump++;
        }

       return new int[]{firstDip, firstBump};
    }


}
