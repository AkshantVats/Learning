//Given a sorted array in non-decreasing order, return an array of squares of each number, also in non-decreasing order. For example:[-4,-2,-1,0,3,5] -> [0,1,4,9,16,25]

public class Class6 {

    public static int[] squareArrayElement(int[] arr)
    {
        if(arr == null || arr.length == 0) {
            return null;
        }

        int startIndex = 0, endIndex = arr.length-1, outputArrIndex = arr.length-1;
        int[] outputArr = new int[arr.length];
        while (startIndex <= endIndex)
        {

            if(abs(arr[startIndex]) > abs(arr[endIndex]))
            {
                outputArr[outputArrIndex] = square(arr[startIndex]);
                startIndex++;
            }
            else
            {
                outputArr[outputArrIndex] = square(arr[endIndex]);
                endIndex--;
            }

            outputArrIndex--;
        }
        return outputArr;
    }

    public static int abs(int i)
    {
        return  i >= 0 ? i : -1 * i;
    }

    public static int square(int i)
    {
        return  i*i;
    }
}
