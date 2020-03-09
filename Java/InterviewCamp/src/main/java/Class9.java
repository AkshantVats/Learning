//Given an array of integers, rearrange the elements such that all zeros are moved to the end of the array.

public class Class9 {

    public static int[] RearrangeArray(int[] arr)
    {
        if(arr == null || arr.length == 0) {
            return null;
        }

        int boundary =arr.length-1;
        for (int i = arr.length-1; i >= 0; i--) {

            if(arr[i] == 0)
            {
                swap(arr, i, boundary);
                boundary -= 1;
            }
        }
        return  arr;
    }

    private static void swap(int[] arr, int i, int boundary) {
        int temp = arr[i];
        arr[i] = arr[boundary];
        arr[boundary] = temp;
    }
}
