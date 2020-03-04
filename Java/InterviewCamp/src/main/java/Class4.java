//Given an array, reverse the order of its elements.For example, [3,5,2,5,2,3,9] → [9,3,2,5,2,5,3]

public class Class4 {

    public static int[] ReverseArray(int[] arr)
    {
        if(arr == null || arr.length == 0) {
            return null;
        }


        int startIndex = 0;
        int endIndex = arr.length-1;
       while (startIndex < endIndex)
       {
           Swap(arr, startIndex, endIndex);

           startIndex++;
           endIndex--;
       }

       return arr;

    }

    private static void Swap(int[] arr, int startIndex, int endIndex) {
        int temp = arr[startIndex];
        arr[startIndex] = arr[endIndex];
        arr[endIndex] = temp;
    }
}
