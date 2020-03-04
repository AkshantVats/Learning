//Given an array of numbers, move each zero number at the end of the array. e.g, [1,0,5,0,8] -> [1,5,8,0,0].

public class Class2 {

    public static int[] MoveZerosToEnd(int[] arr)
    {
        if(arr == null || arr.length == 0)
        {
            return  null;
        }


        int count = 0;
        for (int i = 0; i < arr.length; i++) {

            if(arr[i] != 0)
            {
                arr[count++] = arr[i];
            }
        }

        while (count < arr.length)
        {
            arr[count++] = 0;
        }
        return arr;
    }
}
