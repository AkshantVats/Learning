//You're given a list of Marbles. Each marble can have one of 3 colors (Red, White or Blue).Arrange the marbles in order of the colors (Red -> White -> Blue).Colors are represented as follows:0 - Red 1 - White 2 - Blue

public class Class11 {

    public static int[] marblesArray(int[] arr)
    {
        if(arr == null || arr.length == 0) {
            return null;
        }

        int high_boundary =arr.length-1;
        int low_boundary =0;
        int i = 0;

        while (i <= high_boundary)
        {
            if(arr[i] == 0)
            {
                swap(arr,i,low_boundary);
                low_boundary += 1;
                i++;
            }
            else  if(arr[i] == 2)
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
