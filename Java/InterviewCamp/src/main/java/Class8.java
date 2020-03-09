//You are given an array of integers. Rearrange the array so that all zeroes are at the beginning of the array.For example,a = [4,2,0,1,0,3,0] -> [0,0,0,1,2,3,4]

public class Class8 {

    public static int[] RearrangeArray(int[] arr)
    {
        if(arr == null || arr.length == 0) {
            return null;
        }

        int boundary =0;
        for (int i = 0; i <= arr.length-1; i++) {

            if(arr[i] == 0)
            {
                swap(arr, i, boundary);
                boundary += 1;
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
