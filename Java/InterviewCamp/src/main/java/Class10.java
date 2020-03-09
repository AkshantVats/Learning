//You are given an array of integers and a pivot. Rearrange the array in the following order:[all elements less than pivot, elements equal to pivot, elements greater than pivot]For example,a = [5,2,4,4,6,4,4,3] and pivot = 4 --> result = [3,2,4,4,4,4,6,5].

public class Class10 {

    public static int[] PivotArray(int[] arr,int pivot)
    {
        if(arr == null || arr.length == 0) {
            return null;
        }

        int high_boundary =arr.length-1;
        int low_boundary =0;
        int i = 0;

        while (i <= high_boundary)
        {
            if(arr[i] < pivot)
            {
                swap(arr,i,low_boundary);
                low_boundary += 1;
                i++;
            }
            else  if(arr[i] > pivot)
            {
                swap(arr,i,high_boundary);
                high_boundary -= 1;
            }
            else
            {
                i++;
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
