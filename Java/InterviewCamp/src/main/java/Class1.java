//Given an array of numbers, replace each even number with two of the same number. e.g, [1,2,5,6,8, , , ,] -> [1,2,2,5,6,6,8,8].Assume that the array has the exact amount of space to accommodate the result.

public class Class1 {

    public static int[] CloneEvenNumbers(int[] arr)
    {
        if(arr == null || arr.length == 0)
        {
            return  null;
        }

        int end = arr.length, i = getLastNumber(arr);

        while (i >= 0)
        {
            if(arr[i] % 2 == 0)
            {
                arr[--end] = arr[i];
            }
            arr[--end] = arr[i];
            i--;
        }

        return arr;

    }

    private static int getLastNumber(int[] arr) {

     int i = arr.length-1;

     while (i >= 0 && arr[i] == -1)
     {
         i--;
     }
     return  i;
    }
}
